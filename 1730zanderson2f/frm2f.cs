using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730zanderson2f
{
    public partial class frm2f : Form
    {
        public frm2f()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            // #1: if
            //subtotal = Decimal.Parse(txtInput1.Text);
            //if (subtotal >= 100m)
            //    discountPercent = 0.2m;
            txtResult1.Text = Ex2fCalculations.Calc01(txtInput1.Text);

            // #2
            //discountPercent = 0.0m;
            //subtotal = Decimal.Parse(txtInput2.Text);
            //string status = "Standard rate: ";
            //if (subtotal >= 100m)
            //{
            //    discountPercent = 0.2m;
            //    status = "Bulk rate: ";
            //}
            txtResult2.Text = Ex2fCalculations.Calc02(txtInput2.Text);

            // #3 if else
            //discountPercent = 0.0m;
            //subtotal = Decimal.Parse(txtInput3.Text);
            //if (subtotal >= 100m)
            //    discountPercent = .2m;
            //else
            //    discountPercent = .1m;
            txtResult3.Text = Ex2fCalculations.Calc03(txtInput3.Text);

            // #4 if else if
            discountPercent = 0.0m;
            subtotal = Decimal.Parse(txtInput4.Text);
            if (subtotal >= 100m && subtotal < 200)
                discountPercent = 0.2m;
            else if (subtotal >= 200 && subtotal < 300)
                discountPercent = 0.3m;
            else if (subtotal >= 300)
                discountPercent = .4m;
            else
                discountPercent = .1m;
            txtResult4.Text = discountPercent.ToString("n2");

            // #5 better range
            discountPercent = 0.0m;
            subtotal = Decimal.Parse(txtInput5.Text);
            if (subtotal >= 300m )
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = .2m;
            else
                discountPercent = .1m;
            txtResult5.Text = discountPercent.ToString("n2");

            // #6 nested if statements
            discountPercent = 0.0m;
            subtotal = Decimal.Parse(txtInput6.Text);
            string customerType = txtInput6b.Text;

            if (customerType == "R")
            {
                if (subtotal >= 100)
                    discountPercent = .2m;
                else
                    discountPercent = .1m;
            }
            else
                discountPercent = .4m;
            txtResult6.Text = discountPercent.ToString("n2");




        }
    }
}
