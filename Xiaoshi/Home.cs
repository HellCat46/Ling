using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xiaoshi
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void btnstart_Click(object sender, EventArgs e)
        {

            string[] logfile= (Encoding.ASCII.GetString(File.ReadAllBytes("./logs.txt"))).Split('\n');
            logs.Text= logfile[logfile.Length -2];
        }

        private void pathInput_Click(object sender, EventArgs e)
        {
            if(pathInput.Text.Length != 0)
            {
                return;
            }

            SetDirPath();
        }

        private void pathInput_DblClick(object sender, EventArgs e)
        {
            SetDirPath();
        }

        private void SetDirPath()
        {
            FolderBrowserDialog dir_path = new FolderBrowserDialog();

            if (dir_path.ShowDialog() == DialogResult.OK)
            {
                pathInput.Text = dir_path.SelectedPath;
                return;
            }
        }
    }
}
