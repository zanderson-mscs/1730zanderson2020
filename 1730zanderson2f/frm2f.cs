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
            //discountPercent = 0.0m;
            //subtotal = Decimal.Parse(txtInput4.Text);
            //if (subtotal >= 100m && subtotal < 200)
            //    discountPercent = 0.2m;
            //else if (subtotal >= 200 && subtotal < 300)
            //    discountPercent = 0.3m;
            //else if (subtotal >= 300)
            //    discountPercent = .4m;
            //else
            //    discountPercent = .1m;
            txtResult4.Text = Ex2fCalculations.Calc04(txtInput4.Text);

            // #5 better range
            //discountPercent = 0.0m;
            //subtotal = Decimal.Parse(txtInput5.Text);
            //if (subtotal >= 300m )
            //    discountPercent = 0.4m;
            //else if (subtotal >= 200m)
            //    discountPercent = 0.3m;
            //else if (subtotal >= 100m)
            //    discountPercent = .2m;
            //else
            //    discountPercent = .1m;
            txtResult5.Text = Ex2fCalculations.Calc05(txtInput5.Text);

            // #6 nested if statements
            //discountPercent = 0.0m;
            //subtotal = Decimal.Parse(txtInput6.Text);
            //string customerType = txtInput6b.Text;

            //if (customerType == "R")
            //{
            //    if (subtotal >= 100)
            //        discountPercent = .2m;
            //    else
            //        discountPercent = .1m;
            //}
            //else
            //    discountPercent = .4m;
            txtResult6.Text = Ex2fCalculations.Calc06(txtInput6.Text, txtInput6b.Text);

            //7
            txtResult7.Text = Ex2fCalculations.Calc07(txtInput7.Text);

            //8
            txtResult8.Text = Ex2fCalculations.Calc08(txtInput8a.Text, txtInput8b.Text);

            //9
            txtResult9.Text = Ex2fCalculations.Calc09(txtInput9a.Text, txtInput9b.Text);

            //10 
            txtResult10.Text = Ex2fCalculations.Calc10(txtInput10a.Text, txtInput10b.Text);
        }
    }
}
