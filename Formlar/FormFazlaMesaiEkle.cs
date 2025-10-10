using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PTS
{
    public partial class FormFazlaMesaiEkle : Form
    {
        public FormFazlaMesaiEkle()
        {
            InitializeComponent();
        }

        private void FormFazlaMesaiEkle_Load(object sender, EventArgs e)
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
            if (cmbPersonel.SelectedIndex == -1 || nudSure.Value <= 0)
            {
                MessageBox.Show("Lütfen personel seçin ve mesai süresini 0'dan büyük bir değer girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu = @"INSERT INTO fazla_mesailer (personel_id, mesai_tarihi, mesai_suresi_saat, aciklama, odendi_mi) 
                                     VALUES (@personel_id, @mesai_tarihi, @mesai_suresi_saat, @aciklama, 0)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@personel_id", cmbPersonel.SelectedValue);
                    komut.Parameters.AddWithValue("@mesai_tarihi", dtpMesaiTarihi.Value);
                    komut.Parameters.AddWithValue("@mesai_suresi_saat", nudSure.Value);
                    komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text.Trim());

                    baglanti.Open();
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Fazla mesai kaydı başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fazla mesai kaydı oluşturulurken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}