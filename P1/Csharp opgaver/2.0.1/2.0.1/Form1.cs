using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._0._1
{
    public partial class Form1 : Form
    {
        int tal1, tal2, Nr = 1;
        string op;

        private void Tbdata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Nr == 1 || Nr == 3)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^+^\-^/^*^\b^]"))
                {
                    // Stop the character from being entered into the control since it is illegal.
                    e.Handled = true;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            if (Nr == 1)
            {
                tal1 = Convert.ToInt16(Tbdata.Text);
                Tbdata.Text = "";
                Nr = 2;
                Lbdata.Text = "Operator";
                Tbdata.MaxLength = 1;
            }
            else if (Nr == 2)
            {
                op = Tbdata.Text;
                Tbdata.Text = "";
                Nr = 3;
                Lbdata.Text = "Andet tal";
                Tbdata.MaxLength = 20000;
            }
            else if (Nr == 3)
            {
                tal2 = Convert.ToInt16(Tbdata.Text);
                Tbdata.Text = "";
                if (op == "+")
                {
                    Tbsum.Text = Convert.ToString(tal1 + tal2);
                }
                else if (op == "-")
                {
                    Tbsum.Text = Convert.ToString(tal1 - tal2);
                }
                else if (op == "/")
                {
                    if ((tal1 != 0) || (tal2 != 0))
                    {
                        Tbsum.Text = Convert.ToString(tal1 / tal2);
                    }
                    else if ((tal1 == 0) || (tal2 == 0))
                    {

                        Tbsum.Text = "Der er sket en fejl";
                        Environment.Exit(2000);
                    }
                }
                else if (op == "*")
                {
                    Tbsum.Text = Convert.ToString(tal1 * tal2);
                }
                Nr = 1;
                Lbdata.Text = "Første tal";
            }
        }
    }
}
