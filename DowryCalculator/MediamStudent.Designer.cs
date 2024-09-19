namespace DowryCalculator
{
    partial class MediamStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediamStudent));
            this.pnlMediam = new System.Windows.Forms.Panel();
            this.lblTaka = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMediam
            // 
            this.pnlMediam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMediam.BackgroundImage")));
            this.pnlMediam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlMediam.Location = new System.Drawing.Point(507, 12);
            this.pnlMediam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMediam.Name = "pnlMediam";
            this.pnlMediam.Size = new System.Drawing.Size(280, 270);
            this.pnlMediam.TabIndex = 2;
            this.pnlMediam.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMediam_Paint);
            // 
            // lblTaka
            // 
            this.lblTaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaka.Location = new System.Drawing.Point(3, 0);
            this.lblTaka.Name = "lblTaka";
            this.lblTaka.Size = new System.Drawing.Size(132, 29);
            this.lblTaka.TabIndex = 3;
            this.lblTaka.Text = "টাকা : ৫ লাখ";
            this.lblTaka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTaka.Click += new System.EventHandler(this.lblTaka_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "বাইক :  হোন্ডা";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "একটি ফ্রিজ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblTaka);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(95, 127);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(288, 218);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // MediamStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlMediam);
            this.Name = "MediamStudent";
            this.Text = "MediamStudent";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMediam;
        private System.Windows.Forms.Label lblTaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}