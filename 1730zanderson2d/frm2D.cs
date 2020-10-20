using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730zanderson2d
{
    public partial class frm2D : Form
    {
        public frm2D()
        {
            InitializeComponent();
        }

        private void lbl8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSetPassValues_Click(object sender, EventArgs e)
        {
            txtInput1.Text = "Frank";
            txtInput2.Text = "";
            txtInput3.Text = "2.3";
            txtInput4.Text = "false";
            txtInput5A.Text = "2";
            txtInput5B.Text = "2";
            txtInput6.Text = "xyz";
            txtInput7.Text = "1";
            txtInput8A.Text = "1";
            txtInput8B.Text = "2";
            txtInput9.Text = "500";
            txtInput10A.Text = "2";
            txtInput10B.Text = "3";

        }

        private void btnSetFailValues_Click(object sender, EventArgs e)
        {
            txtInput1.Text = "xyz";
            txtInput2.Text = "xyz";
            txtInput3.Text = "2.4";
            txtInput4.Text = "true";
            txtInput5A.Text = "2";
            txtInput5B.Text = "3";
            txtInput6.Text = "Jones";
            txtInput7.Text = "0";
            txtInput8A.Text = "1";
            txtInput8B.Text = "1";
            txtInput9.Text = "499";
            txtInput10A.Text = "4";
            txtInput10B.Text = "3";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txt1Result.Text = "fail";
            txt2Result.Text = "fail";
            txt3Result.Text = "fail";
            txt4Result.Text = "fail";
            txt5Result.Text = "fail";
            txt6Result.Text = "fail";
            txt7Result.Text = "fail";
            txt8Result.Text = "fail";
            txt9Result.Text = "fail";
            txt10Result.Text = "fail";

            if (txtInput1.Text == "Frank")
                txt1Result.Text = "success";

            if (txtInput2.Text == "")
                txt2Result.Text = "success";

            decimal val3 = Convert.ToDecimal(txtInput3.Text);
            if (val3 == 2.3m)
                txt3Result.Text = "success";

            bool val4 = Convert.ToBoolean(txtInput4.Text);
            if (val4 == false)
                txt4Result.Text = "success";

            if (txtInput5A.Text == txtInput5B.Text )
                txt5Result.Text = "success";

            if (txtInput6.Text != "Jones")
                txt6Result.Text = "success";

            decimal val7 = Convert.ToDecimal(txtInput7.Text);
            if (val7 > 0m )
                txt7Result.Text = "success";

            decimal val8A = Convert.ToDecimal(txtInput8A.Text);
            decimal val8B = Convert.ToDecimal(txtInput8B.Text);
            if (val8A < val8B)
                txt8Result.Text = "success";

            decimal val9 = Convert.ToDecimal(txtInput9.Text);
            if (val9 >= 500m )
                txt9Result.Text = "success";

            decimal val10A = Convert.ToDecimal(txtInput10A.Text);
            decimal val10B = Convert.ToDecimal(txtInput10B.Text);
            if (val10A <= val10B )
                txt10Result.Text = "success";
        }
    }

}
