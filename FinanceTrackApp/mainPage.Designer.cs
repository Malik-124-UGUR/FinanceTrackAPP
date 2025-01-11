namespace financeTrackingApplication
{
    partial class mainPage
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.maintTitle_label = new System.Windows.Forms.Label();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.lblTotalSpend = new System.Windows.Forms.Label();
            this.moneytTotal_label = new System.Windows.Forms.Label();
            this.moneySpend_label = new System.Windows.Forms.Label();
            this.modifyMoney_button = new System.Windows.Forms.Button();
            this.spending_button = new System.Windows.Forms.Button();
            this.allSpend_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maintTitle_label
            // 
            this.maintTitle_label.AutoSize = true;
            this.maintTitle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maintTitle_label.Location = new System.Drawing.Point(79, 24);
            this.maintTitle_label.Name = "maintTitle_label";
            this.maintTitle_label.Size = new System.Drawing.Size(216, 25);
            this.maintTitle_label.TabIndex = 0;
            this.maintTitle_label.Text = "Finance Track Program";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Location = new System.Drawing.Point(44, 77);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(103, 16);
            this.lblTotalMoney.TabIndex = 1;
            this.lblTotalMoney.Text = "TOTAL MONEY";
            // 
            // lblTotalSpend
            // 
            this.lblTotalSpend.AutoSize = true;
            this.lblTotalSpend.Location = new System.Drawing.Point(215, 77);
            this.lblTotalSpend.Name = "lblTotalSpend";
            this.lblTotalSpend.Size = new System.Drawing.Size(101, 16);
            this.lblTotalSpend.TabIndex = 2;
            this.lblTotalSpend.Text = "TOTAL SPEND";
            // 
            // moneytTotal_label
            // 
            this.moneytTotal_label.AutoSize = true;
            this.moneytTotal_label.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.moneytTotal_label.Location = new System.Drawing.Point(33, 111);
            this.moneytTotal_label.MinimumSize = new System.Drawing.Size(128, 31);
            this.moneytTotal_label.Name = "moneytTotal_label";
            this.moneytTotal_label.Size = new System.Drawing.Size(128, 31);
            this.moneytTotal_label.TabIndex = 3;
            this.moneytTotal_label.Text = "50.000 TRY";
            // 
            // moneySpend_label
            // 
            this.moneySpend_label.AutoSize = true;
            this.moneySpend_label.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.moneySpend_label.Location = new System.Drawing.Point(201, 111);
            this.moneySpend_label.MinimumSize = new System.Drawing.Size(128, 31);
            this.moneySpend_label.Name = "moneySpend_label";
            this.moneySpend_label.Size = new System.Drawing.Size(128, 31);
            this.moneySpend_label.TabIndex = 5;
            this.moneySpend_label.Text = "50.000 TRY";
            // 
            // modifyMoney_button
            // 
            this.modifyMoney_button.BackColor = System.Drawing.Color.Green;
            this.modifyMoney_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyMoney_button.FlatAppearance.BorderSize = 0;
            this.modifyMoney_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyMoney_button.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modifyMoney_button.ForeColor = System.Drawing.Color.White;
            this.modifyMoney_button.Location = new System.Drawing.Point(39, 194);
            this.modifyMoney_button.Name = "modifyMoney_button";
            this.modifyMoney_button.Size = new System.Drawing.Size(122, 50);
            this.modifyMoney_button.TabIndex = 6;
            this.modifyMoney_button.Text = "Modify Money";
            this.modifyMoney_button.UseVisualStyleBackColor = false;
            this.modifyMoney_button.Click += new System.EventHandler(this.modifyMoney_ButtonClick);
            // 
            // spending_button
            // 
            this.spending_button.BackColor = System.Drawing.Color.Red;
            this.spending_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spending_button.FlatAppearance.BorderSize = 0;
            this.spending_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spending_button.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold);
            this.spending_button.ForeColor = System.Drawing.Color.White;
            this.spending_button.Location = new System.Drawing.Point(207, 194);
            this.spending_button.Name = "spending_button";
            this.spending_button.Size = new System.Drawing.Size(122, 50);
            this.spending_button.TabIndex = 7;
            this.spending_button.Text = "Spending";
            this.spending_button.UseVisualStyleBackColor = false;
            this.spending_button.Click += new System.EventHandler(this.spending_ButtonClick);
            // 
            // allSpend_button
            // 
            this.allSpend_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.allSpend_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allSpend_button.FlatAppearance.BorderSize = 0;
            this.allSpend_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allSpend_button.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold);
            this.allSpend_button.ForeColor = System.Drawing.Color.White;
            this.allSpend_button.Location = new System.Drawing.Point(39, 264);
            this.allSpend_button.Name = "allSpend_button";
            this.allSpend_button.Size = new System.Drawing.Size(290, 60);
            this.allSpend_button.TabIndex = 8;
            this.allSpend_button.Text = "All Spend";
            this.allSpend_button.UseVisualStyleBackColor = false;
            this.allSpend_button.Click += new System.EventHandler(this.allSpend_ButtonClick);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 359);
            this.Controls.Add(this.allSpend_button);
            this.Controls.Add(this.spending_button);
            this.Controls.Add(this.modifyMoney_button);
            this.Controls.Add(this.moneySpend_label);
            this.Controls.Add(this.moneytTotal_label);
            this.Controls.Add(this.lblTotalSpend);
            this.Controls.Add(this.lblTotalMoney);
            this.Controls.Add(this.maintTitle_label);
            this.MaximumSize = new System.Drawing.Size(385, 406);
            this.MinimumSize = new System.Drawing.Size(385, 406);
            this.Name = "mainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finance Track Application";
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label maintTitle_label;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Label lblTotalSpend;
        private System.Windows.Forms.Label moneySpend_label;
        private System.Windows.Forms.Button modifyMoney_button;
        private System.Windows.Forms.Button spending_button;
        private System.Windows.Forms.Button allSpend_button;
        public System.Windows.Forms.Label moneytTotal_label;
    }
}

