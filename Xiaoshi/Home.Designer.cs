namespace Xiaoshi
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathInput = new System.Windows.Forms.MaskedTextBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnrestart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnkill = new System.Windows.Forms.Button();
            this.transferspeed = new System.Windows.Forms.Label();
            this.logs = new System.Windows.Forms.Label();
            this.receivers = new System.Windows.Forms.TabControl();
            this.active_receiver = new System.Windows.Forms.TabPage();
            this.flow_active_receiver = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.httpServer = new System.ComponentModel.BackgroundWorker();
            this.Logger = new System.ComponentModel.BackgroundWorker();
            this.menu.SuspendLayout();
            this.receivers.SuspendLayout();
            this.active_receiver.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menubar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // pathInput
            // 
            this.pathInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathInput.Location = new System.Drawing.Point(9, 27);
            this.pathInput.Name = "pathInput";
            this.pathInput.Size = new System.Drawing.Size(452, 20);
            this.pathInput.TabIndex = 1;
            this.pathInput.Click += new System.EventHandler(this.pathInput_Click);
            this.pathInput.DoubleClick += new System.EventHandler(this.pathInput_DblClick);
            // 
            // btnstart
            // 
            this.btnstart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnstart.Location = new System.Drawing.Point(470, 27);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 20);
            this.btnstart.TabIndex = 2;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnrestart
            // 
            this.btnrestart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestart.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnrestart.Enabled = false;
            this.btnrestart.Location = new System.Drawing.Point(551, 27);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(75, 20);
            this.btnrestart.TabIndex = 3;
            this.btnrestart.Text = "Restart";
            this.btnrestart.UseVisualStyleBackColor = true;
            // 
            // btnstop
            // 
            this.btnstop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnstop.Enabled = false;
            this.btnstop.Location = new System.Drawing.Point(632, 26);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(75, 20);
            this.btnstop.TabIndex = 4;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            // 
            // btnkill
            // 
            this.btnkill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkill.Enabled = false;
            this.btnkill.Location = new System.Drawing.Point(713, 27);
            this.btnkill.Name = "btnkill";
            this.btnkill.Size = new System.Drawing.Size(75, 20);
            this.btnkill.TabIndex = 5;
            this.btnkill.Text = "Kill";
            this.btnkill.UseVisualStyleBackColor = true;
            // 
            // transferspeed
            // 
            this.transferspeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transferspeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.transferspeed.Location = new System.Drawing.Point(737, 428);
            this.transferspeed.Name = "transferspeed";
            this.transferspeed.Size = new System.Drawing.Size(51, 18);
            this.transferspeed.TabIndex = 6;
            this.transferspeed.Text = "0 B";
            this.transferspeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logs
            // 
            this.logs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logs.Location = new System.Drawing.Point(9, 428);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(727, 18);
            this.logs.TabIndex = 7;
            this.logs.Text = "Waiting for server to start...";
            this.logs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // receivers
            // 
            this.receivers.Controls.Add(this.active_receiver);
            this.receivers.Controls.Add(this.tabPage2);
            this.receivers.Location = new System.Drawing.Point(9, 53);
            this.receivers.Name = "receivers";
            this.receivers.SelectedIndex = 0;
            this.receivers.Size = new System.Drawing.Size(779, 372);
            this.receivers.TabIndex = 11;
            // 
            // active_receiver
            // 
            this.active_receiver.Controls.Add(this.flow_active_receiver);
            this.active_receiver.Location = new System.Drawing.Point(4, 22);
            this.active_receiver.Name = "active_receiver";
            this.active_receiver.Padding = new System.Windows.Forms.Padding(3);
            this.active_receiver.Size = new System.Drawing.Size(771, 346);
            this.active_receiver.TabIndex = 0;
            this.active_receiver.Text = "Active Receiver";
            this.active_receiver.UseVisualStyleBackColor = true;
            // 
            // flow_active_receiver
            // 
            this.flow_active_receiver.Location = new System.Drawing.Point(0, 0);
            this.flow_active_receiver.Name = "flow_active_receiver";
            this.flow_active_receiver.Size = new System.Drawing.Size(771, 346);
            this.flow_active_receiver.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(771, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Previous Receiver";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 346);
            this.dataGridView1.TabIndex = 1;
            // 
            // httpServer
            // 
            this.httpServer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.httpServer_DoWork);
            // 
            // Logger
            // 
            this.Logger.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Logger_DoWork);
            this.Logger.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Logger_ProgressChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receivers);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.transferspeed);
            this.Controls.Add(this.btnkill);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.pathInput);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Home";
            this.Text = "Xiaoshi";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.receivers.ResumeLayout(false);
            this.active_receiver.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox pathInput;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnkill;
        private System.Windows.Forms.Label transferspeed;
        private System.Windows.Forms.Label logs;
        private System.Windows.Forms.TabControl receivers;
        private System.Windows.Forms.TabPage active_receiver;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flow_active_receiver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker httpServer;
        private System.ComponentModel.BackgroundWorker Logger;
    }
}

