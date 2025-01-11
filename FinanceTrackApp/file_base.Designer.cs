namespace financeTrackingApplication
{
    partial class file_base
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileName_label = new System.Windows.Forms.Label();
            this.filePath_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.filePath_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fileName_label
            // 
            this.fileName_label.AutoSize = true;
            this.fileName_label.Location = new System.Drawing.Point(53, 118);
            this.fileName_label.MaximumSize = new System.Drawing.Size(44, 16);
            this.fileName_label.Name = "fileName_label";
            this.fileName_label.Size = new System.Drawing.Size(42, 16);
            this.fileName_label.TabIndex = 1;
            this.fileName_label.Text = "fileName";
            // 
            // filePath_pictureBox
            // 
            this.filePath_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filePath_pictureBox.Image = global::financeTrackingApplication.Properties.Resources.file;
            this.filePath_pictureBox.Location = new System.Drawing.Point(25, 10);
            this.filePath_pictureBox.Name = "filePath_pictureBox";
            this.filePath_pictureBox.Size = new System.Drawing.Size(100, 119);
            this.filePath_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filePath_pictureBox.TabIndex = 0;
            this.filePath_pictureBox.TabStop = false;
            this.filePath_pictureBox.Click += new System.EventHandler(this.filePath_pictureBox_Click);
            // 
            // file_base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fileName_label);
            this.Controls.Add(this.filePath_pictureBox);
            this.Name = "file_base";
            ((System.ComponentModel.ISupportInitialize)(this.filePath_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox filePath_pictureBox;
        private System.Windows.Forms.Label fileName_label;
    }
}
