namespace DowryCalculator
{
    partial class DowryWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DowryWin));
            this.backGroundPanel = new System.Windows.Forms.Panel();
            this.rdbtnNo = new System.Windows.Forms.RadioButton();
            this.rdbYes = new System.Windows.Forms.RadioButton();
            this.cmbMain = new System.Windows.Forms.ComboBox();
            this.txtDprtmnt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnSemester = new System.Windows.Forms.Button();
            this.btnShlr = new System.Windows.Forms.Button();
            this.btnCgpa = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.backGroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backGroundPanel
            // 
            this.backGroundPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backGroundPanel.BackgroundImage")));
            this.backGroundPanel.Controls.Add(this.rdbtnNo);
            this.backGroundPanel.Controls.Add(this.rdbYes);
            this.backGroundPanel.Controls.Add(this.cmbMain);
            this.backGroundPanel.Controls.Add(this.txtDprtmnt);
            this.backGroundPanel.Controls.Add(this.textBox3);
            this.backGroundPanel.Controls.Add(this.label2);
            this.backGroundPanel.Controls.Add(this.label1);
            this.backGroundPanel.Controls.Add(this.btnDepartment);
            this.backGroundPanel.Controls.Add(this.btnSemester);
            this.backGroundPanel.Controls.Add(this.btnShlr);
            this.backGroundPanel.Controls.Add(this.btnCgpa);
            this.backGroundPanel.Controls.Add(this.btnResult);
            this.backGroundPanel.Controls.Add(this.txtName);
            this.backGroundPanel.Controls.Add(this.lblName);
            this.backGroundPanel.Location = new System.Drawing.Point(468, -10);
            this.backGroundPanel.Name = "backGroundPanel";
            this.backGroundPanel.Size = new System.Drawing.Size(348, 455);
            this.backGroundPanel.TabIndex = 0;
            // 
            // rdbtnNo
            // 
            this.rdbtnNo.Location = new System.Drawing.Point(151, 255);
            this.rdbtnNo.Name = "rdbtnNo";
            this.rdbtnNo.Size = new System.Drawing.Size(106, 24);
            this.rdbtnNo.TabIndex = 24;
            this.rdbtnNo.TabStop = true;
            this.rdbtnNo.Text = "No";
            this.rdbtnNo.UseVisualStyleBackColor = true;
            this.rdbtnNo.CheckedChanged += new System.EventHandler(this.rdbtnNo_CheckedChanged);
            // 
            // rdbYes
            // 
            this.rdbYes.Location = new System.Drawing.Point(151, 225);
            this.rdbYes.Name = "rdbYes";
            this.rdbYes.Size = new System.Drawing.Size(106, 24);
            this.rdbYes.TabIndex = 23;
            this.rdbYes.TabStop = true;
            this.rdbYes.Text = "Yes";
            this.rdbYes.UseVisualStyleBackColor = true;
            this.rdbYes.CheckedChanged += new System.EventHandler(this.rdbYes_CheckedChanged);
            // 
            // cmbMain
            // 
            this.cmbMain.FormattingEnabled = true;
            this.cmbMain.Items.AddRange(new object[] {
            "Probation (<2.50)",
            "2.50 - 3.00",
            "3.00-3.50",
            "3.50-3.99",
            "Tourist(4.00)"});
            this.cmbMain.Location = new System.Drawing.Point(153, 181);
            this.cmbMain.Name = "cmbMain";
            this.cmbMain.Size = new System.Drawing.Size(121, 21);
            this.cmbMain.TabIndex = 22;
            this.cmbMain.SelectedIndexChanged += new System.EventHandler(this.cmbMain_SelectedIndexChanged);
            // 
            // txtDprtmnt
            // 
            this.txtDprtmnt.Location = new System.Drawing.Point(153, 366);
            this.txtDprtmnt.Name = "txtDprtmnt";
            this.txtDprtmnt.Size = new System.Drawing.Size(131, 20);
            this.txtDprtmnt.TabIndex = 21;
            this.txtDprtmnt.TextChanged += new System.EventHandler(this.txtDprtmnt_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(153, 303);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 20);
            this.textBox3.TabIndex = 19;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(43, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 45);
            this.label2.TabIndex = 17;
            this.label2.Text = "সিজি কত? হিসেব করুন আপনার যৌতুক ! ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // btnDepartment
            // 
            this.btnDepartment.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.Location = new System.Drawing.Point(31, 356);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(104, 36);
            this.btnDepartment.TabIndex = 15;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnSemester
            // 
            this.btnSemester.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemester.Location = new System.Drawing.Point(31, 293);
            this.btnSemester.Name = "btnSemester";
            this.btnSemester.Size = new System.Drawing.Size(104, 36);
            this.btnSemester.TabIndex = 14;
            this.btnSemester.Text = "Semester";
            this.btnSemester.UseVisualStyleBackColor = true;
            // 
            // btnShlr
            // 
            this.btnShlr.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShlr.Location = new System.Drawing.Point(31, 235);
            this.btnShlr.Name = "btnShlr";
            this.btnShlr.Size = new System.Drawing.Size(104, 36);
            this.btnShlr.TabIndex = 13;
            this.btnShlr.Text = "Sholership";
            this.btnShlr.UseVisualStyleBackColor = true;
            this.btnShlr.Click += new System.EventHandler(this.btnShlr_Click);
            // 
            // btnCgpa
            // 
            this.btnCgpa.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCgpa.Location = new System.Drawing.Point(31, 171);
            this.btnCgpa.Name = "btnCgpa";
            this.btnCgpa.Size = new System.Drawing.Size(104, 36);
            this.btnCgpa.TabIndex = 12;
            this.btnCgpa.Text = "Cgpa";
            this.btnCgpa.UseVisualStyleBackColor = true;
            this.btnCgpa.Click += new System.EventHandler(this.btnCgpa_Click);
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(121, 416);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(104, 36);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 116);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(131, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.Control;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(31, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(22, 26);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(104, 36);
            this.btnProfile.TabIndex = 7;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // DowryWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.backGroundPanel);
            this.Name = "DowryWin";
            this.Text = "Dowry Calculator";
            this.backGroundPanel.ResumeLayout(false);
            this.backGroundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backGroundPanel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnCgpa;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnSemester;
        private System.Windows.Forms.Button btnShlr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDprtmnt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cmbMain;
        private System.Windows.Forms.RadioButton rdbtnNo;
        private System.Windows.Forms.RadioButton rdbYes;
    }
}

