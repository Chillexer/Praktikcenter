using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoTema
{
    public partial class Opret_bruger : Form
    {
        public Opret_bruger()
        {
            InitializeComponent();
        }

        private void knapopret_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "" || comborettigheder.Text == "")
                MessageBox.Show("Alle felter skal være udfyldt");
            else
            {
                Brugere.Opret_bruger(txtusername.Text, txtpassword.Text, comborettigheder.Text);
                Close();
            }
        }
    }
}