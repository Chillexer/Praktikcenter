using System;
using System.Windows.Forms;

namespace GeoTema
{
    public partial class TilfoejData : Form
    {
        private static Connection db = new Connection();

        public TilfoejData() { InitializeComponent(); }

        private void knaptilfoej_Click(object sender, EventArgs e)
        {
            if (txtland.Text.Equals("") || txtverdensdel.Text.Equals("") || txtrang.Text.Equals("") || txtfrate.Text.Equals(""))
            {
                MessageBox.Show("Alle felter skal være udfyldt");
                return;
            }

            string cmd = "" +
                "INSERT INTO Land VALUES" +
                $" ('{txtland.Text}','{txtverdensdel.Text}');" +
                "INSERT INTO Rang VALUES" +
                $" ('{txtrang.Text}','{txtfrate.Text}');";

            db.Send(cmd);
            Close();
        }

        private void txtrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
        }

        private void txtfrate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                || ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1));
        }
    }
}