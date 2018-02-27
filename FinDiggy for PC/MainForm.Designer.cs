namespace FinDiggy_for_PC
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnTimeValue = new System.Windows.Forms.Button();
            this.btnMoneyMarket = new System.Windows.Forms.Button();
            this.btnMeasuresFEI = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTimeValue
            // 
            this.btnTimeValue.Location = new System.Drawing.Point(12, 38);
            this.btnTimeValue.Name = "btnTimeValue";
            this.btnTimeValue.Size = new System.Drawing.Size(260, 35);
            this.btnTimeValue.TabIndex = 0;
            this.btnTimeValue.Text = "Time Value of Money";
            this.btnTimeValue.UseVisualStyleBackColor = true;
            this.btnTimeValue.Click += new System.EventHandler(this.btnTimeValue_Click);
            // 
            // btnMoneyMarket
            // 
            this.btnMoneyMarket.Location = new System.Drawing.Point(12, 89);
            this.btnMoneyMarket.Name = "btnMoneyMarket";
            this.btnMoneyMarket.Size = new System.Drawing.Size(260, 35);
            this.btnMoneyMarket.TabIndex = 1;
            this.btnMoneyMarket.Text = "Money Market";
            this.btnMoneyMarket.UseVisualStyleBackColor = true;
            this.btnMoneyMarket.Click += new System.EventHandler(this.btnMoneyMarket_Click);
            // 
            // btnMeasuresFEI
            // 
            this.btnMeasuresFEI.Location = new System.Drawing.Point(12, 140);
            this.btnMeasuresFEI.Name = "btnMeasuresFEI";
            this.btnMeasuresFEI.Size = new System.Drawing.Size(260, 35);
            this.btnMeasuresFEI.TabIndex = 2;
            this.btnMeasuresFEI.Text = "Measures for Evaluating Investments";
            this.btnMeasuresFEI.UseVisualStyleBackColor = true;
            this.btnMeasuresFEI.Click += new System.EventHandler(this.btnMeasuresFEI_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 191);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(260, 35);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnMeasuresFEI);
            this.Controls.Add(this.btnMoneyMarket);
            this.Controls.Add(this.btnTimeValue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "FinDiggy for PC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimeValue;
        private System.Windows.Forms.Button btnMoneyMarket;
        private System.Windows.Forms.Button btnMeasuresFEI;
        private System.Windows.Forms.Button btnAbout;
    }
}

