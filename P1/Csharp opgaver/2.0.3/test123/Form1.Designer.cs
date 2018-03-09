namespace test123
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
            this.tbdata = new System.Windows.Forms.TextBox();
            this.tbsum = new System.Windows.Forms.TextBox();
            this.btsum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbdata
            // 
            this.tbdata.Location = new System.Drawing.Point(37, 44);
            this.tbdata.Name = "tbdata";
            this.tbdata.Size = new System.Drawing.Size(113, 20);
            this.tbdata.TabIndex = 0;
            this.tbdata.TextChanged += new System.EventHandler(this.tbdata_TextChanged);
            this.tbdata.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbdata_KeyDown);
            this.tbdata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbdata_KeyPress);
            // 
            // tbsum
            // 
            this.tbsum.Enabled = false;
            this.tbsum.Location = new System.Drawing.Point(173, 49);
            this.tbsum.Name = "tbsum";
            this.tbsum.Size = new System.Drawing.Size(99, 20);
            this.tbsum.TabIndex = 1;
            // 
            // btsum
            // 
            this.btsum.Location = new System.Drawing.Point(61, 112);
            this.btsum.Name = "btsum";
            this.btsum.Size = new System.Drawing.Size(198, 92);
            this.btsum.TabIndex = 2;
            this.btsum.Text = "btsum";
            this.btsum.UseVisualStyleBackColor = true;
            this.btsum.Click += new System.EventHandler(this.btsum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btsum);
            this.Controls.Add(this.tbsum);
            this.Controls.Add(this.tbdata);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbdata;
        private System.Windows.Forms.TextBox tbsum;
        private System.Windows.Forms.Button btsum;
    }
}

