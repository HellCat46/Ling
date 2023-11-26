namespace LingApp
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.licenseinfo = new System.Windows.Forms.LinkLabel();
            this.reportissue = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainlbl
            // 
            this.mainlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlbl.Location = new System.Drawing.Point(191, 24);
            this.mainlbl.Name = "mainlbl";
            this.mainlbl.Size = new System.Drawing.Size(131, 63);
            this.mainlbl.TabIndex = 1;
            this.mainlbl.Text = "Ling";
            this.mainlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Version 0.69 · MIT License";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(148, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ling\'s Window Application to make sharing files  easier than it has ever been.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // licenseinfo
            // 
            this.licenseinfo.AutoSize = true;
            this.licenseinfo.Location = new System.Drawing.Point(23, 183);
            this.licenseinfo.Name = "licenseinfo";
            this.licenseinfo.Size = new System.Drawing.Size(107, 13);
            this.licenseinfo.TabIndex = 5;
            this.licenseinfo.TabStop = true;
            this.licenseinfo.Text = "Licensing Information";
            this.licenseinfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.licenseinfo_LinkClicked);
            // 
            // reportissue
            // 
            this.reportissue.AutoSize = true;
            this.reportissue.Location = new System.Drawing.Point(315, 183);
            this.reportissue.Name = "reportissue";
            this.reportissue.Size = new System.Drawing.Size(83, 13);
            this.reportissue.TabIndex = 6;
            this.reportissue.TabStop = true;
            this.reportissue.Text = "Report An Issue";
            this.reportissue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reportissue_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(428, 205);
            this.Controls.Add(this.reportissue);
            this.Controls.Add(this.licenseinfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainlbl);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "About Ling";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label mainlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel licenseinfo;
        private System.Windows.Forms.LinkLabel reportissue;
    }
}