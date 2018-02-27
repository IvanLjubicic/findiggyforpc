namespace FinDiggy_for_PC
{
    partial class frmMonMark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonMark));
            this.btnZeroCoupon = new System.Windows.Forms.Button();
            this.btnCoupBonds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZeroCoupon
            // 
            this.btnZeroCoupon.Location = new System.Drawing.Point(12, 32);
            this.btnZeroCoupon.Name = "btnZeroCoupon";
            this.btnZeroCoupon.Size = new System.Drawing.Size(260, 35);
            this.btnZeroCoupon.TabIndex = 1;
            this.btnZeroCoupon.Text = "Zero-Coupon Bonds";
            this.btnZeroCoupon.UseVisualStyleBackColor = true;
            this.btnZeroCoupon.Click += new System.EventHandler(this.btnZeroCoupon_Click);
            // 
            // btnCoupBonds
            // 
            this.btnCoupBonds.Location = new System.Drawing.Point(12, 82);
            this.btnCoupBonds.Name = "btnCoupBonds";
            this.btnCoupBonds.Size = new System.Drawing.Size(260, 35);
            this.btnCoupBonds.TabIndex = 2;
            this.btnCoupBonds.Text = "Coupon Bonds";
            this.btnCoupBonds.UseVisualStyleBackColor = true;
            this.btnCoupBonds.Click += new System.EventHandler(this.btnCoupBonds_Click);
            // 
            // frmMonMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.btnCoupBonds);
            this.Controls.Add(this.btnZeroCoupon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMonMark";
            this.Text = "Money Market";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZeroCoupon;
        private System.Windows.Forms.Button btnCoupBonds;
    }
}