using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static financeTrackingApplication.mainPage;

namespace financeTrackingApplication
{
    public partial class file_base : UserControl
    {
        // Temporary file path variable
        private string file_path_local = null;

        // Class constructor
        public file_base(string file_name, string file_path)
        {
            InitializeComponent();
            fileName_label.Text = file_name;
            file_path_local = file_path;
        }

        // File open button function
        private void filePath_pictureBox_Click(object sender, EventArgs e)
        {
            // Try to open the file
            try
            {
                Process.Start(file_path_local);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya açılamadı: " + ex.Message);
            }
        }
    }
}
