namespace GeoTema
{
    partial class Opret_bruger
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
            this.comborettigheder = new System.Windows.Forms.ComboBox();
            this.knapopret = new System.Windows.Forms.Button();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labelrettigheder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(11, 65);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(136, 65);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 1;
            // 
            // comborettigheder
            // 
            this.comborettigheder.FormattingEnabled = true;
            this.comborettigheder.Items.AddRange(new object[] {
            "Administrator",
            "Superbruger",
            "Standard bruger"});
            this.comborettigheder.Location = new System.Drawing.Point(262, 65);
            this.comborettigheder.Name = "comborettigheder";
            this.comborettigheder.Size = new System.Drawing.Size(121, 21);
            this.comborettigheder.TabIndex = 2;
            // 
            // knapopret
            // 
            this.knapopret.Location = new System.Drawing.Point(150, 110);
            this.knapopret.Name = "knapopret";
            this.knapopret.Size = new System.Drawing.Size(75, 23);
            this.knapopret.TabIndex = 3;
            this.knapopret.Text = "Opret";
            this.knapopret.UseVisualStyleBackColor = true;
            this.knapopret.Click += new System.EventHandler(this.knapopret_Click);
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Location = new System.Drawing.Point(34, 39);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(55, 13);
            this.labelusername.TabIndex = 4;
            this.labelusername.Text = "Username";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Location = new System.Drawing.Point(160, 39);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(53, 13);
            this.labelpassword.TabIndex = 5;
            this.labelpassword.Text = "Password";
            // 
            // labelrettigheder
            // 
            this.labelrettigheder.AutoSize = true;
            this.labelrettigheder.Location = new System.Drawing.Point(291, 39);
            this.labelrettigheder.Name = "labelrettigheder";
            this.labelrettigheder.Size = new System.Drawing.Size(62, 13);
            this.labelrettigheder.TabIndex = 6;
            this.labelrettigheder.Text = "Rettigheder";
            // 
            // Opret_bruger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 161);
            this.Controls.Add(this.labelrettigheder);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.knapopret);
            this.Controls.Add(this.comborettigheder);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Name = "Opret_bruger";
            this.Text = "Opret bruger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.ComboBox comborettigheder;
        private System.Windows.Forms.Button knapopret;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labelrettigheder;
    }
}