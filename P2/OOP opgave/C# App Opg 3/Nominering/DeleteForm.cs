using System;
using System.Data;
using System.Windows.Forms;


namespace Nominering
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
            GetID();
        }
//denne metode sørger for at slette en række og samtidig checke om et id er valgt
        private void btnDelete_Click(object sender, EventArgs e) 
        {
            if (IDBox.SelectedItem == null)
            {
                MessageBox.Show("Vælg venligst et ID");
            }
            else
            {
                int N;
                if(IDBox.SelectedIndex == IDBox.Items.Count - 1)
                {
                    N = Convert.ToInt32(IDBox.Items[IDBox.Items.Count - 1]);
                }
                else
                {
                    N = Convert.ToInt32(IDBox.Items[IDBox.Items.Count - 1]) + 1;
                }

                if(Connection.Delete(Convert.ToInt32(IDBox.SelectedItem.ToString()), N) == null)
                {
                    this.Close();
                }
                MessageBox.Show("Der er sket en fejl");
            }
        }
//denne metode henter alle ID i film tabellen og sætter dem ind i en selector box
        private void GetID()
        {
            DataTable dt = Connection.Reload();
            foreach (DataRow row in dt.Rows)
                IDBox.Items.Add((int)row["ID"]);
        }
    }
}
