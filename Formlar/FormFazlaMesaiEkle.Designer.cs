namespace PTS
{
    partial class FormFazlaMesaiEkle
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
            this.lblMesaiTarihi = new System.Windows.Forms.Label();
            this.dtpMesaiTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblSure = new System.Windows.Forms.Label();
            this.nudSure = new System.Windows.Forms.NumericUpDown();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSure)).BeginInit();
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
            this.cmbPersonel.Location = new System.Drawing.Point(127, 28);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(246, 21);
            this.cmbPersonel.TabIndex = 1;
            // 
            // lblMesaiTarihi
            // 
            this.lblMesaiTarihi.AutoSize = true;
            this.lblMesaiTarihi.Location = new System.Drawing.Point(26, 61);
            this.lblMesaiTarihi.Name = "lblMesaiTarihi";
            this.lblMesaiTarihi.Size = new System.Drawing.Size(70, 13);
            this.lblMesaiTarihi.TabIndex = 2;
            this.lblMesaiTarihi.Text = "Mesai Tarihi :";
            // 
            // dtpMesaiTarihi
            // 
            this.dtpMesaiTarihi.Location = new System.Drawing.Point(127, 55);
            this.dtpMesaiTarihi.Name = "dtpMesaiTarihi";
            this.dtpMesaiTarihi.Size = new System.Drawing.Size(246, 20);
            this.dtpMesaiTarihi.TabIndex = 3;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(26, 88);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(95, 13);
            this.lblSure.TabIndex = 4;
            this.lblSure.Text = "Mesai Süresi (saat)";
            // 
            // nudSure
            // 
            this.nudSure.DecimalPlaces = 2;
            this.nudSure.Location = new System.Drawing.Point(127, 86);
            this.nudSure.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudSure.Name = "nudSure";
            this.nudSure.Size = new System.Drawing.Size(120, 20);
            this.nudSure.TabIndex = 5;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(26, 120);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(56, 13);
            this.lblAciklama.TabIndex = 6;
            this.lblAciklama.Text = "Açıklama :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(127, 117);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(246, 80);
            this.txtAciklama.TabIndex = 7;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(263, 203);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(110, 32);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FormFazlaMesaiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 252);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.nudSure);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.dtpMesaiTarihi);
            this.Controls.Add(this.lblMesaiTarihi);
            this.Controls.Add(this.cmbPersonel);
            this.Controls.Add(this.lblPersonel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFazlaMesaiEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Fazla Mesai Kaydı";
            this.Load += new System.EventHandler(this.FormFazlaMesaiEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.Label lblMesaiTarihi;
        private System.Windows.Forms.DateTimePicker dtpMesaiTarihi;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.NumericUpDown nudSure;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnKaydet;
    }
}