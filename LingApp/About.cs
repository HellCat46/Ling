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

namespace LingApp
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void licenseinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/Seikakuna/Ling/blob/main/LICENSE",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void reportissue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Report report = new Report();
            report.TopMost = true;
            report.ShowDialog();
        }
    }
}
