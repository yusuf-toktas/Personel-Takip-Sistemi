namespace PTS
{
    partial class FormMaasGecmisi
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
            this.dataGridViewMaasGecmisi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaasGecmisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMaasGecmisi
            // 
            this.dataGridViewMaasGecmisi.AllowUserToAddRows = false;
            this.dataGridViewMaasGecmisi.AllowUserToDeleteRows = false;
            this.dataGridViewMaasGecmisi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMaasGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaasGecmisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMaasGecmisi.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMaasGecmisi.Name = "dataGridViewMaasGecmisi";
            this.dataGridViewMaasGecmisi.ReadOnly = true;
            this.dataGridViewMaasGecmisi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMaasGecmisi.Size = new System.Drawing.Size(624, 321);
            this.dataGridViewMaasGecmisi.TabIndex = 0;
            // 
            // FormMaasGecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.dataGridViewMaasGecmisi);
            this.Name = "FormMaasGecmisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Maaş Geçmişi";
            this.Load += new System.EventHandler(this.FormMaasGecmisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaasGecmisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMaasGecmisi;
    }
}