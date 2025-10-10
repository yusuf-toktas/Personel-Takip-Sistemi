using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PTS
{
    public partial class FormZimmetAta : Form
    {
        public FormZimmetAta()
        {
            InitializeComponent();
        }

        private void FormZimmetAta_Load(object sender, EventArgs e)
        {
            PersonelleriYukle();
        }

        private void PersonelleriYukle()
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu = "SELECT personel_id, (ad + ' ' + soyad) AS adsoyad FROM personel WHERE aktif_mi = 1 ORDER BY adsoyad";
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbPersonel.DataSource = dt;
                    cmbPersonel.DisplayMember = "adsoyad";
                    cmbPersonel.ValueMember = "personel_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personeller yüklenemedi: " + ex.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbPersonel.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtUrunAdi.Text) || string.IsNullOrWhiteSpace(txtSeriNumarasi.Text))
            {
                MessageBox.Show("Lütfen personel, ürün adı ve seri numarası alanlarını doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu = @"INSERT INTO zimmet (personel_id, urun_adi, seri_numarasi, verilis_tarihi, aciklama) 
                                     VALUES (@personel_id, @urun_adi, @seri_numarasi, @verilis_tarihi, @aciklama)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@personel_id", cmbPersonel.SelectedValue);
                    komut.Parameters.AddWithValue("@urun_adi", txtUrunAdi.Text.Trim());
                    komut.Parameters.AddWithValue("@seri_numarasi", txtSeriNumarasi.Text.Trim());
                    komut.Parameters.AddWithValue("@verilis_tarihi", dtpVerilisTarihi.Value);
                    komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text.Trim());

                    baglanti.Open();
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Zimmet kaydı başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Zimmet kaydı oluşturulurken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}