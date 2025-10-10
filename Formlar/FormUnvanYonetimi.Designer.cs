namespace PTS
{
    partial class FormUnvanYonetimi
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
            this.dataGridViewUnvanlar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtUnvanAdi = new System.Windows.Forms.TextBox();
            this.lblUnvanAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnvanlar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUnvanlar
            // 
            this.dataGridViewUnvanlar.AllowUserToAddRows = false;
            this.dataGridViewUnvanlar.AllowUserToDeleteRows = false;
            this.dataGridViewUnvanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUnvanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnvanlar.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewUnvanlar.MultiSelect = false;
            this.dataGridViewUnvanlar.Name = "dataGridViewUnvanlar";
            this.dataGridViewUnvanlar.ReadOnly = true;
            this.dataGridViewUnvanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUnvanlar.Size = new System.Drawing.Size(437, 360);
            this.dataGridViewUnvanlar.TabIndex = 0;
            this.dataGridViewUnvanlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUnvanlar_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtUnvanAdi);
            this.groupBox1.Controls.Add(this.lblUnvanAdi);
            this.groupBox1.Location = new System.Drawing.Point(468, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 360);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unvan Bilgileri";
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
            // txtUnvanAdi
            // 
            this.txtUnvanAdi.Location = new System.Drawing.Point(6, 56);
            this.txtUnvanAdi.Name = "txtUnvanAdi";
            this.txtUnvanAdi.Size = new System.Drawing.Size(237, 20);
            this.txtUnvanAdi.TabIndex = 1;
            // 
            // lblUnvanAdi
            // 
            this.lblUnvanAdi.AutoSize = true;
            this.lblUnvanAdi.Location = new System.Drawing.Point(6, 40);
            this.lblUnvanAdi.Name = "lblUnvanAdi";
            this.lblUnvanAdi.Size = new System.Drawing.Size(61, 13);
            this.lblUnvanAdi.TabIndex = 0;
            this.lblUnvanAdi.Text = "Unvan Adı:";
            // 
            // FormUnvanYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 384);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewUnvanlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUnvanYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unvan Yönetimi";
            this.Load += new System.EventHandler(this.FormUnvanYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnvanlar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUnvanlar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtUnvanAdi;
        private System.Windows.Forms.Label lblUnvanAdi;
    }
}