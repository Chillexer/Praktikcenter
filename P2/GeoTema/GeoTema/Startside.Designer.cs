namespace GeoTema
{
    partial class Startside
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
            this.knapopretbruger = new System.Windows.Forms.Button();
            this.knapnulstil = new System.Windows.Forms.Button();
            this.knaptilfoej_data = new System.Windows.Forms.Button();
            this.Gridview = new System.Windows.Forms.DataGridView();
            this.knapupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // knapopretbruger
            // 
            this.knapopretbruger.Location = new System.Drawing.Point(275, 30);
            this.knapopretbruger.Name = "knapopretbruger";
            this.knapopretbruger.Size = new System.Drawing.Size(75, 50);
            this.knapopretbruger.TabIndex = 0;
            this.knapopretbruger.Text = "Opret bruger";
            this.knapopretbruger.UseVisualStyleBackColor = true;
            this.knapopretbruger.Click += new System.EventHandler(this.KnapOpretBruger_Click);
            // 
            // knapnulstil
            // 
            this.knapnulstil.Location = new System.Drawing.Point(375, 30);
            this.knapnulstil.Name = "knapnulstil";
            this.knapnulstil.Size = new System.Drawing.Size(75, 50);
            this.knapnulstil.TabIndex = 1;
            this.knapnulstil.Text = "Nulstil kode";
            this.knapnulstil.UseVisualStyleBackColor = true;
            this.knapnulstil.Click += new System.EventHandler(this.KnapNulstil_Click);
            // 
            // knaptilfoej_data
            // 
            this.knaptilfoej_data.Location = new System.Drawing.Point(475, 30);
            this.knaptilfoej_data.Name = "knaptilfoej_data";
            this.knaptilfoej_data.Size = new System.Drawing.Size(75, 50);
            this.knaptilfoej_data.TabIndex = 2;
            this.knaptilfoej_data.Text = "Tilføj data";
            this.knaptilfoej_data.UseVisualStyleBackColor = true;
            this.knaptilfoej_data.Click += new System.EventHandler(this.KnapTilfoejData_Click);
            // 
            // Gridview
            // 
            this.Gridview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridview.Location = new System.Drawing.Point(12, 104);
            this.Gridview.Name = "Gridview";
            this.Gridview.Size = new System.Drawing.Size(660, 245);
            this.Gridview.TabIndex = 3;
            // 
            // knapupdate
            // 
            this.knapupdate.Location = new System.Drawing.Point(570, 30);
            this.knapupdate.Name = "knapupdate";
            this.knapupdate.Size = new System.Drawing.Size(75, 50);
            this.knapupdate.TabIndex = 4;
            this.knapupdate.Text = "Update";
            this.knapupdate.UseVisualStyleBackColor = true;
            this.knapupdate.Click += new System.EventHandler(this.KnapOpdater_Click);
            // 
            // Startside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 360);
            this.Controls.Add(this.knapupdate);
            this.Controls.Add(this.Gridview);
            this.Controls.Add(this.knaptilfoej_data);
            this.Controls.Add(this.knapnulstil);
            this.Controls.Add(this.knapopretbruger);
            this.Name = "Startside";
            this.Text = "Startside";
            ((System.ComponentModel.ISupportInitialize)(this.Gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button knapopretbruger;
        private System.Windows.Forms.Button knapnulstil;
        private System.Windows.Forms.Button knaptilfoej_data;
        private System.Windows.Forms.DataGridView Gridview;
        private System.Windows.Forms.Button knapupdate;
    }
}