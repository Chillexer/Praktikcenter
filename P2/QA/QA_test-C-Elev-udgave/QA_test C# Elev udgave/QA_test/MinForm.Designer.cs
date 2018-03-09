namespace QA_test {
    partial class MinForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbNavn = new System.Windows.Forms.TextBox();
            this.lblNavn = new System.Windows.Forms.Label();
            this.btnKlikMig = new System.Windows.Forms.Button();
            this.lblSvar = new System.Windows.Forms.Label();
            this.lblAlder = new System.Windows.Forms.Label();
            this.tbAlder = new System.Windows.Forms.TextBox();
            this.btnVurderAlder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNavn
            // 
            this.tbNavn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNavn.Location = new System.Drawing.Point(45, 11);
            this.tbNavn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNavn.Name = "tbNavn";
            this.tbNavn.Size = new System.Drawing.Size(158, 20);
            this.tbNavn.TabIndex = 1;
            this.tbNavn.Enter += new System.EventHandler(this.Tb_Enter);
            this.tbNavn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // lblNavn
            // 
            this.lblNavn.AutoSize = true;
            this.lblNavn.Location = new System.Drawing.Point(10, 11);
            this.lblNavn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNavn.Name = "lblNavn";
            this.lblNavn.Size = new System.Drawing.Size(33, 13);
            this.lblNavn.TabIndex = 1;
            this.lblNavn.Text = "Navn";
            // 
            // btnKlikMig
            // 
            this.btnKlikMig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKlikMig.Location = new System.Drawing.Point(0, 181);
            this.btnKlikMig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKlikMig.Name = "btnKlikMig";
            this.btnKlikMig.Size = new System.Drawing.Size(212, 25);
            this.btnKlikMig.TabIndex = 10;
            this.btnKlikMig.Text = "Klik mig";
            this.btnKlikMig.UseVisualStyleBackColor = true;
            this.btnKlikMig.Click += new System.EventHandler(this.BtnKlikMig_Click);
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(9, 60);
            this.lblSvar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 13);
            this.lblSvar.TabIndex = 0;
            // 
            // lblAlder
            // 
            this.lblAlder.AutoSize = true;
            this.lblAlder.Location = new System.Drawing.Point(10, 35);
            this.lblAlder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlder.Name = "lblAlder";
            this.lblAlder.Size = new System.Drawing.Size(31, 13);
            this.lblAlder.TabIndex = 4;
            this.lblAlder.Text = "Alder";
            // 
            // tbAlder
            // 
            this.tbAlder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlder.Location = new System.Drawing.Point(45, 35);
            this.tbAlder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAlder.Name = "tbAlder";
            this.tbAlder.Size = new System.Drawing.Size(158, 20);
            this.tbAlder.TabIndex = 2;
            this.tbAlder.Enter += new System.EventHandler(this.Tb_Enter);
            this.tbAlder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // btnVurderAlder
            // 
            this.btnVurderAlder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnVurderAlder.Location = new System.Drawing.Point(0, 156);
            this.btnVurderAlder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVurderAlder.Name = "btnVurderAlder";
            this.btnVurderAlder.Size = new System.Drawing.Size(212, 25);
            this.btnVurderAlder.TabIndex = 9;
            this.btnVurderAlder.Text = "Vurder alder";
            this.btnVurderAlder.UseVisualStyleBackColor = true;
            this.btnVurderAlder.Click += new System.EventHandler(this.BtnVurderAlder_Click);
            // 
            // MinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 206);
            this.Controls.Add(this.btnVurderAlder);
            this.Controls.Add(this.lblAlder);
            this.Controls.Add(this.tbAlder);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.btnKlikMig);
            this.Controls.Add(this.lblNavn);
            this.Controls.Add(this.tbNavn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MinForm";
            this.Text = "QA Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNavn;
        private System.Windows.Forms.Label lblNavn;
        private System.Windows.Forms.Button btnKlikMig;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Label lblAlder;
        private System.Windows.Forms.TextBox tbAlder;
        private System.Windows.Forms.Button btnVurderAlder;
    }
}

