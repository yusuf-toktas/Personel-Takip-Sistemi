using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace PTS
{
    public partial class FormIzinYonetimi : Form
    {
        public FormIzinYonetimi()
        {
            InitializeComponent();
        }

        private void FormIzinYonetimi_Load(object sender, EventArgs e)
        {
            FiltreleriDoldur();
            IzinleriListele();
        }

        private void FiltreleriDoldur()
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu = "SELECT personel_id, (ad + ' ' + soyad) AS adsoyad FROM personel WHERE aktif_mi = 1 ORDER BY adsoyad";
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow dr = dt.NewRow();
                    dr["personel_id"] = 0;
                    dr["adsoyad"] = "Tüm Personel";
                    dt.Rows.InsertAt(dr, 0);

                    cmbPersonelFiltre.DataSource = dt;
                    cmbPersonelFiltre.DisplayMember = "adsoyad";
                    cmbPersonelFiltre.ValueMember = "personel_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel filtresi doldurulurken hata oluştu: " + ex.Message);
            }

            cmbDurumFiltre.Items.Add("Tümü");
            cmbDurumFiltre.Items.Add("beklemede");
            cmbDurumFiltre.Items.Add("onaylandı");
            cmbDurumFiltre.Items.Add("reddedildi");
            cmbDurumFiltre.SelectedIndex = 0;
        }

        private void IzinleriListele()
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    StringBuilder sorguBuilder = new StringBuilder();
                    sorguBuilder.Append(@"SELECT 
                                        i.izin_id,
                                        p.ad + ' ' + p.soyad AS personel_ad_soyad,
                                        it.izin_turu_adi,
                                        i.baslangic_tarihi,
                                        i.bitis_tarihi,
                                        i.izin_gun_sayisi,
                                        i.onay_durumu,
                                        onaylayan.ad + ' ' + onaylayan.soyad AS onaylayan_kisi
                                     FROM izinler i
                                     INNER JOIN personel p ON i.personel_id = p.personel_id
                                     INNER JOIN izin_turleri it ON i.izin_turu_id = it.izin_turu_id
                                     LEFT JOIN personel onaylayan ON i.onaylayan_personel_id = onaylayan.personel_id
                                     WHERE 1=1");

                    List<SqlParameter> parametreler = new List<SqlParameter>();

                    if (cmbPersonelFiltre.SelectedIndex > 0 && cmbPersonelFiltre.SelectedValue != null)
                    {
                        sorguBuilder.Append(" AND i.personel_id = @personel_id");
                        parametreler.Add(new SqlParameter("@personel_id", cmbPersonelFiltre.SelectedValue));
                    }
                    if (cmbDurumFiltre.SelectedIndex > 0)
                    {
                        sorguBuilder.Append(" AND i.onay_durumu = @onay_durumu");
                        parametreler.Add(new SqlParameter("@onay_durumu", cmbDurumFiltre.SelectedItem.ToString()));
                    }

                    sorguBuilder.Append(" AND i.baslangic_tarihi BETWEEN @bas_tarih AND @bit_tarih");
                    parametreler.Add(new SqlParameter("@bas_tarih", dtpBaslangicTarihi.Value.Date));
                    parametreler.Add(new SqlParameter("@bit_tarih", dtpBitisTarihi.Value.Date));

                    sorguBuilder.Append(" ORDER BY i.talep_tarihi DESC");

                    SqlDataAdapter da = new SqlDataAdapter(sorguBuilder.ToString(), baglanti);
                    if (parametreler.Count > 0)
                    {
                        da.SelectCommand.Parameters.AddRange(parametreler.ToArray());
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewIzinler.DataSource = dt;
                    BasliklariAyarla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İzinler listelenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BasliklariAyarla()
        {
            if (dataGridViewIzinler.Columns.Count > 0)
            {
                dataGridViewIzinler.Columns["izin_id"].HeaderText = "ID";
                dataGridViewIzinler.Columns["personel_ad_soyad"].HeaderText = "Personel";
                dataGridViewIzinler.Columns["izin_turu_adi"].HeaderText = "İzin Türü";
                dataGridViewIzinler.Columns["baslangic_tarihi"].HeaderText = "Başlangıç Tarihi";
                dataGridViewIzinler.Columns["bitis_tarihi"].HeaderText = "Bitiş Tarihi";
                dataGridViewIzinler.Columns["izin_gun_sayisi"].HeaderText = "Gün Sayısı";
                dataGridViewIzinler.Columns["onay_durumu"].HeaderText = "Onay Durumu";
                dataGridViewIzinler.Columns["onaylayan_kisi"].HeaderText = "Onaylayan";

                dataGridViewIzinler.Columns["izin_id"].Width = 50;
                dataGridViewIzinler.Columns["izin_gun_sayisi"].Width = 80;
                dataGridViewIzinler.Columns["onay_durumu"].Width = 100;
            }
        }

        private void DurumGuncelle(int izinId, string yeniDurum)
        {
            // Değişiklik: Artık sabit bir ID yerine, giriş yapan kullanıcının ID'sini kullanıyoruz.
            int onaylayanPersonelId = GirisYapanKullanici.PersonelId;

            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu = "UPDATE izinler SET onay_durumu = @onay_durumu, onaylayan_personel_id = @onaylayan_id WHERE izin_id = @izin_id";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@onay_durumu", yeniDurum);
                    komut.Parameters.AddWithValue("@onaylayan_id", onaylayanPersonelId);
                    komut.Parameters.AddWithValue("@izin_id", izinId);

                    baglanti.Open();
                    komut.ExecuteNonQuery();

                    MessageBox.Show("İzin durumu başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IzinleriListele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Durum güncellenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (dataGridViewIzinler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir izin talebi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int seciliIzinId = Convert.ToInt32(dataGridViewIzinler.SelectedRows[0].Cells["izin_id"].Value);
            string mevcutDurum = dataGridViewIzinler.SelectedRows[0].Cells["onay_durumu"].Value.ToString();

            if (mevcutDurum != "beklemede")
            {
                MessageBox.Show("Sadece 'beklemede' durumundaki izinler için işlem yapabilirsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DurumGuncelle(seciliIzinId, "onaylandı");
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            if (dataGridViewIzinler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir izin talebi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int seciliIzinId = Convert.ToInt32(dataGridViewIzinler.SelectedRows[0].Cells["izin_id"].Value);
            string mevcutDurum = dataGridViewIzinler.SelectedRows[0].Cells["onay_durumu"].Value.ToString();

            if (mevcutDurum != "beklemede")
            {
                MessageBox.Show("Sadece 'beklemede' durumundaki izinler için işlem yapabilirsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DurumGuncelle(seciliIzinId, "reddedildi");
        }

        private void btnYeniIzinTalebi_Click(object sender, EventArgs e)
        {
            using (FormIzinTalebi formTalep = new FormIzinTalebi())
            {
                if (formTalep.ShowDialog() == DialogResult.OK)
                {
                    IzinleriListele();
                }
            }
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            IzinleriListele();
        }

        private void btnFiltreyiTemizle_Click(object sender, EventArgs e)
        {
            cmbPersonelFiltre.SelectedIndex = 0;
            cmbDurumFiltre.SelectedIndex = 0;
            dtpBaslangicTarihi.Value = DateTime.Now.AddMonths(-3);
            dtpBitisTarihi.Value = DateTime.Now.AddMonths(3);
            IzinleriListele();
        }
    }
}