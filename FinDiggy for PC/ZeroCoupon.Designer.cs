namespace FinDiggy_for_PC
{
    partial class frmZeroCoup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZeroCoup));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSolutInt = new System.Windows.Forms.Label();
            this.btnInfoInt = new System.Windows.Forms.Button();
            this.btnSolveInt = new System.Windows.Forms.Button();
            this.tbPresValInt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFacValInt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblIntRatePre = new System.Windows.Forms.Label();
            this.lblSolutPre = new System.Windows.Forms.Label();
            this.btnInfoPre = new System.Windows.Forms.Button();
            this.btnSolvePre = new System.Windows.Forms.Button();
            this.tbIntRatePre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFacValPre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblSolutFac = new System.Windows.Forms.Label();
            this.btnInfoFac = new System.Windows.Forms.Button();
            this.btnSolveFac = new System.Windows.Forms.Button();
            this.lblIntRateFac = new System.Windows.Forms.Label();
            this.tbIntRateFac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPreValFac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(299, 198);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblSolutInt);
            this.tabPage1.Controls.Add(this.btnInfoInt);
            this.tabPage1.Controls.Add(this.btnSolveInt);
            this.tabPage1.Controls.Add(this.tbPresValInt);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbFacValInt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(291, 172);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Find Interest Rate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSolutInt
            // 
            this.lblSolutInt.AutoSize = true;
            this.lblSolutInt.Location = new System.Drawing.Point(14, 134);
            this.lblSolutInt.Name = "lblSolutInt";
            this.lblSolutInt.Size = new System.Drawing.Size(157, 13);
            this.lblSolutInt.TabIndex = 15;
            this.lblSolutInt.Text = "Click button \"Solve\" for solution";
            // 
            // btnInfoInt
            // 
            this.btnInfoInt.Location = new System.Drawing.Point(135, 104);
            this.btnInfoInt.Name = "btnInfoInt";
            this.btnInfoInt.Size = new System.Drawing.Size(117, 23);
            this.btnInfoInt.TabIndex = 14;
            this.btnInfoInt.Text = "Info";
            this.btnInfoInt.UseVisualStyleBackColor = true;
            this.btnInfoInt.Click += new System.EventHandler(this.btnInfoInt_Click);
            // 
            // btnSolveInt
            // 
            this.btnSolveInt.Location = new System.Drawing.Point(14, 104);
            this.btnSolveInt.Name = "btnSolveInt";
            this.btnSolveInt.Size = new System.Drawing.Size(117, 23);
            this.btnSolveInt.TabIndex = 13;
            this.btnSolveInt.Text = "Solve";
            this.btnSolveInt.UseVisualStyleBackColor = true;
            this.btnSolveInt.Click += new System.EventHandler(this.btnSolveInt_Click);
            // 
            // tbPresValInt
            // 
            this.tbPresValInt.Location = new System.Drawing.Point(11, 64);
            this.tbPresValInt.Name = "tbPresValInt";
            this.tbPresValInt.Size = new System.Drawing.Size(100, 20);
            this.tbPresValInt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Present Value";
            // 
            // tbFacValInt
            // 
            this.tbFacValInt.Location = new System.Drawing.Point(11, 22);
            this.tbFacValInt.Name = "tbFacValInt";
            this.tbFacValInt.Size = new System.Drawing.Size(100, 20);
            this.tbFacValInt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Face Value";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblIntRatePre);
            this.tabPage2.Controls.Add(this.lblSolutPre);
            this.tabPage2.Controls.Add(this.btnInfoPre);
            this.tabPage2.Controls.Add(this.btnSolvePre);
            this.tabPage2.Controls.Add(this.tbIntRatePre);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbFacValPre);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(291, 172);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Find Present Value";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblIntRatePre
            // 
            this.lblIntRatePre.AutoSize = true;
            this.lblIntRatePre.Location = new System.Drawing.Point(117, 71);
            this.lblIntRatePre.Name = "lblIntRatePre";
            this.lblIntRatePre.Size = new System.Drawing.Size(54, 13);
            this.lblIntRatePre.TabIndex = 17;
            this.lblIntRatePre.Text = "undefined";
            // 
            // lblSolutPre
            // 
            this.lblSolutPre.AutoSize = true;
            this.lblSolutPre.Location = new System.Drawing.Point(14, 134);
            this.lblSolutPre.Name = "lblSolutPre";
            this.lblSolutPre.Size = new System.Drawing.Size(157, 13);
            this.lblSolutPre.TabIndex = 16;
            this.lblSolutPre.Text = "Click button \"Solve\" for solution";
            // 
            // btnInfoPre
            // 
            this.btnInfoPre.Location = new System.Drawing.Point(135, 104);
            this.btnInfoPre.Name = "btnInfoPre";
            this.btnInfoPre.Size = new System.Drawing.Size(117, 23);
            this.btnInfoPre.TabIndex = 15;
            this.btnInfoPre.Text = "Info";
            this.btnInfoPre.UseVisualStyleBackColor = true;
            this.btnInfoPre.Click += new System.EventHandler(this.btnInfoPre_Click);
            // 
            // btnSolvePre
            // 
            this.btnSolvePre.Location = new System.Drawing.Point(14, 104);
            this.btnSolvePre.Name = "btnSolvePre";
            this.btnSolvePre.Size = new System.Drawing.Size(117, 23);
            this.btnSolvePre.TabIndex = 14;
            this.btnSolvePre.Text = "Solve";
            this.btnSolvePre.UseVisualStyleBackColor = true;
            this.btnSolvePre.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbIntRatePre
            // 
            this.tbIntRatePre.Location = new System.Drawing.Point(11, 64);
            this.tbIntRatePre.Name = "tbIntRatePre";
            this.tbIntRatePre.Size = new System.Drawing.Size(100, 20);
            this.tbIntRatePre.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Interest Rate";
            // 
            // tbFacValPre
            // 
            this.tbFacValPre.Location = new System.Drawing.Point(11, 22);
            this.tbFacValPre.Name = "tbFacValPre";
            this.tbFacValPre.Size = new System.Drawing.Size(100, 20);
            this.tbFacValPre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Face Value";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblSolutFac);
            this.tabPage3.Controls.Add(this.btnInfoFac);
            this.tabPage3.Controls.Add(this.btnSolveFac);
            this.tabPage3.Controls.Add(this.lblIntRateFac);
            this.tabPage3.Controls.Add(this.tbIntRateFac);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.tbPreValFac);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(291, 172);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Find Face Value";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblSolutFac
            // 
            this.lblSolutFac.AutoSize = true;
            this.lblSolutFac.Location = new System.Drawing.Point(14, 134);
            this.lblSolutFac.Name = "lblSolutFac";
            this.lblSolutFac.Size = new System.Drawing.Size(157, 13);
            this.lblSolutFac.TabIndex = 21;
            this.lblSolutFac.Text = "Click button \"Solve\" for solution";
            // 
            // btnInfoFac
            // 
            this.btnInfoFac.Location = new System.Drawing.Point(135, 104);
            this.btnInfoFac.Name = "btnInfoFac";
            this.btnInfoFac.Size = new System.Drawing.Size(117, 23);
            this.btnInfoFac.TabIndex = 20;
            this.btnInfoFac.Text = "Info";
            this.btnInfoFac.UseVisualStyleBackColor = true;
            this.btnInfoFac.Click += new System.EventHandler(this.btnInfoFac_Click);
            // 
            // btnSolveFac
            // 
            this.btnSolveFac.Location = new System.Drawing.Point(14, 104);
            this.btnSolveFac.Name = "btnSolveFac";
            this.btnSolveFac.Size = new System.Drawing.Size(117, 23);
            this.btnSolveFac.TabIndex = 19;
            this.btnSolveFac.Text = "Solve";
            this.btnSolveFac.UseVisualStyleBackColor = true;
            this.btnSolveFac.Click += new System.EventHandler(this.btnSolveFac_Click);
            // 
            // lblIntRateFac
            // 
            this.lblIntRateFac.AutoSize = true;
            this.lblIntRateFac.Location = new System.Drawing.Point(117, 71);
            this.lblIntRateFac.Name = "lblIntRateFac";
            this.lblIntRateFac.Size = new System.Drawing.Size(54, 13);
            this.lblIntRateFac.TabIndex = 18;
            this.lblIntRateFac.Text = "undefined";
            // 
            // tbIntRateFac
            // 
            this.tbIntRateFac.Location = new System.Drawing.Point(11, 64);
            this.tbIntRateFac.Name = "tbIntRateFac";
            this.tbIntRateFac.Size = new System.Drawing.Size(100, 20);
            this.tbIntRateFac.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Interest Rate";
            // 
            // tbPreValFac
            // 
            this.tbPreValFac.Location = new System.Drawing.Point(10, 22);
            this.tbPreValFac.Name = "tbPreValFac";
            this.tbPreValFac.Size = new System.Drawing.Size(100, 20);
            this.tbPreValFac.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Present Value";
            // 
            // frmZeroCoup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 198);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmZeroCoup";
            this.Text = "Zero Coupon Bonds";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFacValInt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPresValInt;
        private System.Windows.Forms.Button btnSolveInt;
        private System.Windows.Forms.Button btnInfoInt;
        private System.Windows.Forms.Label lblSolutInt;
        private System.Windows.Forms.Button btnSolvePre;
        private System.Windows.Forms.TextBox tbIntRatePre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFacValPre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSolutPre;
        private System.Windows.Forms.Button btnInfoPre;
        private System.Windows.Forms.Label lblIntRatePre;
        private System.Windows.Forms.Label lblSolutFac;
        private System.Windows.Forms.Button btnInfoFac;
        private System.Windows.Forms.Button btnSolveFac;
        private System.Windows.Forms.Label lblIntRateFac;
        private System.Windows.Forms.TextBox tbIntRateFac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPreValFac;
        private System.Windows.Forms.Label label4;
    }
}