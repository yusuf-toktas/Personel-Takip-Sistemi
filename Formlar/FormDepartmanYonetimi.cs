using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PTS
{
    public partial class FormDepartmanYonetimi : Form
    {
        private int? _seciliDepartmanId = null;

        public FormDepartmanYonetimi()
        {
            InitializeComponent();
        }

        private void FormDepartmanYonetimi_Load(object sender, EventArgs e)
        {
            DepartmanlariListele();
        }

        private void DepartmanlariListele()
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu = "SELECT departman_id, departman_adi FROM departmanlar ORDER BY departman_adi";
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewDepartmanlar.DataSource = dt;

                    dataGridViewDepartmanlar.Columns["departman_id"].HeaderText = "ID";
                    dataGridViewDepartmanlar.Columns["departman_adi"].HeaderText = "Departman Adı";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Departmanlar listelenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormuTemizle()
        {
            txtDepartmanAdi.Clear();
            _seciliDepartmanId = null;
            dataGridViewDepartmanlar.ClearSelection();
            btnEkle.Text = "Ekle";
        }

        private void dataGridViewDepartmanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDepartmanlar.Rows[e.RowIndex];
                _seciliDepartmanId = Convert.ToInt32(row.Cells["departman_id"].Value);
                txtDepartmanAdi.Text = row.Cells["departman_adi"].Value.ToString();
                btnEkle.Text = "Yeni";
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDepartmanAdi.Text))
            {
                MessageBox.Show("Departman adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu = "INSERT INTO departmanlar (departman_adi) VALUES (@departman_adi)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@departman_adi", txtDepartmanAdi.Text.Trim());
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Departman başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DepartmanlariListele();
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
            if (!_seciliDepartmanId.HasValue)
            {
                MessageBox.Show("Lütfen güncellemek için bir departman seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDepartmanAdi.Text))
            {
                MessageBox.Show("Departman adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu = "UPDATE departmanlar SET departman_adi = @departman_adi WHERE departman_id = @departman_id";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@departman_adi", txtDepartmanAdi.Text.Trim());
                    komut.Parameters.AddWithValue("@departman_id", _seciliDepartmanId.Value);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Departman başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DepartmanlariListele();
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
            if (!_seciliDepartmanId.HasValue)
            {
                MessageBox.Show("Lütfen silmek için bir departman seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçili departmanı silmek istediğinize emin misiniz? Bu işlem geri alınamaz.", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                    {
                        baglanti.Open();
                        string kontrolSorgusu = "SELECT COUNT(*) FROM personel WHERE departman_id = @departman_id";
                        SqlCommand kontrolKomutu = new SqlCommand(kontrolSorgusu, baglanti);
                        kontrolKomutu.Parameters.AddWithValue("@departman_id", _seciliDepartmanId.Value);
                        int personelSayisi = (int)kontrolKomutu.ExecuteScalar();

                        if (personelSayisi > 0)
                        {
                            MessageBox.Show("Bu departmana atanmış personel bulunmaktadır. Silme işlemi yapılamaz.", "İşlem Reddedildi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                        string silmeSorgusu = "DELETE FROM departmanlar WHERE departman_id = @departman_id";
                        SqlCommand silmeKomutu = new SqlCommand(silmeSorgusu, baglanti);
                        silmeKomutu.Parameters.AddWithValue("@departman_id", _seciliDepartmanId.Value);
                        silmeKomutu.ExecuteNonQuery();

                        MessageBox.Show("Departman başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DepartmanlariListele();
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