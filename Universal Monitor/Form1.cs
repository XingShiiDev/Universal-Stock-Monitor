using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Universal_Monitor
{


    public partial class Form1 : Form
    {
        string settingsLoc = $"{Environment.CurrentDirectory}/settings.ini";
        public static Thread thread;
        public static List<Thread> threads = new List<Thread>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addSiteBtn_Click(object sender, EventArgs e)
        {
            string[] row = { urlTxtBox.Text, keywordTxtBox.Text, defineKeywordDrop.Text, refreshRateNum.Value.ToString(), cookieTxtBox.Text  };

            if (!File.Exists(settingsLoc))
                File.Create(settingsLoc).Close();

            if (File.Exists(settingsLoc))
            {
                using (var destination = File.AppendText(settingsLoc))
                {
                    destination.WriteLine($"{urlTxtBox.Text}|{keywordTxtBox.Text}|{defineKeywordDrop.Text}|{refreshRateNum.Value}|{cookieTxtBox.Text}");
                }
            }

            var listViewItem = new ListViewItem(row);
            siteList.Items.Add(listViewItem);
            CleanForm();
        }

       
        private void checkBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < siteList.Items.Count; i++)
            {
                string url = siteList.Items[i].Text;
                string keyword = siteList.Items[i].SubItems[1].Text;
                string keywordState = siteList.Items[i].SubItems[2].Text;
                int refreshRate = int.Parse(siteList.Items[i].SubItems[3].Text);
                string cookies = siteList.Items[i].SubItems[4].Text;

                thread = new Thread(() =>
                {
                    monitor.monitorSites(url, keyword, keywordState, refreshRate, cookies);
                });
                thread.Start();
                threads.Add(thread);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            siteList.Items.Clear();
        }

        private void stopTskBtn_Click(object sender, EventArgs e)
        {
            foreach (var thread in threads)
                thread.Abort();

            Console.Clear();
            Console.WriteLine("All threads exited!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.Title = "Universal Stock Monitor - Console is Optional."; //dssdfasdasdasdsd
            if (File.Exists(settingsLoc))
            {
                var lSettings = File.ReadAllLines(settingsLoc);

                foreach(string setting in lSettings)
                {
                    string[] splitSettings = setting.Split('|');

                    string[] row = { splitSettings[0] , splitSettings[1], splitSettings[2], splitSettings[3], splitSettings[4] };
                    var listViewItem = new ListViewItem(row);
                    siteList.Items.Add(listViewItem);
                }
            }
        }

        private void CleanForm()
        {
            traverseControlsAndSetTextEmpty(this);
        }

        private void traverseControlsAndSetTextEmpty(Control control)
        {
            foreach (var ctrls in control.Controls)
            {
                if (ctrls is TextBox) ((TextBox)ctrls).Text = String.Empty;
                    traverseControlsAndSetTextEmpty((Control)ctrls);
            }
        }
    }
}
