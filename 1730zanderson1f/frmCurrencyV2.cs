using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730zanderson1f
{
    public partial class frmCurrencyV2 : Form
    {
        public frmCurrencyV2()
        {
            InitializeComponent();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnFrance.BackgroundImage = picFranceDim.Image;
            btnMozambique.BackgroundImage = picMozambiqueDim.Image;
            lblCurrency.Text = "Australian Dollar:";
            txtRate.Text = "0.727701";
            txtAmount.Text = "0.00";
            
        }

        private void btnBrazil_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBrazil.BackgroundImage = picBrazil.Image;
            btnFrance.BackgroundImage = picFranceDim.Image;
            btnMozambique.BackgroundImage = picMozambiqueDim.Image;
            lblCurrency.Text = "Brazilian Real:";
            txtRate.Text = "0.189030";
            txtAmount.Text = "0.00";
        }

        private void btnFrance_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnFrance.BackgroundImage = picFrance.Image;
            btnMozambique.BackgroundImage = picMozambiqueDim.Image;
            lblCurrency.Text = "French Euro:";
            txtRate.Text = "1.18033";
            txtAmount.Text = "0.00";
            
        }

        private void btnMozambique_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnFrance.BackgroundImage = picFranceDim.Image;
            btnMozambique.BackgroundImage = picMozambique.Image;
            lblCurrency.Text = "Mozambique Metical:";
            txtRate.Text = "0.0139615";
            txtAmount.Text = "0.00";
            
        }

        private void frmCurrencyV2_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnFrance.BackgroundImage = picFranceDim.Image;
            btnMozambique.BackgroundImage = picMozambiqueDim.Image;
            lblCurrency.Text = "Australian Dollar:";
            txtRate.Text = "0.727701";
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtAmount.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtUSDollars.Text = "0.00";
            lblEquation.Text = "";
            txtAmount.Focus();
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnFrance.BackgroundImage = picFranceDim.Image;
            btnMozambique.BackgroundImage = picMozambiqueDim.Image;
            lblCurrency.Text = "Australian Dollar:";
            txtRate.Text = "0.727701";
            txtAmount.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtUSDollars.Text = "0.00";
            lblEquation.Text = "";
            txtAmount.Focus();
        }

        private void txtVariable_TextChanged(object sender, EventArgs e)
        {
            txtUSDollars.Text = (
               Convert.ToDecimal(txtAmount.Text) * Convert.ToDecimal(txtRate.Text)
               ).ToString("0.00");
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmount_Enter(object sender, EventArgs e)
        {
            txtAmount.SelectAll();
        }

        private void txtRate_Enter(object sender, EventArgs e)
        {
            txtRate.SelectAll();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDollars.Text) + Convert.ToDecimal(txtTotalUSD.Text)

                ).ToString("0.00");

            lblEquation.Text = lblEquation.Text + " + " + txtTotalUSD.Text;
            txtAmount.Focus();

        }

     
    }
}
