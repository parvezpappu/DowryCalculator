namespace DowryCalculator
{
    partial class resultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resultForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.lblinfoResult = new System.Windows.Forms.Label();
            this.resultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(351, 314);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 36);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "<<Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // resultPanel
            // 
            this.resultPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resultPanel.BackgroundImage")));
            this.resultPanel.Controls.Add(this.lblinfoResult);
            this.resultPanel.Location = new System.Drawing.Point(495, 1);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(351, 506);
            this.resultPanel.TabIndex = 9;
            this.resultPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.resultPanel_Paint);
            // 
            // lblinfoResult
            // 
            this.lblinfoResult.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblinfoResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblinfoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfoResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblinfoResult.Image = ((System.Drawing.Image)(resources.GetObject("lblinfoResult.Image")));
            this.lblinfoResult.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblinfoResult.Location = new System.Drawing.Point(49, 28);
            this.lblinfoResult.Name = "lblinfoResult";
            this.lblinfoResult.Size = new System.Drawing.Size(241, 45);
            this.lblinfoResult.TabIndex = 24;
            this.lblinfoResult.Text = "আপনার ফলাফল";
            this.lblinfoResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultPanel);
            this.Controls.Add(this.btnBack);
            this.Name = "resultForm";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.resultPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Label lblinfoResult;
    }
}