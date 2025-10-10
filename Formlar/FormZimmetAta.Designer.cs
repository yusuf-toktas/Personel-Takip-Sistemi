namespace PTS
{
    partial class FormZimmetAta
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
            this.lblPersonel = new System.Windows.Forms.Label();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtSeriNumarasi = new System.Windows.Forms.TextBox();
            this.lblSeriNo = new System.Windows.Forms.Label();
            this.lblVerilisTarihi = new System.Windows.Forms.Label();
            this.dtpVerilisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(26, 31);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(54, 13);
            this.lblPersonel.TabIndex = 0;
            this.lblPersonel.Text = "Personel :";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(120, 28);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(250, 21);
            this.cmbPersonel.TabIndex = 1;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(26, 58);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(54, 13);
            this.lblUrunAdi.TabIndex = 2;
            this.lblUrunAdi.Text = "Ürün Adı :";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(120, 55);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(250, 20);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // txtSeriNumarasi
            // 
            this.txtSeriNumarasi.Location = new System.Drawing.Point(120, 81);
            this.txtSeriNumarasi.Name = "txtSeriNumarasi";
            this.txtSeriNumarasi.Size = new System.Drawing.Size(250, 20);
            this.txtSeriNumarasi.TabIndex = 5;
            // 
            // lblSeriNo
            // 
            this.lblSeriNo.AutoSize = true;
            this.lblSeriNo.Location = new System.Drawing.Point(26, 84);
            this.lblSeriNo.Name = "lblSeriNo";
            this.lblSeriNo.Size = new System.Drawing.Size(77, 13);
            this.lblSeriNo.TabIndex = 4;
            this.lblSeriNo.Text = "Seri Numarası :";
            // 
            // lblVerilisTarihi
            // 
            this.lblVerilisTarihi.AutoSize = true;
            this.lblVerilisTarihi.Location = new System.Drawing.Point(26, 113);
            this.lblVerilisTarihi.Name = "lblVerilisTarihi";
            this.lblVerilisTarihi.Size = new System.Drawing.Size(69, 13);
            this.lblVerilisTarihi.TabIndex = 6;
            this.lblVerilisTarihi.Text = "Veriliş Tarihi :";
            // 
            // dtpVerilisTarihi
            // 
            this.dtpVerilisTarihi.Location = new System.Drawing.Point(120, 107);
            this.dtpVerilisTarihi.Name = "dtpVerilisTarihi";
            this.dtpVerilisTarihi.Size = new System.Drawing.Size(250, 20);
            this.dtpVerilisTarihi.TabIndex = 7;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(26, 136);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(56, 13);
            this.lblAciklama.TabIndex = 8;
            this.lblAciklama.Text = "Açıklama :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(120, 133);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(250, 78);
            this.txtAciklama.TabIndex = 9;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(260, 217);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(110, 32);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FormZimmetAta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 269);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.dtpVerilisTarihi);
            this.Controls.Add(this.lblVerilisTarihi);
            this.Controls.Add(this.txtSeriNumarasi);
            this.Controls.Add(this.lblSeriNo);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.cmbPersonel);
            this.Controls.Add(this.lblPersonel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormZimmetAta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personele Zimmet Ata";
            this.Load += new System.EventHandler(this.FormZimmetAta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtSeriNumarasi;
        private System.Windows.Forms.Label lblSeriNo;
        private System.Windows.Forms.Label lblVerilisTarihi;
        private System.Windows.Forms.DateTimePicker dtpVerilisTarihi;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnKaydet;
    }
}