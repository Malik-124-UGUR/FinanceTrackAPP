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
    public partial class edit : Form
    {
        private int selectId = 0;
        private int amount;
        private int prev_amount;
        private List<mainPage.FileData> file_path_local = new List<mainPage.FileData>();
        public edit(
            int id,
            int amount,
            string category,
            DateTime date,
            List<mainPage.FileData> file_path
            )
        {
            InitializeComponent();

            dataGridView.Columns.Add("FileName", "File Name");
            dataGridView.Columns.Add("FileType", "File Type");
            dataGridView.Columns.Add("FileSize", "File Size");
            dataGridView.Columns.Add("FilePath", "File Path");

            selectId = id;
            amount_numericUpDown.Value = amount;
            prev_amount = amount;
            category_comboBox.SelectedItem = category;
            date_dateTimePicker.Value = date;

            foreach (var file in file_path)
            {
                dataGridView.Rows.Add(file.FileName, file.FileType,file.FileSize, file.FilePath);
            }

        }

        private void selectFile_button_Click(object sender, EventArgs e)
        {
            // OpenFileDialog dosya seçme penceresi açma
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Birden fazla dosya seç
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    // Dosya bilgilerini DataGridView'e ekle
                    FileInfo fileInfo = new FileInfo(file);
                    dataGridView.Rows.Add(fileInfo.Name, fileInfo.Extension, fileInfo.Length, fileInfo.FullName);
                }
            }
        }

        private void removeFile_button_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView.SelectedRows[0].Index;

                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Deletion Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    dataGridView.Rows.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void editSpend_button_Click(object sender, EventArgs e)
        {
           


            //MessageBox.Show(file_path.ToString() + "\n" + amount + "\n" + date_dateTimePicker.Value.ToString());

            DialogResult result = MessageBox.Show("Are you sure?",
                                             "Add Confirmation",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            

            if (result == DialogResult.Yes)
            {
                amount = Convert.ToInt32(Math.Round(amount_numericUpDown.Value, 0));
                mainPage.total_spend += (amount-prev_amount);
                mainPage.cauntList++;
                int setID = mainPage.cauntList;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    // Eğer satır boş değilse
                    if (row.Cells["FileName"].Value != null)
                    {
                        // Satırdaki verileri FileData objesine dönüştürüp listeye ekle
                        file_path_local.Add(new FileData
                        {
                            FileName = row.Cells["FileName"].Value.ToString(),
                            FileType = row.Cells["FileType"].Value.ToString(),
                            FileSize = row.Cells["FileSize"].Value.ToString(),
                            FilePath = row.Cells["FilePath"].Value.ToString()
                        });
                    }
                }

                var findAny = mainPage.all_spends.Find(u => u.id == selectId);
                if (findAny != null)
                {
                    findAny.amount = amount;
                    findAny.date = date_dateTimePicker.Value.Date;
                    findAny.category = category_comboBox.Text.ToString().Trim();
                    findAny.file_path = file_path_local;
                }
                else
                {
                    MessageBox.Show("Information is not found!",
                                            "Error Message", 
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                    return;
                }

                mainPage.Instance.changeMainPage();
                mainPage.Instance.SaveToJson_spends();
                all_spend.Instance.updateSpending();
                all_spend.Instance.loadSpend(mainPage.all_spends);
                this.Close();
            }
        }
    }
}
