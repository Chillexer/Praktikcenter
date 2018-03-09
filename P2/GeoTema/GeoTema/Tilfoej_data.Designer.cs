namespace GeoTema
{
    partial class TilfoejData
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
            this.labeltabel1 = new System.Windows.Forms.Label();
            this.labeltabel2 = new System.Windows.Forms.Label();
            this.labeltabel1land = new System.Windows.Forms.Label();
            this.labeltabel1verdensdel = new System.Windows.Forms.Label();
            this.txtland = new System.Windows.Forms.TextBox();
            this.txtverdensdel = new System.Windows.Forms.TextBox();
            this.txtrang = new System.Windows.Forms.TextBox();
            this.labeltabel2rang = new System.Windows.Forms.Label();
            this.txtfrate = new System.Windows.Forms.TextBox();
            this.labeltabel2Frate = new System.Windows.Forms.Label();
            this.knaptilfoej = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeltabel1
            // 
            this.labeltabel1.AutoSize = true;
            this.labeltabel1.Location = new System.Drawing.Point(135, 47);
            this.labeltabel1.Name = "labeltabel1";
            this.labeltabel1.Size = new System.Drawing.Size(31, 13);
            this.labeltabel1.TabIndex = 0;
            this.labeltabel1.Text = "Land";
            // 
            // labeltabel2
            // 
            this.labeltabel2.AutoSize = true;
            this.labeltabel2.Location = new System.Drawing.Point(324, 47);
            this.labeltabel2.Name = "labeltabel2";
            this.labeltabel2.Size = new System.Drawing.Size(33, 13);
            this.labeltabel2.TabIndex = 1;
            this.labeltabel2.Text = "Rang";
            // 
            // labeltabel1land
            // 
            this.labeltabel1land.AutoSize = true;
            this.labeltabel1land.Location = new System.Drawing.Point(15, 74);
            this.labeltabel1land.Name = "labeltabel1land";
            this.labeltabel1land.Size = new System.Drawing.Size(31, 13);
            this.labeltabel1land.TabIndex = 4;
            this.labeltabel1land.Text = "Land";
            // 
            // labeltabel1verdensdel
            // 
            this.labeltabel1verdensdel.AutoSize = true;
            this.labeltabel1verdensdel.Location = new System.Drawing.Point(15, 124);
            this.labeltabel1verdensdel.Name = "labeltabel1verdensdel";
            this.labeltabel1verdensdel.Size = new System.Drawing.Size(60, 13);
            this.labeltabel1verdensdel.TabIndex = 5;
            this.labeltabel1verdensdel.Text = "Verdensdel";
            // 
            // txtland
            // 
            this.txtland.Location = new System.Drawing.Point(100, 70);
            this.txtland.Name = "txtland";
            this.txtland.Size = new System.Drawing.Size(100, 20);
            this.txtland.TabIndex = 7;
            // 
            // txtverdensdel
            // 
            this.txtverdensdel.Location = new System.Drawing.Point(100, 120);
            this.txtverdensdel.Name = "txtverdensdel";
            this.txtverdensdel.Size = new System.Drawing.Size(100, 20);
            this.txtverdensdel.TabIndex = 8;
            // 
            // txtrang
            // 
            this.txtrang.Location = new System.Drawing.Point(290, 70);
            this.txtrang.Name = "txtrang";
            this.txtrang.Size = new System.Drawing.Size(100, 20);
            this.txtrang.TabIndex = 10;
            this.txtrang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrang_KeyPress);
            // 
            // labeltabel2rang
            // 
            this.labeltabel2rang.AutoSize = true;
            this.labeltabel2rang.Location = new System.Drawing.Point(215, 74);
            this.labeltabel2rang.Name = "labeltabel2rang";
            this.labeltabel2rang.Size = new System.Drawing.Size(33, 13);
            this.labeltabel2rang.TabIndex = 12;
            this.labeltabel2rang.Text = "Rang";
            // 
            // txtfrate
            // 
            this.txtfrate.Location = new System.Drawing.Point(290, 120);
            this.txtfrate.Name = "txtfrate";
            this.txtfrate.Size = new System.Drawing.Size(100, 20);
            this.txtfrate.TabIndex = 14;
            this.txtfrate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfrate_KeyPress);
            // 
            // labeltabel2Frate
            // 
            this.labeltabel2Frate.AutoSize = true;
            this.labeltabel2Frate.Location = new System.Drawing.Point(215, 124);
            this.labeltabel2Frate.Name = "labeltabel2Frate";
            this.labeltabel2Frate.Size = new System.Drawing.Size(61, 13);
            this.labeltabel2Frate.TabIndex = 13;
            this.labeltabel2Frate.Text = "Fødselsrate";
            // 
            // knaptilfoej
            // 
            this.knaptilfoej.Location = new System.Drawing.Point(190, 220);
            this.knaptilfoej.Name = "knaptilfoej";
            this.knaptilfoej.Size = new System.Drawing.Size(80, 50);
            this.knaptilfoej.TabIndex = 15;
            this.knaptilfoej.Text = "Tilføj";
            this.knaptilfoej.UseVisualStyleBackColor = true;
            this.knaptilfoej.Click += new System.EventHandler(this.knaptilfoej_Click);
            // 
            // Tilfoej_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 281);
            this.Controls.Add(this.knaptilfoej);
            this.Controls.Add(this.txtfrate);
            this.Controls.Add(this.labeltabel2Frate);
            this.Controls.Add(this.labeltabel2rang);
            this.Controls.Add(this.txtrang);
            this.Controls.Add(this.txtverdensdel);
            this.Controls.Add(this.txtland);
            this.Controls.Add(this.labeltabel1verdensdel);
            this.Controls.Add(this.labeltabel1land);
            this.Controls.Add(this.labeltabel2);
            this.Controls.Add(this.labeltabel1);
            this.Name = "Tilfoej_data";
            this.Text = "Tilfoej_data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltabel1;
        private System.Windows.Forms.Label labeltabel2;
        private System.Windows.Forms.Label labeltabel1land;
        private System.Windows.Forms.Label labeltabel1verdensdel;
        private System.Windows.Forms.TextBox txtland;
        private System.Windows.Forms.TextBox txtverdensdel;
        private System.Windows.Forms.TextBox txtrang;
        private System.Windows.Forms.Label labeltabel2rang;
        private System.Windows.Forms.TextBox txtfrate;
        private System.Windows.Forms.Label labeltabel2Frate;
        private System.Windows.Forms.Button knaptilfoej;
    }
}