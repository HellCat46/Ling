using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace Xiaoshi
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
            Logger.WorkerReportsProgress = true;
            Logger.WorkerSupportsCancellation = true;
            httpServer.WorkerSupportsCancellation = true;
            
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
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDirPath();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("[a-zA-Z]:[\\\\\\/](?:[a-zA-Z0-9]+[\\\\\\/])*");
            // Regex Source : https://stackoverflow.com/questions/37747139/regex-for-windows-path
            // I am not shameless thief :)


            if (!regex.IsMatch(pathInput.Text.ToString())) {
                MessageBox.Show("Not a valid Path");
                return;
            }

            Logger.RunWorkerAsync();
            httpServer.RunWorkerAsync();
            pathInput.Enabled = false;
            btnstart.Enabled = false;
            btnrestart.Enabled = true;
            btnstop.Enabled = true;
            btnkill.Enabled = true;
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            httpServer.CancelAsync(); 
            Logging.Write("Stopping the server...");
        }

        // Background Processes
        private void httpServer_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            
            Webserver server = new Webserver();
            server.Initilize(pathInput.Text.ToString(), "127.0.0.1") ;

            while (true)
            {
                if(worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                server.HandleRequests();
                
            Console.WriteLine("FUCKCCKCKCC");
            }
            // Well it is better now but worker will not be stopped until all client are disconnected.
        }

        private void httpServer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("HMM");
            btnstart.Enabled = true;
            pathInput.Enabled = true;
            btnrestart.Enabled = false;
            btnstop.Enabled = false;
            btnkill.Enabled = false;
            Logger.CancelAsync();
        }

        private void Logger_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            String log = String.Empty;

            Logging.Write("Starting the server");
            while (true)
            {
                if(worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }

                worker.ReportProgress(0);
                System.Threading.Thread.Sleep(1000); // Add an option to reduce this delay
            }
        }

        private void Logger_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                logs.Text = Logging.ReadLast();
            }
            catch (IOException)
            {
                return;
            }
        }

        private void Logger_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            logs.Text = "Waiting for server to start";
        }

        // Non-Event Functions start from here
        private void SetDirPath()
        {
            FolderBrowserDialog dir_path = new FolderBrowserDialog();

            if (dir_path.ShowDialog() == DialogResult.OK)
            {
                pathInput.Text = dir_path.SelectedPath;
                return;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
