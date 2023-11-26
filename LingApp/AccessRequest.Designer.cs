namespace LingApp
{
    partial class AccessRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessRequest));
            this.approve = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.deny = new System.Windows.Forms.Button();
            this.block = new System.Windows.Forms.Button();
            this.avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // approve
            // 
            this.approve.Location = new System.Drawing.Point(12, 151);
            this.approve.Name = "approve";
            this.approve.Size = new System.Drawing.Size(94, 45);
            this.approve.TabIndex = 0;
            this.approve.Text = "Approve";
            this.approve.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(118, 34);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(187, 50);
            this.label.TabIndex = 3;
            // 
            // deny
            // 
            this.deny.Location = new System.Drawing.Point(112, 151);
            this.deny.Name = "deny";
            this.deny.Size = new System.Drawing.Size(94, 45);
            this.deny.TabIndex = 4;
            this.deny.Text = "Deny";
            this.deny.UseVisualStyleBackColor = true;
            // 
            // block
            // 
            this.block.Location = new System.Drawing.Point(212, 151);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(94, 45);
            this.block.TabIndex = 5;
            this.block.Text = "Block";
            this.block.UseVisualStyleBackColor = true;
            // 
            // avatar
            // 
            this.avatar.Location = new System.Drawing.Point(12, 12);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(100, 98);
            this.avatar.TabIndex = 6;
            this.avatar.TabStop = false;
            // 
            // AccessRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 207);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.block);
            this.Controls.Add(this.deny);
            this.Controls.Add(this.label);
            this.Controls.Add(this.approve);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccessRequest";
            this.Text = "Request for Access";
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button approve;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button deny;
        private System.Windows.Forms.Button block;
        private System.Windows.Forms.PictureBox avatar;
    }
}