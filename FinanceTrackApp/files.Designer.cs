namespace financeTrackingApplication
{
    partial class files
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
            this.file_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // file_flowLayoutPanel
            // 
            this.file_flowLayoutPanel.AutoScroll = true;
            this.file_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.file_flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.file_flowLayoutPanel.Name = "file_flowLayoutPanel";
            this.file_flowLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.file_flowLayoutPanel.TabIndex = 0;
            // 
            // files
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.file_flowLayoutPanel);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "files";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Files";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel file_flowLayoutPanel;
    }
}