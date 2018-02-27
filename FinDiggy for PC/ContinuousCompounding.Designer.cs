namespace FinDiggy_for_PC
{
    partial class frmContComp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContComp));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSolutFut = new System.Windows.Forms.Label();
            this.btnInfoFut = new System.Windows.Forms.Button();
            this.btnSolveFut = new System.Windows.Forms.Button();
            this.tbTimeFut = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIntRateFut = new System.Windows.Forms.Label();
            this.tbIntRatFut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrincFut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSolution = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIntRate = new System.Windows.Forms.Label();
            this.tbIntRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrincipal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 262);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblSolutFut);
            this.tabPage1.Controls.Add(this.btnInfoFut);
            this.tabPage1.Controls.Add(this.btnSolveFut);
            this.tabPage1.Controls.Add(this.tbTimeFut);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.lblIntRateFut);
            this.tabPage1.Controls.Add(this.tbIntRatFut);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbPrincFut);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(276, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Future Value";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSolutFut
            // 
            this.lblSolutFut.AutoSize = true;
            this.lblSolutFut.Location = new System.Drawing.Point(14, 187);
            this.lblSolutFut.Name = "lblSolutFut";
            this.lblSolutFut.Size = new System.Drawing.Size(157, 13);
            this.lblSolutFut.TabIndex = 18;
            this.lblSolutFut.Text = "Click button \"Solve\" for solution";
            // 
            // btnInfoFut
            // 
            this.btnInfoFut.Location = new System.Drawing.Point(135, 157);
            this.btnInfoFut.Name = "btnInfoFut";
            this.btnInfoFut.Size = new System.Drawing.Size(117, 23);
            this.btnInfoFut.TabIndex = 17;
            this.btnInfoFut.Text = "Info";
            this.btnInfoFut.UseVisualStyleBackColor = true;
            this.btnInfoFut.Click += new System.EventHandler(this.btnInfoFut_Click);
            // 
            // btnSolveFut
            // 
            this.btnSolveFut.Location = new System.Drawing.Point(14, 157);
            this.btnSolveFut.Name = "btnSolveFut";
            this.btnSolveFut.Size = new System.Drawing.Size(117, 23);
            this.btnSolveFut.TabIndex = 16;
            this.btnSolveFut.Text = "Solve";
            this.btnSolveFut.UseVisualStyleBackColor = true;
            this.btnSolveFut.Click += new System.EventHandler(this.btnSolveFut_Click);
            // 
            // tbTimeFut
            // 
            this.tbTimeFut.Location = new System.Drawing.Point(11, 112);
            this.tbTimeFut.Name = "tbTimeFut";
            this.tbTimeFut.Size = new System.Drawing.Size(100, 20);
            this.tbTimeFut.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Time (in years)";
            // 
            // lblIntRateFut
            // 
            this.lblIntRateFut.AutoSize = true;
            this.lblIntRateFut.Location = new System.Drawing.Point(117, 71);
            this.lblIntRateFut.Name = "lblIntRateFut";
            this.lblIntRateFut.Size = new System.Drawing.Size(54, 13);
            this.lblIntRateFut.TabIndex = 13;
            this.lblIntRateFut.Text = "undefined";
            // 
            // tbIntRatFut
            // 
            this.tbIntRatFut.Location = new System.Drawing.Point(11, 64);
            this.tbIntRatFut.Name = "tbIntRatFut";
            this.tbIntRatFut.Size = new System.Drawing.Size(100, 20);
            this.tbIntRatFut.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Interest Rate";
            // 
            // tbPrincFut
            // 
            this.tbPrincFut.Location = new System.Drawing.Point(11, 22);
            this.tbPrincFut.Name = "tbPrincFut";
            this.tbPrincFut.Size = new System.Drawing.Size(100, 20);
            this.tbPrincFut.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Principal";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblSolution);
            this.tabPage2.Controls.Add(this.btnInfo);
            this.tabPage2.Controls.Add(this.btnSolve);
            this.tabPage2.Controls.Add(this.tbTime);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lblIntRate);
            this.tabPage2.Controls.Add(this.tbIntRate);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbPrincipal);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Present Value";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Location = new System.Drawing.Point(14, 187);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(157, 13);
            this.lblSolution.TabIndex = 12;
            this.lblSolution.Text = "Click button \"Solve\" for solution";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(135, 157);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(117, 23);
            this.btnInfo.TabIndex = 11;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(14, 157);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(117, 23);
            this.btnSolve.TabIndex = 10;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(11, 112);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(100, 20);
            this.tbTime.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Time (in years)";
            // 
            // lblIntRate
            // 
            this.lblIntRate.AutoSize = true;
            this.lblIntRate.Location = new System.Drawing.Point(117, 71);
            this.lblIntRate.Name = "lblIntRate";
            this.lblIntRate.Size = new System.Drawing.Size(54, 13);
            this.lblIntRate.TabIndex = 4;
            this.lblIntRate.Text = "undefined";
            // 
            // tbIntRate
            // 
            this.tbIntRate.Location = new System.Drawing.Point(11, 64);
            this.tbIntRate.Name = "tbIntRate";
            this.tbIntRate.Size = new System.Drawing.Size(100, 20);
            this.tbIntRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interest Rate";
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Location = new System.Drawing.Point(11, 22);
            this.tbPrincipal.Name = "tbPrincipal";
            this.tbPrincipal.Size = new System.Drawing.Size(100, 20);
            this.tbPrincipal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value of investment at time (t)";
            // 
            // frmContComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmContComp";
            this.Text = "Continuous Compounding";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIntRate;
        private System.Windows.Forms.Label lblIntRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrincFut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIntRatFut;
        private System.Windows.Forms.Label lblIntRateFut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTimeFut;
        private System.Windows.Forms.Button btnSolveFut;
        private System.Windows.Forms.Button btnInfoFut;
        private System.Windows.Forms.Label lblSolutFut;
    }
}