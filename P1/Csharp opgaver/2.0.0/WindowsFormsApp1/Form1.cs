using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double tal1, tal2;
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            try
            {
                tal1 = Convert.ToDouble(tbtal1.Text);
                tal2 = Convert.ToDouble(tbtal2.Text);
                if (tbop.Text == "+")
                {
                    tbsum.Text = Convert.ToString(tal1 + tal2);
                }
                else if (tbop.Text == "-")
                {
                    tbsum.Text = Convert.ToString(tal1 - tal2);
                }
                else if (tbop.Text == "/")
                {
                    tbsum.Text = Convert.ToString(tal1 / tal2);
                }
                else if (tbop.Text == "*")
                {
                    tbsum.Text = Convert.ToString(tal1 * tal2);
                }
                else
                {
                    tbsum.Text = "Fejl";
                }
            }
            catch (System.FormatException)
            {
                tbsum.Text = "fejl";
                tbtal1.Text = "";
                tbtal2.Text = "";

            }
            
            
                
        }
    }
}
