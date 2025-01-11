namespace financeTrackingApplication
{
    partial class add_remove_money
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
            this.amount_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addMoney_button = new System.Windows.Forms.Button();
            this.removeMoney_button = new System.Windows.Forms.Button();
            this.mainTitle_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amount_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // amount_numericUpDown
            // 
            this.amount_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amount_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.amount_numericUpDown.Location = new System.Drawing.Point(59, 103);
            this.amount_numericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.amount_numericUpDown.Name = "amount_numericUpDown";
            this.amount_numericUpDown.Size = new System.Drawing.Size(187, 26);
            this.amount_numericUpDown.TabIndex = 0;
            // 
            // addMoney_button
            // 
            this.addMoney_button.BackColor = System.Drawing.Color.Green;
            this.addMoney_button.FlatAppearance.BorderSize = 0;
            this.addMoney_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMoney_button.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMoney_button.ForeColor = System.Drawing.Color.White;
            this.addMoney_button.Location = new System.Drawing.Point(59, 159);
            this.addMoney_button.Name = "addMoney_button";
            this.addMoney_button.Size = new System.Drawing.Size(187, 43);
            this.addMoney_button.TabIndex = 1;
            this.addMoney_button.Text = "Add ";
            this.addMoney_button.UseVisualStyleBackColor = false;
            this.addMoney_button.Click += new System.EventHandler(this.addMoney_ButtonClick);
            // 
            // removeMoney_button
            // 
            this.removeMoney_button.BackColor = System.Drawing.Color.Red;
            this.removeMoney_button.FlatAppearance.BorderSize = 0;
            this.removeMoney_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeMoney_button.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeMoney_button.ForeColor = System.Drawing.Color.White;
            this.removeMoney_button.Location = new System.Drawing.Point(59, 222);
            this.removeMoney_button.Name = "removeMoney_button";
            this.removeMoney_button.Size = new System.Drawing.Size(187, 43);
            this.removeMoney_button.TabIndex = 2;
            this.removeMoney_button.Text = "Remove";
            this.removeMoney_button.UseVisualStyleBackColor = false;
            this.removeMoney_button.Click += new System.EventHandler(this.removeMoney_ButtonClick);
            // 
            // mainTitle_label
            // 
            this.mainTitle_label.AutoSize = true;
            this.mainTitle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mainTitle_label.Location = new System.Drawing.Point(69, 54);
            this.mainTitle_label.Name = "mainTitle_label";
            this.mainTitle_label.Size = new System.Drawing.Size(171, 25);
            this.mainTitle_label.TabIndex = 3;
            this.mainTitle_label.Text = "Amount Of Money";
            // 
            // add_remove_money
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 315);
            this.Controls.Add(this.mainTitle_label);
            this.Controls.Add(this.removeMoney_button);
            this.Controls.Add(this.addMoney_button);
            this.Controls.Add(this.amount_numericUpDown);
            this.MaximumSize = new System.Drawing.Size(318, 362);
            this.MinimumSize = new System.Drawing.Size(318, 362);
            this.Name = "add_remove_money";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Remove Money";
            ((System.ComponentModel.ISupportInitialize)(this.amount_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown amount_numericUpDown;
        private System.Windows.Forms.Button addMoney_button;
        private System.Windows.Forms.Button removeMoney_button;
        private System.Windows.Forms.Label mainTitle_label;
    }
}