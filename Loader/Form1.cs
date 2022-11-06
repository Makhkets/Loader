using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loader
{
    public partial class Form1 : Form
    {
        public static Dictionary<string, string> services = new Dictionary<string, string>()
        {
            {"Visual Studio Code", "https://c2rsetup.officeapps.live.com/c2r/downloadVS.aspx?sku=community&channel=Release&version=VS2022&source=VSLandingPage&includeRecommended=true&cid=2030"},
            {"Telegram",  "https://www.upload.ee/download/14639640/b3d94638e40e1beb7c6f/tsetup-x64.4.2.4__1_.exe"},
            {"Pycharm",  "https://download.jetbrains.com/python/pycharm-community-2022.2.3.exe"},
            {"Node JS",  "https://nodejs.org/dist/v18.12.0/node-v18.12.0-x64.msi"},
            {"Python (3.9.7)",   "https://www.python.org/ftp/python/3.9.7/python-3.9.7-amd64.exe"},
            {"VS CODE",   "https://www.upload.ee/download/14639626/f00caecab71a1bee5002/VSCodeSetup-x64-1.73.0.exe"},
            {"Git",      "https://github.com/git-for-windows/git/releases/download/v2.38.1.windows.1/Git-2.38.1-64-bit.exe"},
        };

        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public Form1()
        {
            InitializeComponent();
        }

        ArrayList GetCheckbox()
        {
            ArrayList checkboxOn = new ArrayList();
            foreach (CheckBox c in panel1.Controls.OfType<CheckBox>())
            {
                if (c.Checked)
                {
                    test.Text = c.Text;
                    checkboxOn.Add(c.Text);
                }
            }

            label1.Text = checkboxOn.ToString();
            return checkboxOn;
        }

        async void Install(string service)
        {
            string url = services[service];
            
            progressBar1.Value = 0;
            label1.Text = $"Устанавливаю: {service}";

            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += (s, e) =>
                {
                    test.Text = $"Загружено: {e.ProgressPercentage}%";
                    progressBar1.Value = e.ProgressPercentage;
                };
                wc.DownloadFileAsync(new Uri(url), $"{desktop}/@ENCODEE/{service}.exe");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(desktop + "/@ENCODEE"))
            {
                Directory.CreateDirectory(desktop + "/@ENCODEE");
            }

            label1.Text = "Начинаю установку";
            ArrayList checkboxs = GetCheckbox();
            foreach (string checkbox in checkboxs)
            {
                Install(checkbox);
            }
        }
    }
}
