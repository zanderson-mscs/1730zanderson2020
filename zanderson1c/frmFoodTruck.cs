using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zanderson1c
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtOkraSubtotal.Text = (
                5.0m * Convert.ToDecimal(txtOkra.Text)
                  ).ToString("0.00");

            txtCorndogSubtotal.Text = (
                6.0m * Convert.ToDecimal(txtCorndog.Text)
                    ).ToString("0.00");

            txtPretax.Text = (
                Convert.ToDecimal(txtCorndogSubtotal.Text) + Convert.ToDecimal(txtOkraSubtotal.Text)
                ).ToString("0.00");

            txtTotal.Text = (
               ( Convert.ToDecimal(txtPretax.Text) * Convert.ToDecimal(txtTax.Text) ) +
               Convert.ToDecimal(txtPretax.Text)

                ).ToString("0.00");

            btnClear.Focus();
        }

        private void txtOkraSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorndogSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOkra.Text = "0";
            txtCorndog.Text = "0";
            txtOkraSubtotal.Text = "0";
            txtCorndogSubtotal.Text = "0";
            txtPretax.Text = "";
            txtTotal.Text = "";

            txtOkra.Focus();
        }
    }
}
