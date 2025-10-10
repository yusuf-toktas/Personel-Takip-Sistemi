using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace PTS
{
    public partial class FormFazlaMesaiYonetimi : Form
    {
        public FormFazlaMesaiYonetimi()
        {
            InitializeComponent();
        }

        private void FormFazlaMesaiYonetimi_Load(object sender, EventArgs e)
        {
            FiltreleriDoldur();
            MesaileriListele();
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

            cmbOdendiFiltre.Items.Add("Tümü");
            cmbOdendiFiltre.Items.Add("Ödenenler");
            cmbOdendiFiltre.Items.Add("Ödenmeyenler");
            cmbOdendiFiltre.SelectedIndex = 0;
        }

        private void MesaileriListele()
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    StringBuilder sorguBuilder = new StringBuilder();
                    sorguBuilder.Append(@"SELECT 
                                        fm.mesai_id, 
                                        p.ad + ' ' + p.soyad AS personel_ad_soyad, 
                                        fm.mesai_tarihi, 
                                        fm.mesai_suresi_saat, 
                                        fm.aciklama, 
                                        CASE WHEN fm.odendi_mi = 1 THEN 'Evet' ELSE 'Hayır' END AS odendi_durumu
                                     FROM fazla_mesailer fm 
                                     INNER JOIN personel p ON fm.personel_id = p.personel_id 
                                     WHERE 1=1");

                    List<SqlParameter> parametreler = new List<SqlParameter>();

                    if (cmbPersonelFiltre.SelectedIndex > 0 && cmbPersonelFiltre.SelectedValue != null)
                    {
                        sorguBuilder.Append(" AND fm.personel_id = @personel_id");
                        parametreler.Add(new SqlParameter("@personel_id", cmbPersonelFiltre.SelectedValue));
                    }

                    if (cmbOdendiFiltre.SelectedIndex > 0)
                    {
                        sorguBuilder.Append(" AND fm.odendi_mi = @odendi_mi");
                        parametreler.Add(new SqlParameter("@odendi_mi", cmbOdendiFiltre.SelectedIndex == 1 ? 1 : 0));
                    }

                    sorguBuilder.Append(" AND fm.mesai_tarihi BETWEEN @bas_tarih AND @bit_tarih");
                    parametreler.Add(new SqlParameter("@bas_tarih", dtpBaslangicTarihi.Value.Date));
                    parametreler.Add(new SqlParameter("@bit_tarih", dtpBitisTarihi.Value.Date));

                    sorguBuilder.Append(" ORDER BY fm.mesai_tarihi DESC");

                    SqlDataAdapter da = new SqlDataAdapter(sorguBuilder.ToString(), baglanti);
                    if (parametreler.Count > 0)
                    {
                        da.SelectCommand.Parameters.AddRange(parametreler.ToArray());
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewMesailer.DataSource = dt;
                    BasliklariAyarla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mesailer listelenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BasliklariAyarla()
        {
            if (dataGridViewMesailer.Columns.Count > 0)
            {
                dataGridViewMesailer.Columns["mesai_id"].HeaderText = "ID";
                dataGridViewMesailer.Columns["personel_ad_soyad"].HeaderText = "Personel";
                dataGridViewMesailer.Columns["mesai_tarihi"].HeaderText = "Mesai Tarihi";
                dataGridViewMesailer.Columns["mesai_suresi_saat"].HeaderText = "Süre (Saat)";
                dataGridViewMesailer.Columns["aciklama"].HeaderText = "Açıklama";
                dataGridViewMesailer.Columns["odendi_durumu"].HeaderText = "Ödendi mi?";

                dataGridViewMesailer.Columns["mesai_id"].Width = 50;
                dataGridViewMesailer.Columns["mesai_suresi_saat"].Width = 80;
                dataGridViewMesailer.Columns["odendi_durumu"].Width = 80;
            }
        }

        private void btnYeniMesaiEkle_Click(object sender, EventArgs e)
        {
            using (FormFazlaMesaiEkle formEkle = new FormFazlaMesaiEkle())
            {
                if (formEkle.ShowDialog() == DialogResult.OK)
                {
                    MesaileriListele();
                }
            }
        }

        private void btnOdendiIsaretle_Click(object sender, EventArgs e)
        {
            if (dataGridViewMesailer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir mesai kaydı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridViewMesailer.SelectedRows[0].Cells["odendi_durumu"].Value.ToString() == "Evet")
            {
                MessageBox.Show("Bu mesai zaten 'Ödendi' olarak işaretlenmiş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int seciliMesaiId = Convert.ToInt32(dataGridViewMesailer.SelectedRows[0].Cells["mesai_id"].Value);

            if (MessageBox.Show("Seçili mesai kaydını 'Ödendi' olarak işaretlemek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                    {
                        string sorgu = "UPDATE fazla_mesailer SET odendi_mi = 1 WHERE mesai_id = @mesai_id";
                        SqlCommand komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@mesai_id", seciliMesaiId);

                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Mesai başarıyla 'Ödendi' olarak işaretlendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MesaileriListele();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşlem sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            MesaileriListele();
        }

        private void btnFiltreyiTemizle_Click(object sender, EventArgs e)
        {
            cmbPersonelFiltre.SelectedIndex = 0;
            cmbOdendiFiltre.SelectedIndex = 0;
            dtpBaslangicTarihi.Value = DateTime.Now.AddMonths(-3);
            dtpBitisTarihi.Value = DateTime.Now.AddMonths(3);
            MesaileriListele();
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMesailer.Rows.Count == 0)
            {
                MessageBox.Show("Aktarılacak veri bulunmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "FazlaMesaiListesi.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable dt = (DataTable)dataGridViewMesailer.DataSource;
                    ExcelYardimcisi.DataTableIExcelOlarakKaydet(dt, saveFileDialog.FileName);
                    MessageBox.Show("Veriler başarıyla Excel'e aktarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri aktarımı sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}