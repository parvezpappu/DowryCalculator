namespace DowryCalculator
{
    partial class profileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profileForm));
            this.btnBackProfile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfoProfile = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackProfile
            // 
            this.btnBackProfile.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackProfile.Location = new System.Drawing.Point(348, 329);
            this.btnBackProfile.Name = "btnBackProfile";
            this.btnBackProfile.Size = new System.Drawing.Size(104, 36);
            this.btnBackProfile.TabIndex = 8;
            this.btnBackProfile.Text = "<<Back";
            this.btnBackProfile.UseVisualStyleBackColor = true;
            this.btnBackProfile.Click += new System.EventHandler(this.btnBackProfile_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lblInfoProfile);
            this.panel1.Location = new System.Drawing.Point(458, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 510);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblInfoProfile
            // 
            this.lblInfoProfile.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblInfoProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfoProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInfoProfile.Image = ((System.Drawing.Image)(resources.GetObject("lblInfoProfile.Image")));
            this.lblInfoProfile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInfoProfile.Location = new System.Drawing.Point(59, 49);
            this.lblInfoProfile.Name = "lblInfoProfile";
            this.lblInfoProfile.Size = new System.Drawing.Size(241, 45);
            this.lblInfoProfile.TabIndex = 25;
            this.lblInfoProfile.Text = "আপনার তথ্য";
            this.lblInfoProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBackProfile);
            this.Name = "profileForm";
            this.Text = "ProfileForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInfoProfile;
    }
}