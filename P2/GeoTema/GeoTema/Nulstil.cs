using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeoTema
{
    public partial class Nulstil : Form
    {
        public Nulstil()
        {
            InitializeComponent();

            //Kalder metoden Users når siden åbnes
            Users();
        }

        private void Knapnulstil_Click(object sender, EventArgs e)
        {
            //Kalder metoden Nulstil i brugere
            Brugere.Nulstil(cboxlogins.Text);
        }

        private void Users()
        {
            //En liste som indeholder alle brugere bliver lavet
            List<string> user_list = Connection.Get("select * from fødselsrate_2017.sys.database_principals WHERE type = 'S' and default_schema_name = 'dbo';");
            foreach (var item in user_list) if (Connection.name.ToUpper() != item.ToUpper()) cboxlogins.Items.Add(item);
        }
    }
}