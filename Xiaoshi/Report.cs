using System;
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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            issueTitle.Text = "Enter the Title of Issue";
            issueDesc.Text = "Provide as much information about the issue as you can, like ways to reproduce it, etc";
        }

        private void btnsbmt_Click(object sender, EventArgs e)
        {

        }
    }
}
