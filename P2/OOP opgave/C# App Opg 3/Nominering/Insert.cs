using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nominering
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)//denne metode tjekker at alle felter er udfyldt og derefter opretter den en ny række i tabelen
        {
            if(Titel.Text.Length == 0 || Year.SelectedItem == null || Genre.Text.Length == 0 || Skuespillere.Text.Length == 0)
            {
                MessageBox.Show("Udfyld venligst alle felter");
            }
            else
            {
                List<string> values = new List<string>();
                values.Add(Titel.Text);
                values.Add(Year.SelectedItem.ToString());
                values.Add(Genre.Text);
                values.Add(Skuespillere.Text);
                if (Connection.Insert(values) == null)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Der skete en fejl");
                }
                
            }
        }
    }
}
