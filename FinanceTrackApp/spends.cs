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
    public partial class spends : UserControl
    {
        // Temporaray variables and temporary data structure
        private int id_local = 0;
        private int amount_local = 0;
        private string category_local = null;
        private DateTime date_local;
        private List<mainPage.FileData> file_path_local = new List<mainPage.FileData>();

        // Class contructor
        public spends(int id, int amount, string category, DateTime date, List<mainPage.FileData> file_path)
        {
            InitializeComponent();
            id_label.Text = id.ToString();
            amount_label.Text = amount.ToString();
            category_label.Text = category;
            date_label.Text = date.ToString("dddd, MMMM dd, yyyy");

            file_path_local.Clear();
            file_path_local = file_path;

            id_local = id;
            amount_local = amount;
            category_local = category;
            date_local = date;
        }

        // Delete spend button
        private void remove_ButtonClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure delete this spend?",
                                             "Delete Confirmation",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // We get the FlowLayoutPanel containing the UserControl
                FlowLayoutPanel parentPanel = this.Parent as FlowLayoutPanel;
                var removeFilter = mainPage.all_spends.Where(u =>
                    u.id.ToString() == id_label.Text.Trim()).ToList();

                foreach (var filter in removeFilter)
                {
                    mainPage.all_spends.Remove(filter);
                    mainPage.total_spend -= filter.amount;

                }

                if (parentPanel != null)
                {
                    //Remove UserControl from panel
                    parentPanel.Controls.Remove(this);

                    // Clear UserControl from memory
                    this.Dispose();
                }

                // Update the data
                mainPage.Instance.SaveToJson_spends();
                mainPage.Instance.SaveToJson_mainPage();
                mainPage.Instance.changeMainPage();

            }
        }

        // Edit spending
        private void edit_ButtonClick(object sender, EventArgs e)
        {
            edit edit = new edit(
                id_local,
                amount_local,
                category_local,
                date_local,
                file_path_local);
            edit.ShowDialog();
        }

        // Show the selected file
        private void file_pathPictureBox_Click(object sender, EventArgs e)
        {
            files files = new files(file_path_local);
            files.ShowDialog();
        }
    }
}
