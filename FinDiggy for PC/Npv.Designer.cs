namespace FinDiggy_for_PC
{
    partial class frmNpv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNpv));
            this.label1 = new System.Windows.Forms.Label();
            this.tbIncomes = new System.Windows.Forms.TextBox();
            this.btnAddIn = new System.Windows.Forms.Button();
            this.btnDelIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOutcomes = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnCheIn = new System.Windows.Forms.Button();
            this.btnAddOu = new System.Windows.Forms.Button();
            this.btnCheOu = new System.Windows.Forms.Button();
            this.btnDelOu = new System.Windows.Forms.Button();
            this.tbDisRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDisRate = new System.Windows.Forms.Label();
            this.lblSolut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Incomes";
            // 
            // tbIncomes
            // 
            this.tbIncomes.Location = new System.Drawing.Point(13, 27);
            this.tbIncomes.Name = "tbIncomes";
            this.tbIncomes.Size = new System.Drawing.Size(100, 20);
            this.tbIncomes.TabIndex = 1;
            this.tbIncomes.TextChanged += new System.EventHandler(this.tbIncomes_TextChanged);
            // 
            // btnAddIn
            // 
            this.btnAddIn.Location = new System.Drawing.Point(119, 26);
            this.btnAddIn.Name = "btnAddIn";
            this.btnAddIn.Size = new System.Drawing.Size(153, 23);
            this.btnAddIn.TabIndex = 2;
            this.btnAddIn.Text = "Add";
            this.btnAddIn.UseVisualStyleBackColor = true;
            this.btnAddIn.Click += new System.EventHandler(this.btnAddIn_Click);
            // 
            // btnDelIn
            // 
            this.btnDelIn.Location = new System.Drawing.Point(119, 54);
            this.btnDelIn.Name = "btnDelIn";
            this.btnDelIn.Size = new System.Drawing.Size(153, 23);
            this.btnDelIn.TabIndex = 3;
            this.btnDelIn.Text = "Delete last income entry";
            this.btnDelIn.UseVisualStyleBackColor = true;
            this.btnDelIn.Click += new System.EventHandler(this.btnDelIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Outcomes";
            // 
            // tbOutcomes
            // 
            this.tbOutcomes.Location = new System.Drawing.Point(13, 114);
            this.tbOutcomes.Name = "tbOutcomes";
            this.tbOutcomes.Size = new System.Drawing.Size(100, 20);
            this.tbOutcomes.TabIndex = 6;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(12, 234);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(121, 23);
            this.btnSolve.TabIndex = 10;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(139, 234);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(121, 23);
            this.btnInfo.TabIndex = 11;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnCheIn
            // 
            this.btnCheIn.Location = new System.Drawing.Point(12, 54);
            this.btnCheIn.Name = "btnCheIn";
            this.btnCheIn.Size = new System.Drawing.Size(101, 23);
            this.btnCheIn.TabIndex = 12;
            this.btnCheIn.Text = "Check the entries";
            this.btnCheIn.UseVisualStyleBackColor = true;
            this.btnCheIn.Click += new System.EventHandler(this.btnCheIn_Click);
            // 
            // btnAddOu
            // 
            this.btnAddOu.Location = new System.Drawing.Point(119, 113);
            this.btnAddOu.Name = "btnAddOu";
            this.btnAddOu.Size = new System.Drawing.Size(153, 23);
            this.btnAddOu.TabIndex = 13;
            this.btnAddOu.Text = "Add";
            this.btnAddOu.UseVisualStyleBackColor = true;
            this.btnAddOu.Click += new System.EventHandler(this.btnAddOu_Click);
            // 
            // btnCheOu
            // 
            this.btnCheOu.Location = new System.Drawing.Point(12, 141);
            this.btnCheOu.Name = "btnCheOu";
            this.btnCheOu.Size = new System.Drawing.Size(101, 23);
            this.btnCheOu.TabIndex = 14;
            this.btnCheOu.Text = "Check the entries";
            this.btnCheOu.UseVisualStyleBackColor = true;
            this.btnCheOu.Click += new System.EventHandler(this.btnCheOu_Click);
            // 
            // btnDelOu
            // 
            this.btnDelOu.Location = new System.Drawing.Point(119, 141);
            this.btnDelOu.Name = "btnDelOu";
            this.btnDelOu.Size = new System.Drawing.Size(153, 23);
            this.btnDelOu.TabIndex = 15;
            this.btnDelOu.Text = "Delete last income entry";
            this.btnDelOu.UseVisualStyleBackColor = true;
            this.btnDelOu.Click += new System.EventHandler(this.btnDelOu_Click);
            // 
            // tbDisRate
            // 
            this.tbDisRate.Location = new System.Drawing.Point(13, 194);
            this.tbDisRate.Name = "tbDisRate";
            this.tbDisRate.Size = new System.Drawing.Size(100, 20);
            this.tbDisRate.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Discount Rate";
            // 
            // lblDisRate
            // 
            this.lblDisRate.AutoSize = true;
            this.lblDisRate.Location = new System.Drawing.Point(116, 201);
            this.lblDisRate.Name = "lblDisRate";
            this.lblDisRate.Size = new System.Drawing.Size(54, 13);
            this.lblDisRate.TabIndex = 20;
            this.lblDisRate.Text = "undefined";
            // 
            // lblSolut
            // 
            this.lblSolut.AutoSize = true;
            this.lblSolut.Location = new System.Drawing.Point(14, 260);
            this.lblSolut.Name = "lblSolut";
            this.lblSolut.Size = new System.Drawing.Size(157, 13);
            this.lblSolut.TabIndex = 21;
            this.lblSolut.Text = "Click button \"Solve\" for solution";
            // 
            // frmNpv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 308);
            this.Controls.Add(this.lblSolut);
            this.Controls.Add(this.lblDisRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDisRate);
            this.Controls.Add(this.btnDelOu);
            this.Controls.Add(this.btnCheOu);
            this.Controls.Add(this.btnAddOu);
            this.Controls.Add(this.btnCheIn);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.tbOutcomes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelIn);
            this.Controls.Add(this.btnAddIn);
            this.Controls.Add(this.tbIncomes);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNpv";
            this.Text = "Net Present Value";
            this.Load += new System.EventHandler(this.Npv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIncomes;
        private System.Windows.Forms.Button btnAddIn;
        private System.Windows.Forms.Button btnDelIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOutcomes;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnCheIn;
        private System.Windows.Forms.Button btnAddOu;
        private System.Windows.Forms.Button btnCheOu;
        private System.Windows.Forms.Button btnDelOu;
        private System.Windows.Forms.TextBox tbDisRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDisRate;
        private System.Windows.Forms.Label lblSolut;
    }
}