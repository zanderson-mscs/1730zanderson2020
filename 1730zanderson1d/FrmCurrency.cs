using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730zanderson1d
{
    public partial class frmCurrency : Form
    {
        public frmCurrency()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtAmountBrazil.Text = "0.00";
            txtAmountFrance.Text = "0.00";
            txtAmountMozambique.Text = "0.00";
            txtRateAustralia.Text = "0.727701";
            txtRateBrazil.Text = "0.189030";
            txtRateFrance.Text = "1.18033";
            txtRateMozambique.Text = "0.0139615";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtAmountAustralia_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtRateAustralia_TextChanged(object sender, EventArgs e)
        {

        }

        private void AustraliaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
            (Convert.ToDecimal(txtAmountAustralia.Text)) * (Convert.ToDecimal(txtRateAustralia.Text))
             ).ToString("0.00");
        }

        private void BrazilTextChanged(object sender, EventArgs e)
        {
            txtUSDBrazil.Text = (
            (Convert.ToDecimal(txtAmountBrazil.Text)) * (Convert.ToDecimal(txtRateBrazil.Text))
             ).ToString("0.00");
        }

        private void FranceTextChanged(object sender, EventArgs e)
        {
            txtUSDFrance.Text = (
            (Convert.ToDecimal(txtAmountFrance.Text)) * (Convert.ToDecimal(txtRateFrance.Text))
             ).ToString("0.00");
        }

        private void MozambiqueTextChanged(object sender, EventArgs e)
        {
            txtUSDMozambique.Text = (
            (Convert.ToDecimal(txtAmountMozambique.Text)) * (Convert.ToDecimal(txtRateMozambique.Text))
             ).ToString("0.00");
        }

        private void txtUSDTextChanged(object sender, EventArgs e)
        {
            txtUSDTotal.Text = (
             Convert.ToDecimal(txtUSDAustralia.Text) +
             Convert.ToDecimal(txtUSDBrazil.Text) +
             Convert.ToDecimal(txtUSDFrance.Text) +
             Convert.ToDecimal(txtUSDMozambique.Text) 
             ).ToString("0.00");
        }
    }
}
