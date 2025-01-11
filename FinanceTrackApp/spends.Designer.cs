namespace financeTrackingApplication
{
    partial class spends
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
            this.amount_label = new System.Windows.Forms.Label();
            this.category_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.remove_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.file_pathPictureBox = new System.Windows.Forms.PictureBox();
            this.id_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.file_pathPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Location = new System.Drawing.Point(63, 17);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(51, 16);
            this.amount_label.TabIndex = 0;
            this.amount_label.Text = "amount";
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Location = new System.Drawing.Point(225, 17);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(60, 16);
            this.category_label.TabIndex = 1;
            this.category_label.Text = "category";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(355, 17);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(34, 16);
            this.date_label.TabIndex = 2;
            this.date_label.Text = "date";
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.Red;
            this.remove_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove_button.FlatAppearance.BorderSize = 0;
            this.remove_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_button.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_button.ForeColor = System.Drawing.Color.White;
            this.remove_button.Location = new System.Drawing.Point(676, 8);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(83, 35);
            this.remove_button.TabIndex = 3;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = false;
            this.remove_button.Click += new System.EventHandler(this.remove_ButtonClick);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.Green;
            this.edit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_button.FlatAppearance.BorderSize = 0;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.ForeColor = System.Drawing.Color.White;
            this.edit_button.Location = new System.Drawing.Point(777, 7);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(83, 35);
            this.edit_button.TabIndex = 5;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_ButtonClick);
            // 
            // file_pathPictureBox
            // 
            this.file_pathPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.file_pathPictureBox.Image = global::financeTrackingApplication.Properties.Resources.file;
            this.file_pathPictureBox.Location = new System.Drawing.Point(560, 6);
            this.file_pathPictureBox.Name = "file_pathPictureBox";
            this.file_pathPictureBox.Size = new System.Drawing.Size(40, 40);
            this.file_pathPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.file_pathPictureBox.TabIndex = 6;
            this.file_pathPictureBox.TabStop = false;
            this.file_pathPictureBox.Click += new System.EventHandler(this.file_pathPictureBox_Click);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(3, 16);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(18, 16);
            this.id_label.TabIndex = 7;
            this.id_label.Text = "id";
            // 
            // spends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.file_pathPictureBox);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.amount_label);
            this.Name = "spends";
            this.Size = new System.Drawing.Size(875, 50);
            ((System.ComponentModel.ISupportInitialize)(this.file_pathPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.PictureBox file_pathPictureBox;
        private System.Windows.Forms.Label id_label;
    }
}
