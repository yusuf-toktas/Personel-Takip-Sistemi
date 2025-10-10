using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PTS
{
    public partial class FormUnvanYonetimi : Form
    {
        private int? _seciliUnvanId = null;

        public FormUnvanYonetimi()
        {
            InitializeComponent();
        }

        private void FormUnvanYonetimi_Load(object sender, EventArgs e)
        {
            UnvanlariListele();
        }

        private void UnvanlariListele()
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu = "SELECT unvan_id, unvan_adi FROM unvanlar ORDER BY unvan_adi";
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewUnvanlar.DataSource = dt;

                    dataGridViewUnvanlar.Columns["unvan_id"].HeaderText = "ID";
                    dataGridViewUnvanlar.Columns["unvan_adi"].HeaderText = "Unvan Adı";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unvanlar listelenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormuTemizle()
        {
            txtUnvanAdi.Clear();
            _seciliUnvanId = null;
            dataGridViewUnvanlar.ClearSelection();
            btnEkle.Text = "Ekle";
        }

        private void dataGridViewUnvanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUnvanlar.Rows[e.RowIndex];
                _seciliUnvanId = Convert.ToInt32(row.Cells["unvan_id"].Value);
                txtUnvanAdi.Text = row.Cells["unvan_adi"].Value.ToString();
                btnEkle.Text = "Yeni";
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnvanAdi.Text))
            {
                MessageBox.Show("Unvan adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu = "INSERT INTO unvanlar (unvan_adi) VALUES (@unvan_adi)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@unvan_adi", txtUnvanAdi.Text.Trim());
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Unvan başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UnvanlariListele();
                    FormuTemizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme işlemi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!_seciliUnvanId.HasValue)
            {
                MessageBox.Show("Lütfen güncellemek için bir unvan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUnvanAdi.Text))
            {
                MessageBox.Show("Unvan adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu = "UPDATE unvanlar SET unvan_adi = @unvan_adi WHERE unvan_id = @unvan_id";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@unvan_adi", txtUnvanAdi.Text.Trim());
                    komut.Parameters.AddWithValue("@unvan_id", _seciliUnvanId.Value);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Unvan başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UnvanlariListele();
                    FormuTemizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme işlemi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!_seciliUnvanId.HasValue)
            {
                MessageBox.Show("Lütfen silmek için bir unvan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçili unvanı silmek istediğinize emin misiniz? Bu işlem geri alınamaz.", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                    {
                        baglanti.Open();
                        string kontrolSorgusu = "SELECT COUNT(*) FROM personel WHERE unvan_id = @unvan_id";
                        SqlCommand kontrolKomutu = new SqlCommand(kontrolSorgusu, baglanti);
                        kontrolKomutu.Parameters.AddWithValue("@unvan_id", _seciliUnvanId.Value);
                        int personelSayisi = (int)kontrolKomutu.ExecuteScalar();

                        if (personelSayisi > 0)
                        {
                            MessageBox.Show("Bu unvana atanmış personel bulunmaktadır. Silme işlemi yapılamaz.", "İşlem Reddedildi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                        string silmeSorgusu = "DELETE FROM unvanlar WHERE unvan_id = @unvan_id";
                        SqlCommand silmeKomutu = new SqlCommand(silmeSorgusu, baglanti);
                        silmeKomutu.Parameters.AddWithValue("@unvan_id", _seciliUnvanId.Value);
                        silmeKomutu.ExecuteNonQuery();

                        MessageBox.Show("Unvan başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UnvanlariListele();
                        FormuTemizle();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }
    }
}