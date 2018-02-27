namespace FinDiggy_for_PC
{
    partial class frmTimeValue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimeValue));
            this.btnSimInt = new System.Windows.Forms.Button();
            this.btnPerComp = new System.Windows.Forms.Button();
            this.btnContComp = new System.Windows.Forms.Button();
            this.btnStreams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSimInt
            // 
            this.btnSimInt.Location = new System.Drawing.Point(12, 37);
            this.btnSimInt.Name = "btnSimInt";
            this.btnSimInt.Size = new System.Drawing.Size(260, 35);
            this.btnSimInt.TabIndex = 1;
            this.btnSimInt.Text = "Simple Interest";
            this.btnSimInt.UseVisualStyleBackColor = true;
            this.btnSimInt.Click += new System.EventHandler(this.btnTimeValue_Click);
            // 
            // btnPerComp
            // 
            this.btnPerComp.Location = new System.Drawing.Point(12, 89);
            this.btnPerComp.Name = "btnPerComp";
            this.btnPerComp.Size = new System.Drawing.Size(260, 35);
            this.btnPerComp.TabIndex = 2;
            this.btnPerComp.Text = "Periodic Compounding";
            this.btnPerComp.UseVisualStyleBackColor = true;
            this.btnPerComp.Click += new System.EventHandler(this.btnPerComp_Click);
            // 
            // btnContComp
            // 
            this.btnContComp.Location = new System.Drawing.Point(12, 141);
            this.btnContComp.Name = "btnContComp";
            this.btnContComp.Size = new System.Drawing.Size(260, 35);
            this.btnContComp.TabIndex = 3;
            this.btnContComp.Text = "Continuous Compounding";
            this.btnContComp.UseVisualStyleBackColor = true;
            this.btnContComp.Click += new System.EventHandler(this.btnContComp_Click);
            // 
            // btnStreams
            // 
            this.btnStreams.Location = new System.Drawing.Point(12, 193);
            this.btnStreams.Name = "btnStreams";
            this.btnStreams.Size = new System.Drawing.Size(260, 35);
            this.btnStreams.TabIndex = 4;
            this.btnStreams.Text = "Streams of Payments";
            this.btnStreams.UseVisualStyleBackColor = true;
            this.btnStreams.Click += new System.EventHandler(this.btnStreams_Click);
            // 
            // frmTimeValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnStreams);
            this.Controls.Add(this.btnContComp);
            this.Controls.Add(this.btnPerComp);
            this.Controls.Add(this.btnSimInt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimeValue";
            this.Text = "Time Value Of Money";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSimInt;
        private System.Windows.Forms.Button btnPerComp;
        private System.Windows.Forms.Button btnContComp;
        private System.Windows.Forms.Button btnStreams;
    }
}