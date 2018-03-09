using System;
using System.Data;
using System.Windows.Forms;

namespace GeoTema
{
    public partial class Startside : Form
    {
        public Startside()
        {
            InitializeComponent();
            OpdaterGrid();
        }

        private void KnapOpretBruger_Click(object sender, EventArgs e) { new Opret_bruger().ShowDialog(); }

        private void KnapTilfoejData_Click(object sender, EventArgs e)
        {
            TilfoejData tilfoejdata = new TilfoejData();
            tilfoejdata.ShowDialog();
            tilfoejdata.Dispose();
            OpdaterGrid();
        }

        private void KnapOpdater_Click(object sender, EventArgs e) { OpdaterGrid(); }

        private void OpdaterGrid()
        {
            DataSet ds = Connection.grid();

            if (ds == null)
                MessageBox.Show("Something went wrong please try again later");
            else
            {
                Gridview.DataSource = ds;
                Gridview.DataMember = "*";
            }
        }

        private void KnapNulstil_Click(object sender, EventArgs e) { new Nulstil().ShowDialog(); }
    }
}