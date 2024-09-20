namespace DowryCalculator
{
    partial class ProbationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProbationForm));
            this.PnlProbation = new System.Windows.Forms.Panel();
            this.lblSorry = new System.Windows.Forms.Label();
            this.lblPoramorso = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlProbation.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlProbation
            // 
            this.PnlProbation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlProbation.BackgroundImage")));
            this.PnlProbation.Controls.Add(this.lblSorry);
            this.PnlProbation.Controls.Add(this.lblPoramorso);
            this.PnlProbation.Location = new System.Drawing.Point(3, 0);
            this.PnlProbation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PnlProbation.Name = "PnlProbation";
            this.PnlProbation.Size = new System.Drawing.Size(402, 502);
            this.PnlProbation.TabIndex = 0;
            // 
            // lblSorry
            // 
            this.lblSorry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSorry.Location = new System.Drawing.Point(-4, 9);
            this.lblSorry.Name = "lblSorry";
            this.lblSorry.Size = new System.Drawing.Size(418, 25);
            this.lblSorry.TabIndex = 2;
            this.lblSorry.Text = "আমরা অত্যন্ত দুঃখিত, আপনি যৌতুক পাওয়ার যোগ্য নন।";
            this.lblSorry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPoramorso
            // 
            this.lblPoramorso.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblPoramorso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoramorso.Location = new System.Drawing.Point(-4, -33);
            this.lblPoramorso.Name = "lblPoramorso";
            this.lblPoramorso.Size = new System.Drawing.Size(379, 485);
            this.lblPoramorso.TabIndex = 0;
            this.lblPoramorso.Text = resources.GetString("lblPoramorso.Text");
            this.lblPoramorso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(691, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 514);
            this.panel2.TabIndex = 1;
            // 
            // ProbationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlProbation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProbationForm";
            this.Text = "Probation";
            this.PnlProbation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlProbation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPoramorso;
        private System.Windows.Forms.Label lblSorry;
    }
}