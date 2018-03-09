using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbdata_TextChanged(object sender, EventArgs e)
        {

        }

        private void btsum_Click(object sender, EventArgs e)
        {
            string math = tbdata.Text;
            tbsum.Text = new DataTable().Compute(math, null).ToString();
        }

        private void tbdata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btsum.PerformClick();
            }
        }

        private void tbdata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^+^\-^/^*^\b^0-9^(^)^]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
        }
    }
}
