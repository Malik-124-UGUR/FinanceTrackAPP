namespace financeTrackingApplication
{
    partial class edit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.category_label = new System.Windows.Forms.Label();
            this.amount_label = new System.Windows.Forms.Label();
            this.selectFile_button = new System.Windows.Forms.Button();
            this.category_comboBox = new System.Windows.Forms.ComboBox();
            this.amount_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.editSpend_button = new System.Windows.Forms.Button();
            this.removeFile_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amount_numericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.date_dateTimePicker);
            this.panel1.Controls.Add(this.category_label);
            this.panel1.Controls.Add(this.amount_label);
            this.panel1.Controls.Add(this.selectFile_button);
            this.panel1.Controls.Add(this.category_comboBox);
            this.panel1.Controls.Add(this.amount_numericUpDown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 390);
            this.panel1.TabIndex = 9;
            // 
            // date_dateTimePicker
            // 
            this.date_dateTimePicker.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold);
            this.date_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_dateTimePicker.Location = new System.Drawing.Point(31, 153);
            this.date_dateTimePicker.MaxDate = new System.DateTime(2024, 12, 30, 0, 0, 0, 0);
            this.date_dateTimePicker.Name = "date_dateTimePicker";
            this.date_dateTimePicker.Size = new System.Drawing.Size(170, 27);
            this.date_dateTimePicker.TabIndex = 3;
            this.date_dateTimePicker.Value = new System.DateTime(2024, 12, 30, 0, 0, 0, 0);
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Location = new System.Drawing.Point(31, 200);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(62, 16);
            this.category_label.TabIndex = 6;
            this.category_label.Text = "Category";
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Location = new System.Drawing.Point(31, 53);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(140, 16);
            this.amount_label.TabIndex = 1;
            this.amount_label.Text = "Amount of Expenditure";
            // 
            // selectFile_button
            // 
            this.selectFile_button.BackColor = System.Drawing.Color.DarkGray;
            this.selectFile_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectFile_button.FlatAppearance.BorderSize = 0;
            this.selectFile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFile_button.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFile_button.ForeColor = System.Drawing.Color.White;
            this.selectFile_button.Location = new System.Drawing.Point(34, 295);
            this.selectFile_button.Name = "selectFile_button";
            this.selectFile_button.Size = new System.Drawing.Size(167, 55);
            this.selectFile_button.TabIndex = 6;
            this.selectFile_button.Text = "Select File";
            this.selectFile_button.UseVisualStyleBackColor = false;
            this.selectFile_button.Click += new System.EventHandler(this.selectFile_button_Click);
            // 
            // category_comboBox
            // 
            this.category_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_comboBox.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold);
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
            this.category_comboBox.Location = new System.Drawing.Point(31, 229);
            this.category_comboBox.Name = "category_comboBox";
            this.category_comboBox.Size = new System.Drawing.Size(170, 32);
            this.category_comboBox.TabIndex = 5;
            // 
            // amount_numericUpDown
            // 
            this.amount_numericUpDown.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_numericUpDown.Location = new System.Drawing.Point(31, 82);
            this.amount_numericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.amount_numericUpDown.Name = "amount_numericUpDown";
            this.amount_numericUpDown.Size = new System.Drawing.Size(170, 31);
            this.amount_numericUpDown.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Controls.Add(this.editSpend_button);
            this.panel2.Controls.Add(this.removeFile_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(225, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 390);
            this.panel2.TabIndex = 10;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(14, 14);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(380, 250);
            this.dataGridView.TabIndex = 9;
            // 
            // editSpend_button
            // 
            this.editSpend_button.BackColor = System.Drawing.Color.Green;
            this.editSpend_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editSpend_button.FlatAppearance.BorderSize = 0;
            this.editSpend_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSpend_button.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold);
            this.editSpend_button.ForeColor = System.Drawing.Color.White;
            this.editSpend_button.Location = new System.Drawing.Point(224, 329);
            this.editSpend_button.Name = "editSpend_button";
            this.editSpend_button.Size = new System.Drawing.Size(170, 49);
            this.editSpend_button.TabIndex = 7;
            this.editSpend_button.Text = "Edit";
            this.editSpend_button.UseVisualStyleBackColor = false;
            this.editSpend_button.Click += new System.EventHandler(this.editSpend_button_Click);
            // 
            // removeFile_button
            // 
            this.removeFile_button.BackColor = System.Drawing.Color.Red;
            this.removeFile_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeFile_button.FlatAppearance.BorderSize = 0;
            this.removeFile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeFile_button.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFile_button.ForeColor = System.Drawing.Color.White;
            this.removeFile_button.Location = new System.Drawing.Point(14, 280);
            this.removeFile_button.Name = "removeFile_button";
            this.removeFile_button.Size = new System.Drawing.Size(83, 35);
            this.removeFile_button.TabIndex = 8;
            this.removeFile_button.Text = "Remove";
            this.removeFile_button.UseVisualStyleBackColor = false;
            this.removeFile_button.Click += new System.EventHandler(this.removeFile_button_Click);
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 390);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(650, 437);
            this.MinimumSize = new System.Drawing.Size(650, 437);
            this.Name = "edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spending Edit Mode";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amount_numericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker date_dateTimePicker;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.Button selectFile_button;
        private System.Windows.Forms.ComboBox category_comboBox;
        private System.Windows.Forms.NumericUpDown amount_numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button editSpend_button;
        private System.Windows.Forms.Button removeFile_button;
    }
}