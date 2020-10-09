using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730zanderson2b
{
    public partial class frm2b : Form
    {
        public frm2b()
        {
            InitializeComponent();
        }

        private void frm2b_Load(object sender, EventArgs e)
        {

        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = Convert.ToDecimal(txtAmountAustralia.Text);
            decimal rateAustralia = Convert.ToDecimal(txtRateAustralia.Text);
            decimal usdAustralia = amountAustralia * rateAustralia;

            decimal amountBrazil = Convert.ToDecimal(txtAmountBrazil.Text);
            decimal rateBrazil = Convert.ToDecimal(txtRateBrazil.Text);
            decimal usdBrazil = amountBrazil * rateBrazil;

            decimal amountFrance = Convert.ToDecimal(txtAmountFrance.Text);
            decimal rateFrance = Convert.ToDecimal(txtRateFrance.Text);
            decimal usdFrance = amountFrance * rateFrance;

            decimal amountMozambique = Convert.ToDecimal(txtAmountMozambique.Text);
            decimal rateMozambique = Convert.ToDecimal(txtRateMozambique.Text);
            decimal usdMozambique = amountMozambique * rateMozambique;

            decimal totalusd = usdAustralia + usdBrazil + usdFrance;

            txtUSDAustralia.Text = usdAustralia.ToString("0.00");
            txtUSDBrazil.Text = usdBrazil.ToString("0.00");
            txtUSDFrance.Text = usdFrance.ToString("0.00");
            txtUSDMozambique.Text = usdMozambique.ToString("0.00");
            txtUSDTotal.Text = totalusd.ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
