namespace LingApp
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.issueTitle = new System.Windows.Forms.TextBox();
            this.issueDesc = new System.Windows.Forms.RichTextBox();
            this.privacy_chkbox = new System.Windows.Forms.CheckBox();
            this.btnsbmt = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.reportermail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // issueTitle
            // 
            this.issueTitle.Location = new System.Drawing.Point(12, 70);
            this.issueTitle.Name = "issueTitle";
            this.issueTitle.Size = new System.Drawing.Size(292, 20);
            this.issueTitle.TabIndex = 1;
            this.issueTitle.Enter += new System.EventHandler(this.issueTitle_Enter);
            this.issueTitle.Leave += new System.EventHandler(this.issueTitle_Leave);
            // 
            // issueDesc
            // 
            this.issueDesc.Location = new System.Drawing.Point(12, 96);
            this.issueDesc.Name = "issueDesc";
            this.issueDesc.Size = new System.Drawing.Size(292, 127);
            this.issueDesc.TabIndex = 2;
            this.issueDesc.Text = "";
            this.issueDesc.Enter += new System.EventHandler(this.issueDesc_Enter);
            this.issueDesc.Leave += new System.EventHandler(this.issueDesc_Leave);
            // 
            // privacy_chkbox
            // 
            this.privacy_chkbox.Location = new System.Drawing.Point(12, 229);
            this.privacy_chkbox.Name = "privacy_chkbox";
            this.privacy_chkbox.Size = new System.Drawing.Size(292, 24);
            this.privacy_chkbox.TabIndex = 3;
            this.privacy_chkbox.Text = "I agree to share some information about my system.";
            this.privacy_chkbox.UseVisualStyleBackColor = true;
            // 
            // btnsbmt
            // 
            this.btnsbmt.Location = new System.Drawing.Point(12, 259);
            this.btnsbmt.Name = "btnsbmt";
            this.btnsbmt.Size = new System.Drawing.Size(292, 23);
            this.btnsbmt.TabIndex = 4;
            this.btnsbmt.Text = "Report";
            this.btnsbmt.UseVisualStyleBackColor = true;
            this.btnsbmt.Click += new System.EventHandler(this.btnsbmt_Click);
            // 
            // lblname
            // 
            this.lblname.Location = new System.Drawing.Point(12, 9);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(67, 17);
            this.lblname.TabIndex = 6;
            this.lblname.Text = "Your Email:";
            // 
            // reportermail
            // 
            this.reportermail.Location = new System.Drawing.Point(12, 29);
            this.reportermail.Name = "reportermail";
            this.reportermail.Size = new System.Drawing.Size(292, 20);
            this.reportermail.TabIndex = 7;
            this.reportermail.Leave += new System.EventHandler(this.reportermail_Leave);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 289);
            this.Controls.Add(this.reportermail);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnsbmt);
            this.Controls.Add(this.privacy_chkbox);
            this.Controls.Add(this.issueDesc);
            this.Controls.Add(this.issueTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Report";
            this.Text = "Report an Issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox issueTitle;
        private System.Windows.Forms.RichTextBox issueDesc;
        private System.Windows.Forms.CheckBox privacy_chkbox;
        private System.Windows.Forms.Button btnsbmt;
        private System.Windows.Forms.Label lblname;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox reportermail;
    }
}