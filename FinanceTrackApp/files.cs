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
    public partial class files : Form
    {
        // Class constructor
        public files(List<mainPage.FileData> filePath)
        {
            InitializeComponent();

            // Add selected files to flowLayoutPanel
            foreach (mainPage.FileData file in filePath) 
            { 
                file_base file_Base = new file_base(
                    file.FileName,
                    file.FilePath
                );
                file_flowLayoutPanel.Controls.Add(file_Base);
            }
        }
    }
}
