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
            this.btnBackProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackProfile
            // 
            this.btnBackProfile.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackProfile.Location = new System.Drawing.Point(348, 207);
            this.btnBackProfile.Name = "btnBackProfile";
            this.btnBackProfile.Size = new System.Drawing.Size(104, 36);
            this.btnBackProfile.TabIndex = 8;
            this.btnBackProfile.Text = "<<Back";
            this.btnBackProfile.UseVisualStyleBackColor = true;
            this.btnBackProfile.Click += new System.EventHandler(this.btnBackProfile_Click);
            // 
            // profileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackProfile);
            this.Name = "profileForm";
            this.Text = "ProfileForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackProfile;
    }
}