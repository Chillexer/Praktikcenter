namespace GeoTema
{
    partial class Nulstil
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
            this.knapnulstil = new System.Windows.Forms.Button();
            this.cboxlogins = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // knapnulstil
            // 
            this.knapnulstil.Location = new System.Drawing.Point(35, 39);
            this.knapnulstil.Name = "knapnulstil";
            this.knapnulstil.Size = new System.Drawing.Size(75, 23);
            this.knapnulstil.TabIndex = 0;
            this.knapnulstil.Text = "Nulstil";
            this.knapnulstil.UseVisualStyleBackColor = true;
            this.knapnulstil.Click += new System.EventHandler(this.Knapnulstil_Click);
            // 
            // cboxlogins
            // 
            this.cboxlogins.FormattingEnabled = true;
            this.cboxlogins.Location = new System.Drawing.Point(12, 12);
            this.cboxlogins.Name = "cboxlogins";
            this.cboxlogins.Size = new System.Drawing.Size(121, 21);
            this.cboxlogins.TabIndex = 1;
            // 
            // Nulstil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 70);
            this.Controls.Add(this.cboxlogins);
            this.Controls.Add(this.knapnulstil);
            this.Name = "Nulstil";
            this.Text = "Nulstil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button knapnulstil;
        private System.Windows.Forms.ComboBox cboxlogins;
    }
}