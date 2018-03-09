namespace _2._0._1
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
            this.btnext = new System.Windows.Forms.Button();
            this.Tbdata = new System.Windows.Forms.TextBox();
            this.Tbsum = new System.Windows.Forms.TextBox();
            this.Lbdata = new System.Windows.Forms.Label();
            this.lbsum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnext
            // 
            this.btnext.Location = new System.Drawing.Point(229, 122);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(108, 43);
            this.btnext.TabIndex = 0;
            this.btnext.Text = "Næste";
            this.btnext.UseVisualStyleBackColor = true;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // Tbdata
            // 
            this.Tbdata.Location = new System.Drawing.Point(108, 70);
            this.Tbdata.Name = "Tbdata";
            this.Tbdata.Size = new System.Drawing.Size(100, 20);
            this.Tbdata.TabIndex = 1;
            this.Tbdata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbdata_KeyPress);
            // 
            // Tbsum
            // 
            this.Tbsum.Enabled = false;
            this.Tbsum.Location = new System.Drawing.Point(229, 70);
            this.Tbsum.Name = "Tbsum";
            this.Tbsum.Size = new System.Drawing.Size(108, 20);
            this.Tbsum.TabIndex = 2;
            // 
            // Lbdata
            // 
            this.Lbdata.AutoSize = true;
            this.Lbdata.Location = new System.Drawing.Point(132, 46);
            this.Lbdata.Name = "Lbdata";
            this.Lbdata.Size = new System.Drawing.Size(50, 13);
            this.Lbdata.TabIndex = 3;
            this.Lbdata.Text = "Første tal";
            // 
            // lbsum
            // 
            this.lbsum.AutoSize = true;
            this.lbsum.Location = new System.Drawing.Point(265, 46);
            this.lbsum.Name = "lbsum";
            this.lbsum.Size = new System.Drawing.Size(28, 13);
            this.lbsum.TabIndex = 4;
            this.lbsum.Text = "Sum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 267);
            this.Controls.Add(this.lbsum);
            this.Controls.Add(this.Lbdata);
            this.Controls.Add(this.Tbsum);
            this.Controls.Add(this.Tbdata);
            this.Controls.Add(this.btnext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.TextBox Tbdata;
        private System.Windows.Forms.TextBox Tbsum;
        private System.Windows.Forms.Label Lbdata;
        private System.Windows.Forms.Label lbsum;
    }
}

