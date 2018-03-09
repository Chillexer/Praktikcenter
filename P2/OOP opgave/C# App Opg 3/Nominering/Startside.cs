using System;
using System.Windows.Forms;

namespace Nominering
{
    public partial class Startside : Form
    {
        public Startside()
        {
            InitializeComponent();
        }
        Connection Connect;

        private void btnLogin_Click(object sender, EventArgs e) //denne metode tjekker om koden og brugernavnet er korrekt og hvis ikke viser den en besked
        {
            Connect = new Connection(username.Text, password.Text, "192.168.0.37");
            if (Connect.ConnWorking)
            {
                btnCreate.Enabled = true;
                btnDelete.Enabled = true;
                btnLogin.Enabled = false;
                btnLogOut.Enabled = true;
                btnReload.Enabled = true;
                username.Enabled = false;
                password.Enabled = false;
                password.Text = null;
                Grid.Enabled = true;
                Grid.DataSource = Connection.Reload();
            }
            else
            {
                MessageBox.Show(Connect.ex.Message);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)//denne metode disabler knapperne der ikke er nødvendige og logger personen af sql serveren
        {
            btnCreate.Enabled = false;
            btnDelete.Enabled = false;
            btnLogin.Enabled = true;
            btnLogOut.Enabled = false;
            btnReload.Enabled = false;
            username.Enabled = true;
            password.Enabled = true;
            Grid.Enabled = false;
            Grid.DataSource = null;
            Connect = null;
        }

        private void btnReload_Click(object sender, EventArgs e)//denne metode reloader dataene fra sql serveren
        { 
            Grid.DataSource = Connection.Reload();
        }

        private void btnDelete_Click(object sender, EventArgs e)//denne metode laver et nyt vindue kaldet DeleteForm og reloader derefter data
        {
            new DeleteForm().ShowDialog();
            Grid.DataSource = Connection.Reload();
        }

        private void btnCreate_Click(object sender, EventArgs e)//denne metode laver et nyt vindue kaldet Insert og reloader derefter data
        {
            new Insert().ShowDialog();
            Grid.DataSource = Connection.Reload();
        }
    }
}
