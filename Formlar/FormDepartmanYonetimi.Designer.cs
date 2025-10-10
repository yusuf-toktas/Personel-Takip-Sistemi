namespace PTS
{
    partial class FormDepartmanYonetimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewDepartmanlar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtDepartmanAdi = new System.Windows.Forms.TextBox();
            this.lblDepartmanAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmanlar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDepartmanlar
            // 
            this.dataGridViewDepartmanlar.AllowUserToAddRows = false;
            this.dataGridViewDepartmanlar.AllowUserToDeleteRows = false;
            this.dataGridViewDepartmanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDepartmanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartmanlar.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDepartmanlar.MultiSelect = false;
            this.dataGridViewDepartmanlar.Name = "dataGridViewDepartmanlar";
            this.dataGridViewDepartmanlar.ReadOnly = true;
            this.dataGridViewDepartmanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDepartmanlar.Size = new System.Drawing.Size(437, 360);
            this.dataGridViewDepartmanlar.TabIndex = 0;
            this.dataGridViewDepartmanlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartmanlar_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtDepartmanAdi);
            this.groupBox1.Controls.Add(this.lblDepartmanAdi);
            this.groupBox1.Location = new System.Drawing.Point(468, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 360);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Departman Bilgileri";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(21, 129);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(222, 23);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Formu Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(168, 100);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(87, 100);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(6, 100);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtDepartmanAdi
            // 
            this.txtDepartmanAdi.Location = new System.Drawing.Point(6, 56);
            this.txtDepartmanAdi.Name = "txtDepartmanAdi";
            this.txtDepartmanAdi.Size = new System.Drawing.Size(237, 20);
            this.txtDepartmanAdi.TabIndex = 1;
            // 
            // lblDepartmanAdi
            // 
            this.lblDepartmanAdi.AutoSize = true;
            this.lblDepartmanAdi.Location = new System.Drawing.Point(6, 40);
            this.lblDepartmanAdi.Name = "lblDepartmanAdi";
            this.lblDepartmanAdi.Size = new System.Drawing.Size(82, 13);
            this.lblDepartmanAdi.TabIndex = 0;
            this.lblDepartmanAdi.Text = "Departman Adı:";
            // 
            // FormDepartmanYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 384);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewDepartmanlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDepartmanYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Departman Yönetimi";
            this.Load += new System.EventHandler(this.FormDepartmanYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmanlar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDepartmanlar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtDepartmanAdi;
        private System.Windows.Forms.Label lblDepartmanAdi;
    }
}