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
using Newtonsoft.Json;

namespace financeTrackingApplication
{
    public partial class mainPage : Form
    {
        // Static variables and Instance 
        public static mainPage Instance;
        public static int total_money;
        public static int total_spend;
        public static int cauntList;

        // List data structure for spending data
        public static List<Spends> all_spends = new List<Spends>();

        // All other data structure for main page data
        private List<TotalData> mainPageData = new List<TotalData>();

        // Take a global directory for json files 
        private static string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
        public static string jsonFilePath = Path.Combine(appDirectory, "spends.json");
        private string jsonFilePath2 = Path.Combine(appDirectory, "mainPage.json");

        // Class constructor
        public mainPage()
        {
            InitializeComponent();
            Instance = this;

        }

        // Spends class for spending data
        public class Spends
        {
            public int id { get; set; }

            public int amount { get; set; }
            public  string category { get; set; }
            public DateTime date { get; set; }
            public List<FileData> file_path { get; set; }

            public Spends(int id, int amount, string category, DateTime date, List<FileData> file_path)
            {
                this.id = id;
                this.amount = amount;
                this.category = category;
                this.date = date;
                this.file_path = file_path;
            }
        }

        // TotalData class for main page data
        public class TotalData
        {
            public int totalMoney { get; set; }
            public int totalSpend { get; set; }
            public int cauntList { get; set; }


            public TotalData(int totalMoney, int totalSpend, int cauntList)
            {
                this.totalMoney = totalMoney;
                this.totalSpend = totalSpend;
                this.cauntList = cauntList;
            }
        }

        // FileData class for file information
        public class FileData
        {
            public string FileName { get; set; }
            public string FileType { get; set; }
            public string FileSize { get; set; }
            public string FilePath { get; set; }
        }

        // It runs while the page is loading.
        private void mainPage_Load(object sender, EventArgs e)
        {
            // Run LoadDataMainPageData function
            LoadDataMainPageData();

            // Flags for data reader
            bool cauntControl = true;
            bool controlFill = true;

            // if the file exists
            if (File.Exists(jsonFilePath))
            {
                // JSON dosyasını oku
                string existingJson = File.ReadAllText(jsonFilePath);

                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    all_spends = JsonConvert.DeserializeObject<List<Spends>>(existingJson);
                    foreach (var spends in all_spends)
                    {
                        total_spend += spends.amount;
                    }

                    // Take down the flag controlFill
                    controlFill = false;
                }
            }

            // Else...
            else
            {
                // Take down the flag countControl
                cauntControl = false;
            }

            // mainPageData list if not empty
            if (mainPageData.Count != 0)
            {
                foreach (var item in mainPageData)
                {
                    total_money += item.totalMoney;
                    if (!controlFill)
                    {
                        total_spend = item.totalSpend;
                    }
                    if (cauntControl)
                    {
                        cauntList += item.cauntList;
                    }
                }
                moneytTotal_label.Text = total_money.ToString() + " TRY";
                moneySpend_label.Text = total_spend.ToString() + " TRY";
            }

            // List if empty
            else
            {
                moneytTotal_label.Text = "0" + " TRY";
                moneySpend_label.Text = total_spend + " TRY";
            }

            // Run SaveToJson_mainPage function
            SaveToJson_mainPage();
        }

        // Save spending data to JSON format
        public void SaveToJson_spends()
        {
            // Convert data to JSON format and save to file
            string json = JsonConvert.SerializeObject(all_spends, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
            Console.WriteLine("The data was saved in JSON file.");
        }

        // Save main page data to JSON format
        public void SaveToJson_mainPage()
        {
            mainPageData.Clear();
            mainPageData.Add(new TotalData(total_money, total_spend, cauntList));

            // Convert data to JSON format
            string json = JsonConvert.SerializeObject(mainPageData, Formatting.Indented);

            // Write JSON data to file
            File.WriteAllText(jsonFilePath2, json);
            Console.WriteLine("Total veriler JSON dosyasına kaydedildi.");
        }

        private void LoadDataMainPageData()
        {
            // if the file exists
            if (File.Exists(jsonFilePath2))
            {
                // Read the JSON file
                string json = File.ReadAllText(jsonFilePath2);

                // Convert JSON format to List structure
                mainPageData = JsonConvert.DeserializeObject<List<TotalData>>(json);
            }
        }

        public void changeMainPage()
        {
            moneytTotal_label.Text = total_money.ToString() + " TRY";
            moneySpend_label.Text = total_spend.ToString() + " TRY";
            SaveToJson_mainPage();
        }

        private void spending_ButtonClick(object sender, EventArgs e)
        {
            spending sepending = new spending();
            sepending.ShowDialog();
        }

        private void modifyMoney_ButtonClick(object sender, EventArgs e)
        {
            add_remove_money add_Remove_Money = new add_remove_money();
            add_Remove_Money.ShowDialog();
        }

        private void allSpend_ButtonClick(object sender, EventArgs e)
        {
            all_spend all_Spend = new all_spend();
            all_Spend.ShowDialog();
        }
        
    }
}
