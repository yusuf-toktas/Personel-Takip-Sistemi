using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PTS
{
    public partial class FormPersonelYonetimi : Form
    {
        private bool _personelListesiYuklendi = false;

        public FormPersonelYonetimi()
        {
            InitializeComponent();
        }

        private void FormPersonelYonetimi_Load(object sender, EventArgs e)
        {
            DashboardVerileriniYukle();

            // Durum çubuğunu doldur ve saati başlat
            tssKullanici.Text = "Kullanıcı: " + GirisYapanKullanici.AdSoyad;
            timerSaat.Start();
        }

        private void DashboardVerileriniYukle()
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    baglanti.Open();
                    SqlCommand komutPersonel = new SqlCommand("SELECT COUNT(*) FROM personel WHERE aktif_mi = 1", baglanti);
                    lblToplamPersonel.Text = komutPersonel.ExecuteScalar().ToString();
                    SqlCommand komutIzin = new SqlCommand("SELECT COUNT(*) FROM izinler WHERE onay_durumu = 'beklemede'", baglanti);
                    lblBekleyenIzin.Text = komutIzin.ExecuteScalar().ToString();
                    SqlCommand komutMesai = new SqlCommand("SELECT COUNT(*) FROM fazla_mesailer WHERE odendi_mi = 0", baglanti);
                    lblOdenmemisMesai.Text = komutMesai.ExecuteScalar().ToString();
                    DateTime ayinBasi = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    DateTime ayinSonu = ayinBasi.AddMonths(1).AddDays(-1);
                    SqlCommand komutYeniPersonel = new SqlCommand("SELECT COUNT(*) FROM personel WHERE ise_giris_tarihi BETWEEN @basTarih AND @bitTarih", baglanti);
                    komutYeniPersonel.Parameters.AddWithValue("@basTarih", ayinBasi);
                    komutYeniPersonel.Parameters.AddWithValue("@bitTarih", ayinSonu);
                    lblBuAyGiren.Text = komutYeniPersonel.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard verileri yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PersonelListesiniYukle()
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    StringBuilder sorguBuilder = new StringBuilder();
                    sorguBuilder.Append(@"SELECT 
                                            p.personel_id, p.ad, p.soyad, 
                                            d.departman_adi, u.unvan_adi, 
                                            p.eposta_is, p.telefon_kisisel
                                         FROM personel p
                                         LEFT JOIN departmanlar d ON p.departman_id = d.departman_id
                                         LEFT JOIN unvanlar u ON p.unvan_id = u.unvan_id
                                         WHERE p.aktif_mi = 1");

                    List<SqlParameter> parametreler = new List<SqlParameter>();

                    if (!string.IsNullOrWhiteSpace(txtArama.Text))
                    {
                        sorguBuilder.Append(" AND (p.ad LIKE @arama OR p.soyad LIKE @arama)");
                        parametreler.Add(new SqlParameter("@arama", "%" + txtArama.Text.Trim() + "%"));
                    }

                    if (cmbDepartmanFiltre.SelectedIndex > 0 && cmbDepartmanFiltre.SelectedValue != null)
                    {
                        sorguBuilder.Append(" AND p.departman_id = @departman_id");
                        parametreler.Add(new SqlParameter("@departman_id", cmbDepartmanFiltre.SelectedValue));
                    }

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sorguBuilder.ToString(), baglanti);
                    if (parametreler.Count > 0)
                    {
                        dataAdapter.SelectCommand.Parameters.AddRange(parametreler.ToArray());
                    }

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewPersonel.DataSource = dataTable;
                    BasliklariAyarla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel listesi yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DepartmanlariFiltreyeYukle()
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu = "SELECT departman_id, departman_adi FROM departmanlar ORDER BY departman_adi";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    DataRow dr = dataTable.NewRow();
                    dr["departman_id"] = 0;
                    dr["departman_adi"] = "Tüm Departmanlar";
                    dataTable.Rows.InsertAt(dr, 0);

                    cmbDepartmanFiltre.DataSource = dataTable;
                    cmbDepartmanFiltre.DisplayMember = "departman_adi";
                    cmbDepartmanFiltre.ValueMember = "departman_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Departmanlar yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BasliklariAyarla()
        {
            if (dataGridViewPersonel.Columns.Contains("personel_id"))
            {
                dataGridViewPersonel.Columns["personel_id"].HeaderText = "ID";
                dataGridViewPersonel.Columns["personel_id"].Width = 50;
            }
            if (dataGridViewPersonel.Columns.Contains("ad"))
            {
                dataGridViewPersonel.Columns["ad"].HeaderText = "Adı";
                dataGridViewPersonel.Columns["ad"].Width = 120;
            }
            if (dataGridViewPersonel.Columns.Contains("soyad"))
            {
                dataGridViewPersonel.Columns["soyad"].HeaderText = "Soyadı";
                dataGridViewPersonel.Columns["soyad"].Width = 120;
            }
            if (dataGridViewPersonel.Columns.Contains("departman_adi"))
            {
                dataGridViewPersonel.Columns["departman_adi"].HeaderText = "Departman";
            }
            if (dataGridViewPersonel.Columns.Contains("unvan_adi"))
            {
                dataGridViewPersonel.Columns["unvan_adi"].HeaderText = "Unvan";
            }
            if (dataGridViewPersonel.Columns.Contains("eposta_is"))
            {
                dataGridViewPersonel.Columns["eposta_is"].HeaderText = "İş E-Postası";
            }
            if (dataGridViewPersonel.Columns.Contains("telefon_kisisel"))
            {
                dataGridViewPersonel.Columns["telefon_kisisel"].HeaderText = "Telefon";
            }
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            using (FormPersonelDetay formDetay = new FormPersonelDetay())
            {
                if (formDetay.ShowDialog() == DialogResult.OK)
                {
                    PersonelListesiniYukle();
                }
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlemek için bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int seciliPersonelId = Convert.ToInt32(dataGridViewPersonel.SelectedRows[0].Cells["personel_id"].Value);

            using (FormPersonelDetay formDetay = new FormPersonelDetay(seciliPersonelId))
            {
                if (formDetay.ShowDialog() == DialogResult.OK)
                {
                    PersonelListesiniYukle();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int seciliPersonelId = Convert.ToInt32(dataGridViewPersonel.SelectedRows[0].Cells["personel_id"].Value);
            string personelAdSoyad = dataGridViewPersonel.SelectedRows[0].Cells["ad"].Value.ToString() + " " + dataGridViewPersonel.SelectedRows[0].Cells["soyad"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show(personelAdSoyad + " adlı personeli silmek (pasif hale getirmek) istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                    {
                        string sorgu = "UPDATE personel SET aktif_mi = 0 WHERE personel_id = @personel_id";
                        SqlCommand komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@personel_id", seciliPersonelId);

                        baglanti.Open();
                        komut.ExecuteNonQuery();

                        MessageBox.Show("Personel başarıyla pasif hale getirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PersonelListesiniYukle();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Personel silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            txtArama.Clear();
            cmbDepartmanFiltre.SelectedIndex = 0;
            PersonelListesiniYukle();
        }

        private void departmanYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormDepartmanYonetimi formDepartman = new FormDepartmanYonetimi())
            {
                formDepartman.ShowDialog();
            }
        }

        private void unvanYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormUnvanYonetimi formUnvan = new FormUnvanYonetimi())
            {
                formUnvan.ShowDialog();
            }
        }

        private void izinYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormIzinYonetimi formIzin = new FormIzinYonetimi())
            {
                formIzin.ShowDialog();
            }
        }

        private void zimmetYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormZimmetYonetimi formZimmet = new FormZimmetYonetimi())
            {
                formZimmet.ShowDialog();
            }
        }

        private void fazlaMesaiYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormFazlaMesaiYonetimi formMesai = new FormFazlaMesaiYonetimi())
            {
                formMesai.ShowDialog();
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPagePersonelListesi)
            {
                PersonelListesiniYukle();
            }
        }

        private void cmbDepartmanFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPagePersonelListesi)
            {
                PersonelListesiniYukle();
            }
        }

        private void btnDashboardYenile_Click(object sender, EventArgs e)
        {
            DashboardVerileriniYukle();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageDashboard)
            {
                DashboardVerileriniYukle();
            }
            else if (tabControl1.SelectedTab == tabPagePersonelListesi && !_personelListesiYuklendi)
            {
                DepartmanlariFiltreyeYukle();
                PersonelListesiniYukle();
                _personelListesiYuklendi = true;
            }
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersonel.Rows.Count == 0)
            {
                MessageBox.Show("Aktarılacak veri bulunmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "PersonelListesi.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable dt = (DataTable)dataGridViewPersonel.DataSource;
                    ExcelYardimcisi.DataTableIExcelOlarakKaydet(dt, saveFileDialog.FileName);
                    MessageBox.Show("Veriler başarıyla Excel'e aktarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri aktarımı sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormHakkinda formHakkinda = new FormHakkinda())
            {
                formHakkinda.ShowDialog();
            }
        }

        private void timerSaat_Tick(object sender, EventArgs e)
        {
            tssTarih.Text = DateTime.Now.ToString("dd MMMM yyyy, dddd HH:mm:ss");
        }
    }
}