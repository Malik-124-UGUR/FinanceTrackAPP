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
    public partial class all_spend : Form
    {
        // Flag for filtre state
        private bool filterControl = false;

        // Class set the static variable
        public static all_spend Instance;

        // Class consturctor
        public all_spend()
        {
            InitializeComponent();

            // Set instance
            all_spend.Instance = this;
        }

        // It runs while the page is loading.
        public void loadSpend(List<mainPage.Spends> listSpend)
        {
            if (listSpend.Count == 0) return;
            foreach (var item in listSpend)
            {
                spends spends = new spends(
                    item.id,
                    item.amount,
                    item.category.ToString(),
                    item.date,
                    item.file_path
                );
                flowLayoutPanel.Controls.Add(spends);

            }
        }

        public void updateSpending()
        {
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.Add(header_panel);
        }

        // It runs while the page is loading.
        private void all_spend_Load(object sender, EventArgs e)
        {
            fillComboBox();
        }

        // Fill comboBoxes
        private void fillComboBox()
        {
            year_comboBox.Items.Clear();
            month_comboBox.Items.Clear();
            for (int year = 2000; year <= DateTime.Now.Year; year++)
            {
                year_comboBox.Items.Add(year.ToString());
            }

            // Use the computer language
            var monthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;

            foreach (var month in monthNames)
            {
                if (!string.IsNullOrEmpty(month))
                {
                    month_comboBox.Items.Add(month);
                }
            }

            // Control the value comboBoxes and set initial values
            if (year_comboBox.Items.Count > 0)
                year_comboBox.SelectedItem = DateTime.Now.Year.ToString();
            if (month_comboBox.Items.Count > 0)
                month_comboBox.SelectedItem = DateTime.Now.ToString("MMMM", System.Globalization.CultureInfo.CurrentCulture);
            if (category_comboBox.Items.Count > 0)
                category_comboBox.SelectedIndex = 0;

            loadSpend(mainPage.all_spends);
        }

        
        // Unfilter button
        private void unfilter_button_Click(object sender, EventArgs e)
        {
            if (filterControl == true) 
            {
                // Flag down and update the flowLayoutPanle
                filterControl = false;
                updateSpending();
                loadSpend(mainPage.all_spends);
            }
            
        }

        // Filter spending button function
        private void filter_ButtonClick(object sender, EventArgs e)
        {            
            int selectedYear = int.Parse(year_comboBox.Text.Trim());

            int selectedMonth = DateTime.ParseExact(
                month_comboBox.Text.Trim(), "MMMM", 
                System.Globalization.CultureInfo.CurrentCulture).Month;

            string selectedCategory = category_comboBox.Text.Trim();

            DateTime selectedDate = new DateTime(selectedYear, selectedMonth, 1);

            var filter_spend = mainPage.all_spends.Where(u =>
                u.category.Trim().Equals(
                    selectedCategory.Trim(), 
                    StringComparison.OrdinalIgnoreCase) && // Category comparison
                u.date.Year == selectedDate.Year && // Year comparison
                u.date.Month == selectedDate.Month // Month comparison
                ).ToList();
            
            if (filter_spend.Count == 0)
            {
                updateSpending();
                filterControl = true;
                return;
            }
            
            // Flag up -- fiter is opened and update flowLayoutPanel
            filterControl = true;
            updateSpending();
            loadSpend(filter_spend);
        }
    }
}
