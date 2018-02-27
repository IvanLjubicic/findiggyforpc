namespace FinDiggy_for_PC
{
    partial class frmMeasFEI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeasFEI));
            this.btnNpv = new System.Windows.Forms.Button();
            this.btnAritRet = new System.Windows.Forms.Button();
            this.bnExpRet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNpv
            // 
            this.btnNpv.Location = new System.Drawing.Point(12, 37);
            this.btnNpv.Name = "btnNpv";
            this.btnNpv.Size = new System.Drawing.Size(260, 35);
            this.btnNpv.TabIndex = 1;
            this.btnNpv.Text = "Net Present Value";
            this.btnNpv.UseVisualStyleBackColor = true;
            this.btnNpv.Click += new System.EventHandler(this.btnNpv_Click);
            // 
            // btnAritRet
            // 
            this.btnAritRet.Location = new System.Drawing.Point(12, 88);
            this.btnAritRet.Name = "btnAritRet";
            this.btnAritRet.Size = new System.Drawing.Size(260, 35);
            this.btnAritRet.TabIndex = 2;
            this.btnAritRet.Text = "Arithmetic and Geometric Average Rate of Return";
            this.btnAritRet.UseVisualStyleBackColor = true;
            this.btnAritRet.Click += new System.EventHandler(this.btnAritRet_Click);
            // 
            // bnExpRet
            // 
            this.bnExpRet.Location = new System.Drawing.Point(12, 143);
            this.bnExpRet.Name = "bnExpRet";
            this.bnExpRet.Size = new System.Drawing.Size(260, 35);
            this.bnExpRet.TabIndex = 3;
            this.bnExpRet.Text = "Expected Return";
            this.bnExpRet.UseVisualStyleBackColor = true;
            this.bnExpRet.Click += new System.EventHandler(this.bnExpRet_Click);
            // 
            // frmMeasFEI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.bnExpRet);
            this.Controls.Add(this.btnAritRet);
            this.Controls.Add(this.btnNpv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMeasFEI";
            this.Text = "Measures For Evaluating Investment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNpv;
        private System.Windows.Forms.Button btnAritRet;
        private System.Windows.Forms.Button bnExpRet;
    }
}