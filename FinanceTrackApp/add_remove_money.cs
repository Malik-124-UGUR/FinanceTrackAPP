using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace financeTrackingApplication
{
    public partial class add_remove_money : Form
    {
        public add_remove_money()
        {
            InitializeComponent();
        }

        // Add money and close the page
        private void addMoney_ButtonClick(object sender, EventArgs e)
        {
            mainPage.total_money += Convert.ToInt32(Math.Round(amount_numericUpDown.Value, 0));
            mainPage.Instance.changeMainPage();
            this.Close();
        }

        // Remove money and close the page
        private void removeMoney_ButtonClick(object sender, EventArgs e)
        {
            mainPage.total_money -= Convert.ToInt32(Math.Round(amount_numericUpDown.Value, 0));
            mainPage.Instance.changeMainPage();
            this.Close();
        }
    }
}
