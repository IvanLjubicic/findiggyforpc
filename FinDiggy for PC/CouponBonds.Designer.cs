namespace FinDiggy_for_PC
{
    partial class frmCoupBon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoupBon));
            this.label1 = new System.Windows.Forms.Label();
            this.tbFacVal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCoupVal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIntRate = new System.Windows.Forms.TextBox();
            this.lblIntRate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMatDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCoupAnn = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblSolut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Face Value";
            // 
            // tbFacVal
            // 
            this.tbFacVal.Location = new System.Drawing.Point(18, 26);
            this.tbFacVal.Name = "tbFacVal";
            this.tbFacVal.Size = new System.Drawing.Size(100, 20);
            this.tbFacVal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coupon Value";
            // 
            // tbCoupVal
            // 
            this.tbCoupVal.Location = new System.Drawing.Point(18, 70);
            this.tbCoupVal.Name = "tbCoupVal";
            this.tbCoupVal.Size = new System.Drawing.Size(100, 20);
            this.tbCoupVal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Interest Rate";
            // 
            // tbIntRate
            // 
            this.tbIntRate.Location = new System.Drawing.Point(18, 114);
            this.tbIntRate.Name = "tbIntRate";
            this.tbIntRate.Size = new System.Drawing.Size(100, 20);
            this.tbIntRate.TabIndex = 5;
            // 
            // lblIntRate
            // 
            this.lblIntRate.AutoSize = true;
            this.lblIntRate.Location = new System.Drawing.Point(122, 120);
            this.lblIntRate.Name = "lblIntRate";
            this.lblIntRate.Size = new System.Drawing.Size(54, 13);
            this.lblIntRate.TabIndex = 6;
            this.lblIntRate.Text = "undefined";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maturity Date";
            // 
            // tbMatDate
            // 
            this.tbMatDate.Location = new System.Drawing.Point(18, 158);
            this.tbMatDate.Name = "tbMatDate";
            this.tbMatDate.Size = new System.Drawing.Size(100, 20);
            this.tbMatDate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Number Of Coupons Per Annum";
            // 
            // tbCoupAnn
            // 
            this.tbCoupAnn.Location = new System.Drawing.Point(18, 202);
            this.tbCoupAnn.Name = "tbCoupAnn";
            this.tbCoupAnn.Size = new System.Drawing.Size(100, 20);
            this.tbCoupAnn.TabIndex = 10;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(18, 238);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(117, 23);
            this.btnSolve.TabIndex = 14;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(141, 238);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(117, 23);
            this.btnInfo.TabIndex = 15;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lblSolut
            // 
            this.lblSolut.AutoSize = true;
            this.lblSolut.Location = new System.Drawing.Point(19, 264);
            this.lblSolut.Name = "lblSolut";
            this.lblSolut.Size = new System.Drawing.Size(157, 13);
            this.lblSolut.TabIndex = 16;
            this.lblSolut.Text = "Click button \"Solve\" for solution";
            // 
            // frmCoupBon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 313);
            this.Controls.Add(this.lblSolut);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.tbCoupAnn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMatDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblIntRate);
            this.Controls.Add(this.tbIntRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCoupVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFacVal);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCoupBon";
            this.Text = "Coupon Bonds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFacVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCoupVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIntRate;
        private System.Windows.Forms.Label lblIntRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMatDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCoupAnn;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblSolut;
    }
}