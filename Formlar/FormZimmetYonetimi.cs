using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace PTS
{
    public partial class FormZimmetYonetimi : Form
    {
        public FormZimmetYonetimi()
        {
            InitializeComponent();
        }

        private void FormZimmetYonetimi_Load(object sender, EventArgs e)
        {
            FiltreleriDoldur();
            ZimmetleriListele();
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
        }

        private void ZimmetleriListele()
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    StringBuilder sorguBuilder = new StringBuilder();
                    sorguBuilder.Append(@"SELECT 
                                            z.zimmet_id, 
                                            p.ad + ' ' + p.soyad AS personel_ad_soyad, 
                                            z.urun_adi, 
                                            z.seri_numarasi, 
                                            z.verilis_tarihi, 
                                            z.iade_tarihi 
                                        FROM zimmet z 
                                        INNER JOIN personel p ON z.personel_id = p.personel_id
                                        WHERE 1=1");

                    List<SqlParameter> parametreler = new List<SqlParameter>();

                    if (cmbPersonelFiltre.SelectedIndex > 0 && cmbPersonelFiltre.SelectedValue != null)
                    {
                        sorguBuilder.Append(" AND z.personel_id = @personel_id");
                        parametreler.Add(new SqlParameter("@personel_id", cmbPersonelFiltre.SelectedValue));
                    }

                    if (!string.IsNullOrWhiteSpace(txtArama.Text))
                    {
                        sorguBuilder.Append(" AND (z.urun_adi LIKE @arama OR z.seri_numarasi LIKE @arama)");
                        parametreler.Add(new SqlParameter("@arama", "%" + txtArama.Text.Trim() + "%"));
                    }

                    sorguBuilder.Append(" ORDER BY z.verilis_tarihi DESC");

                    SqlDataAdapter da = new SqlDataAdapter(sorguBuilder.ToString(), baglanti);
                    if (parametreler.Count > 0)
                    {
                        da.SelectCommand.Parameters.AddRange(parametreler.ToArray());
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewZimmetler.DataSource = dt;
                    BasliklariAyarla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Zimmetler listelenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BasliklariAyarla()
        {
            if (dataGridViewZimmetler.Columns.Contains("zimmet_id"))
            {
                dataGridViewZimmetler.Columns["zimmet_id"].HeaderText = "ID";
                dataGridViewZimmetler.Columns["zimmet_id"].Width = 50;
            }
            if (dataGridViewZimmetler.Columns.Contains("personel_ad_soyad"))
            {
                dataGridViewZimmetler.Columns["personel_ad_soyad"].HeaderText = "Personel";
            }
            if (dataGridViewZimmetler.Columns.Contains("urun_adi"))
            {
                dataGridViewZimmetler.Columns["urun_adi"].HeaderText = "Ürün Adı";
            }
            if (dataGridViewZimmetler.Columns.Contains("seri_numarasi"))
            {
                dataGridViewZimmetler.Columns["seri_numarasi"].HeaderText = "Seri Numarası";
            }
            if (dataGridViewZimmetler.Columns.Contains("verilis_tarihi"))
            {
                dataGridViewZimmetler.Columns["verilis_tarihi"].HeaderText = "Veriliş Tarihi";
            }
            if (dataGridViewZimmetler.Columns.Contains("iade_tarihi"))
            {
                dataGridViewZimmetler.Columns["iade_tarihi"].HeaderText = "İade Tarihi";
            }
        }

        private void btnYeniZimmetAta_Click(object sender, EventArgs e)
        {
            using (FormZimmetAta formAta = new FormZimmetAta())
            {
                if (formAta.ShowDialog() == DialogResult.OK)
                {
                    ZimmetleriListele();
                }
            }
        }

        private void btnIadeAl_Click(object sender, EventArgs e)
        {
            if (dataGridViewZimmetler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen iade alınacak bir zimmet kaydı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridViewZimmetler.SelectedRows[0].Cells["iade_tarihi"].Value != DBNull.Value)
            {
                MessageBox.Show("Bu ürün zaten iade alınmış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int seciliZimmetId = Convert.ToInt32(dataGridViewZimmetler.SelectedRows[0].Cells["zimmet_id"].Value);

            if (MessageBox.Show("Seçili zimmeti iade olarak işaretlemek istediğinize emin misiniz?", "İade Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                    {
                        string sorgu = "UPDATE zimmet SET iade_tarihi = GETDATE() WHERE zimmet_id = @zimmet_id";
                        SqlCommand komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@zimmet_id", seciliZimmetId);

                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Ürün başarıyla iade alındı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ZimmetleriListele();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İade işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            ZimmetleriListele();
        }

        private void btnFiltreyiTemizle_Click(object sender, EventArgs e)
        {
            cmbPersonelFiltre.SelectedIndex = 0;
            txtArama.Clear();
            ZimmetleriListele();
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            if (dataGridViewZimmetler.Rows.Count == 0)
            {
                MessageBox.Show("Aktarılacak veri bulunmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "ZimmetListesi.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable dt = (DataTable)dataGridViewZimmetler.DataSource;
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