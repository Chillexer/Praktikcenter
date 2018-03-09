using System;
using System.Windows.Forms;

namespace GeoTema
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void knaplogin_Click(object sender, EventArgs e)
        {
            //Forbindelse på samme netværk
            Connection db = new Connection(txtusername.Text, txtpassword.Text, "WIN-0HU73SKL7S9");

            //Gemmer exception fra login
            Exception exception = db.Login();

            //Der tjekkes om der opstod en fejl ved oprettelse af forbindelse til serveren
            if (exception != null) MessageBox.Show(exception.Message);
            else
            {
                //Skjuler denne side
                Visible = false;

                //Startside startside = new Startside();
                new Startside().ShowDialog();

                //Lukker siden
                Close();
            }
        }
    }
}