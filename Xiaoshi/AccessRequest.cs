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
    public partial class AccessRequest : Form
    {
        public AccessRequest(string receiver)
        {
            InitializeComponent();
            label.Text = "\""+ receiver +"\" is asking for Access of your Files.";
        }
    }
}
