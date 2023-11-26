using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LingApp
{
    public partial class Report : Form
    {
        string titletxt = "Enter the Title of Issue";
        string desctxt = "Provide as much information about the issue as you can, like ways to reproduce it, etc";
        public Report()
        {
            InitializeComponent();
            issueTitle.Text = titletxt;
            issueDesc.Text = desctxt;
        }

        private void btnsbmt_Click(object sender, EventArgs e)
        {
            if(issueDesc.Text == desctxt || issueTitle.Text == titletxt || reportermail.Text == String.Empty)
            {
                MessageBox.Show("All the fields are required.");
                return;
            }
            Regex regex = new Regex("\"\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*\"");
        }

        private void issueTitle_Enter(object sender, EventArgs e)
        {
            if(issueTitle.Text == titletxt){
                issueTitle.Text = String.Empty;
            }
        }

        private void issueDesc_Enter(object sender, EventArgs e)
        {
            if (issueDesc.Text == desctxt){
                issueDesc.Text = String.Empty;
            }
        }

        private void issueTitle_Leave(object sender, EventArgs e)
        {
            if(issueTitle.Text == String.Empty) {
                issueTitle.Text = titletxt;
            }
        }

        private void issueDesc_Leave(object sender, EventArgs e)
        {
            if (issueDesc.Text == String.Empty){
                issueDesc.Text = desctxt;
            }
        }

        private void reportermail_Leave(object sender, EventArgs e)
        {
            if (reportermail.Text == String.Empty)
            {
                return;
            }
            Regex regex = new Regex("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");
            if (!regex.IsMatch(reportermail.Text))
            {
                MessageBox.Show("Not a valid Email");
                reportermail.Focus();
                return;
            }
        }
    }
}
