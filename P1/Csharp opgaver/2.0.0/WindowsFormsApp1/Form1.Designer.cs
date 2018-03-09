namespace WindowsFormsApp1
{
    partial class Form1
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
            this.BtnSum = new System.Windows.Forms.Button();
            this.Lb1 = new System.Windows.Forms.Label();
            this.Lb2 = new System.Windows.Forms.Label();
            this.tbtal1 = new System.Windows.Forms.TextBox();
            this.tbtal2 = new System.Windows.Forms.TextBox();
            this.tbsum = new System.Windows.Forms.TextBox();
            this.Lbsum = new System.Windows.Forms.Label();
            this.tbop = new System.Windows.Forms.TextBox();
            this.Lbop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSum
            // 
            this.BtnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSum.Location = new System.Drawing.Point(346, 122);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(100, 37);
            this.BtnSum.TabIndex = 0;
            this.BtnSum.Text = "=";
            this.BtnSum.UseVisualStyleBackColor = true;
            this.BtnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Location = new System.Drawing.Point(118, 35);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(50, 13);
            this.Lb1.TabIndex = 5;
            this.Lb1.Text = "Første tal";
            this.Lb1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lb2
            // 
            this.Lb2.AutoSize = true;
            this.Lb2.Location = new System.Drawing.Point(267, 35);
            this.Lb2.Name = "Lb2";
            this.Lb2.Size = new System.Drawing.Size(49, 13);
            this.Lb2.TabIndex = 6;
            this.Lb2.Text = "Andet tal";
            // 
            // tbtal1
            // 
            this.tbtal1.Location = new System.Drawing.Point(89, 63);
            this.tbtal1.Name = "tbtal1";
            this.tbtal1.Size = new System.Drawing.Size(100, 20);
            this.tbtal1.TabIndex = 7;
            // 
            // tbtal2
            // 
            this.tbtal2.Location = new System.Drawing.Point(240, 63);
            this.tbtal2.Name = "tbtal2";
            this.tbtal2.Size = new System.Drawing.Size(100, 20);
            this.tbtal2.TabIndex = 8;
            // 
            // tbsum
            // 
            this.tbsum.Enabled = false;
            this.tbsum.Location = new System.Drawing.Point(346, 63);
            this.tbsum.Name = "tbsum";
            this.tbsum.Size = new System.Drawing.Size(100, 20);
            this.tbsum.TabIndex = 9;
            // 
            // Lbsum
            // 
            this.Lbsum.AutoSize = true;
            this.Lbsum.Location = new System.Drawing.Point(376, 35);
            this.Lbsum.Name = "Lbsum";
            this.Lbsum.Size = new System.Drawing.Size(28, 13);
            this.Lbsum.TabIndex = 10;
            this.Lbsum.Text = "Sum";
            // 
            // tbop
            // 
            this.tbop.Location = new System.Drawing.Point(195, 63);
            this.tbop.Name = "tbop";
            this.tbop.Size = new System.Drawing.Size(39, 20);
            this.tbop.TabIndex = 11;
            // 
            // Lbop
            // 
            this.Lbop.AutoSize = true;
            this.Lbop.Location = new System.Drawing.Point(192, 35);
            this.Lbop.Name = "Lbop";
            this.Lbop.Size = new System.Drawing.Size(48, 13);
            this.Lbop.TabIndex = 12;
            this.Lbop.Text = "Operator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 222);
            this.Controls.Add(this.Lbop);
            this.Controls.Add(this.tbop);
            this.Controls.Add(this.Lbsum);
            this.Controls.Add(this.tbsum);
            this.Controls.Add(this.tbtal2);
            this.Controls.Add(this.tbtal1);
            this.Controls.Add(this.Lb2);
            this.Controls.Add(this.Lb1);
            this.Controls.Add(this.BtnSum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSum;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Label Lb2;
        private System.Windows.Forms.TextBox tbtal1;
        private System.Windows.Forms.TextBox tbtal2;
        private System.Windows.Forms.TextBox tbsum;
        private System.Windows.Forms.Label Lbsum;
        private System.Windows.Forms.TextBox tbop;
        private System.Windows.Forms.Label Lbop;
    }
}

