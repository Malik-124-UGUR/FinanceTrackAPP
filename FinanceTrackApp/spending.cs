using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static financeTrackingApplication.mainPage;

namespace financeTrackingApplication
{
    public partial class spending : Form
    {
        // Temporary sender variables
        private int amount;
        private List<mainPage.FileData> file_path = new List<mainPage.FileData>();

        // Class constructor
        public spending()
        {
            InitializeComponent();

            // Set colums of dataGridView
            dataGridView.Columns.Add("FileName", "File Name");
            dataGridView.Columns.Add("FileType", "File Type");
            dataGridView.Columns.Add("FileSize", "File Size");
            dataGridView.Columns.Add("FilePath", "File Path");

            category_comboBox.SelectedIndex = 0;

        }

        private void addSpend_ButtonClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?",
                                             "Add Confirmation",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes) 
            {
                // Convert integer
                amount = Convert.ToInt32(Math.Round(amount_numericUpDown.Value, 0));

                // Update global variables
                mainPage.total_spend += amount; 
                mainPage.cauntList++;

                int setID = mainPage.cauntList;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    // If the line is not empty...
                    if (row.Cells["FileName"].Value != null)
                    {
                        // Convert the data in the row into a FileData object and add it to the list
                        file_path.Add(new FileData
                        {
                            FileName = row.Cells["FileName"].Value.ToString(),
                            FileType = row.Cells["FileType"].Value.ToString(),
                            FileSize = row.Cells["FileSize"].Value.ToString(),
                            FilePath = row.Cells["FilePath"].Value.ToString()
                        });
                    }
                }

                // Add the new data in the global list data structure
                mainPage.all_spends.Add(new Spends(
                    setID,
                    amount,
                    category_comboBox.Text.ToString().Trim(),
                    date_dateTimePicker.Value.Date,
                    file_path
                ));

                // Run the mainPage function to update data and close the page
                mainPage.Instance.changeMainPage();
                mainPage.Instance.SaveToJson_spends();
                this.Close();
            }
        }

        // Select the file(s) on your own computer
        private void selectFile_ButtonClick(object sender, EventArgs e)
        {
            //Open OpenFileDialog file selection window
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Select multiple files
            openFileDialog.Multiselect = true;

            // if file(s) is selected...
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    // Add file information to DataGridView
                    FileInfo fileInfo = new FileInfo(file);
                    dataGridView.Rows.Add(
                        fileInfo.Name, 
                        fileInfo.Extension, 
                        fileInfo.Length, 
                        fileInfo.FullName
                    );
                }
            }
        }

        // A function to remove selected ones from the dataGridView
        private void removeFile_ButtonClick(object sender, EventArgs e)
        {
            // if something inside dataGridView is actually selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView.SelectedRows[0].Index;

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this row?", 
                    "Deletion Confirmation", 
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Delete from dataGridView
                    dataGridView.Rows.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
