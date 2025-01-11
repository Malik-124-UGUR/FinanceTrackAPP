namespace financeTrackingApplication
{
    partial class all_spend
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.header_panel = new System.Windows.Forms.Panel();
            this.fileClm_label = new System.Windows.Forms.Label();
            this.processClm_label = new System.Windows.Forms.Label();
            this.dateClm_label = new System.Windows.Forms.Label();
            this.categoryClm_label = new System.Windows.Forms.Label();
            this.amountClm_label = new System.Windows.Forms.Label();
            this.filterSet_panel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unfilter_button = new System.Windows.Forms.Button();
            this.filter_button = new System.Windows.Forms.Button();
            this.category_comboBox = new System.Windows.Forms.ComboBox();
            this.month_comboBox = new System.Windows.Forms.ComboBox();
            this.year_comboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel.SuspendLayout();
            this.header_panel.SuspendLayout();
            this.filterSet_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Controls.Add(this.header_panel);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 56);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(882, 475);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // header_panel
            // 
            this.header_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header_panel.Controls.Add(this.fileClm_label);
            this.header_panel.Controls.Add(this.processClm_label);
            this.header_panel.Controls.Add(this.dateClm_label);
            this.header_panel.Controls.Add(this.categoryClm_label);
            this.header_panel.Controls.Add(this.amountClm_label);
            this.header_panel.Location = new System.Drawing.Point(3, 3);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(875, 50);
            this.header_panel.TabIndex = 1;
            // 
            // fileClm_label
            // 
            this.fileClm_label.AutoSize = true;
            this.fileClm_label.Location = new System.Drawing.Point(560, 16);
            this.fileClm_label.Name = "fileClm_label";
            this.fileClm_label.Size = new System.Drawing.Size(36, 16);
            this.fileClm_label.TabIndex = 4;
            this.fileClm_label.Text = "Files";
            // 
            // processClm_label
            // 
            this.processClm_label.AutoSize = true;
            this.processClm_label.Location = new System.Drawing.Point(735, 16);
            this.processClm_label.Name = "processClm_label";
            this.processClm_label.Size = new System.Drawing.Size(57, 16);
            this.processClm_label.TabIndex = 3;
            this.processClm_label.Text = "Process";
            // 
            // dateClm_label
            // 
            this.dateClm_label.AutoSize = true;
            this.dateClm_label.Location = new System.Drawing.Point(395, 16);
            this.dateClm_label.Name = "dateClm_label";
            this.dateClm_label.Size = new System.Drawing.Size(36, 16);
            this.dateClm_label.TabIndex = 2;
            this.dateClm_label.Text = "Date";
            // 
            // categoryClm_label
            // 
            this.categoryClm_label.AutoSize = true;
            this.categoryClm_label.Location = new System.Drawing.Point(225, 16);
            this.categoryClm_label.Name = "categoryClm_label";
            this.categoryClm_label.Size = new System.Drawing.Size(62, 16);
            this.categoryClm_label.TabIndex = 1;
            this.categoryClm_label.Text = "Category";
            // 
            // amountClm_label
            // 
            this.amountClm_label.AutoSize = true;
            this.amountClm_label.Location = new System.Drawing.Point(36, 16);
            this.amountClm_label.Name = "amountClm_label";
            this.amountClm_label.Size = new System.Drawing.Size(111, 16);
            this.amountClm_label.TabIndex = 0;
            this.amountClm_label.Text = "Amount Of Spend";
            // 
            // filterSet_panel
            // 
            this.filterSet_panel.Controls.Add(this.label7);
            this.filterSet_panel.Controls.Add(this.label6);
            this.filterSet_panel.Controls.Add(this.label5);
            this.filterSet_panel.Controls.Add(this.unfilter_button);
            this.filterSet_panel.Controls.Add(this.filter_button);
            this.filterSet_panel.Controls.Add(this.category_comboBox);
            this.filterSet_panel.Controls.Add(this.month_comboBox);
            this.filterSet_panel.Controls.Add(this.year_comboBox);
            this.filterSet_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterSet_panel.Location = new System.Drawing.Point(0, 0);
            this.filterSet_panel.Name = "filterSet_panel";
            this.filterSet_panel.Size = new System.Drawing.Size(882, 50);
            this.filterSet_panel.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Year";
            // 
            // unfilter_button
            // 
            this.unfilter_button.BackColor = System.Drawing.Color.Navy;
            this.unfilter_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unfilter_button.FlatAppearance.BorderSize = 0;
            this.unfilter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unfilter_button.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unfilter_button.ForeColor = System.Drawing.Color.White;
            this.unfilter_button.Location = new System.Drawing.Point(761, 12);
            this.unfilter_button.Name = "unfilter_button";
            this.unfilter_button.Size = new System.Drawing.Size(83, 28);
            this.unfilter_button.TabIndex = 7;
            this.unfilter_button.Text = "Unfilter";
            this.unfilter_button.UseVisualStyleBackColor = false;
            this.unfilter_button.Click += new System.EventHandler(this.unfilter_button_Click);
            // 
            // filter_button
            // 
            this.filter_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.filter_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filter_button.FlatAppearance.BorderSize = 0;
            this.filter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_button.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_button.ForeColor = System.Drawing.Color.White;
            this.filter_button.Location = new System.Drawing.Point(653, 12);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(83, 28);
            this.filter_button.TabIndex = 6;
            this.filter_button.Text = "Filter";
            this.filter_button.UseVisualStyleBackColor = false;
            this.filter_button.Click += new System.EventHandler(this.filter_ButtonClick);
            // 
            // category_comboBox
            // 
            this.category_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_comboBox.FormattingEnabled = true;
            this.category_comboBox.Items.AddRange(new object[] {
            "Groceries",
            "Utilities",
            "Transportation",
            "Housing",
            "Entertainment",
            "Dining Out",
            "Healthcare",
            "Insurance",
            "Education",
            "Shopping"});
            this.category_comboBox.Location = new System.Drawing.Point(472, 15);
            this.category_comboBox.Name = "category_comboBox";
            this.category_comboBox.Size = new System.Drawing.Size(121, 24);
            this.category_comboBox.TabIndex = 2;
            // 
            // month_comboBox
            // 
            this.month_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.month_comboBox.FormattingEnabled = true;
            this.month_comboBox.Location = new System.Drawing.Point(243, 15);
            this.month_comboBox.Name = "month_comboBox";
            this.month_comboBox.Size = new System.Drawing.Size(101, 24);
            this.month_comboBox.TabIndex = 1;
            // 
            // year_comboBox
            // 
            this.year_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year_comboBox.FormattingEnabled = true;
            this.year_comboBox.Location = new System.Drawing.Point(63, 15);
            this.year_comboBox.Name = "year_comboBox";
            this.year_comboBox.Size = new System.Drawing.Size(85, 24);
            this.year_comboBox.TabIndex = 0;
            // 
            // all_spend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 531);
            this.Controls.Add(this.filterSet_panel);
            this.Controls.Add(this.flowLayoutPanel);
            this.MaximumSize = new System.Drawing.Size(900, 578);
            this.MinimumSize = new System.Drawing.Size(900, 578);
            this.Name = "all_spend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Spend";
            this.Load += new System.EventHandler(this.all_spend_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.filterSet_panel.ResumeLayout(false);
            this.filterSet_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Label processClm_label;
        private System.Windows.Forms.Label dateClm_label;
        private System.Windows.Forms.Label categoryClm_label;
        private System.Windows.Forms.Label amountClm_label;
        private System.Windows.Forms.Panel filterSet_panel;
        private System.Windows.Forms.ComboBox category_comboBox;
        private System.Windows.Forms.ComboBox month_comboBox;
        private System.Windows.Forms.ComboBox year_comboBox;
        private System.Windows.Forms.Button filter_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button unfilter_button;
        private System.Windows.Forms.Label fileClm_label;
    }
}