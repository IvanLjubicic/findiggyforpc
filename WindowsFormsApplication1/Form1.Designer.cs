namespace WindowsFormsApplication1
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
            this.btnTimeValue = new System.Windows.Forms.Button();
            this.btnMoneyMarket = new System.Windows.Forms.Button();
            this.btnMeasuresFEI = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTimeValue
            // 
            this.btnTimeValue.Location = new System.Drawing.Point(12, 12);
            this.btnTimeValue.Name = "btnTimeValue";
            this.btnTimeValue.Size = new System.Drawing.Size(260, 37);
            this.btnTimeValue.TabIndex = 1;
            this.btnTimeValue.Text = "Time Value of Money";
            this.btnTimeValue.UseVisualStyleBackColor = true;
            // 
            // btnMoneyMarket
            // 
            this.btnMoneyMarket.Location = new System.Drawing.Point(12, 66);
            this.btnMoneyMarket.Name = "btnMoneyMarket";
            this.btnMoneyMarket.Size = new System.Drawing.Size(260, 37);
            this.btnMoneyMarket.TabIndex = 2;
            this.btnMoneyMarket.Text = "Money Market";
            this.btnMoneyMarket.UseVisualStyleBackColor = true;
            // 
            // btnMeasuresFEI
            // 
            this.btnMeasuresFEI.Location = new System.Drawing.Point(12, 120);
            this.btnMeasuresFEI.Name = "btnMeasuresFEI";
            this.btnMeasuresFEI.Size = new System.Drawing.Size(260, 37);
            this.btnMeasuresFEI.TabIndex = 3;
            this.btnMeasuresFEI.Text = "Measures For Evaluating Investment";
            this.btnMeasuresFEI.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 174);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(260, 37);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About Us";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 229);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnMeasuresFEI);
            this.Controls.Add(this.btnMoneyMarket);
            this.Controls.Add(this.btnTimeValue);
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

