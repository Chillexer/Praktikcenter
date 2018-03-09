namespace GeoTema
{
    partial class Login
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.knaplogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(50, 65);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(216, 65);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Location = new System.Drawing.Point(74, 40);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(55, 13);
            this.labelusername.TabIndex = 2;
            this.labelusername.Text = "Username";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Location = new System.Drawing.Point(241, 40);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(53, 13);
            this.labelpassword.TabIndex = 3;
            this.labelpassword.Text = "Password";
            // 
            // knaplogin
            // 
            this.knaplogin.Location = new System.Drawing.Point(144, 111);
            this.knaplogin.Name = "knaplogin";
            this.knaplogin.Size = new System.Drawing.Size(77, 44);
            this.knaplogin.TabIndex = 4;
            this.knaplogin.Text = "Login";
            this.knaplogin.UseVisualStyleBackColor = true;
            this.knaplogin.Click += new System.EventHandler(this.knaplogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 172);
            this.Controls.Add(this.knaplogin);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Button knaplogin;
    }
}