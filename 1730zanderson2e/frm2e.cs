using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730zanderson2e
{
    public partial class frm2e : Form
    {
        public frm2e()
        {
            InitializeComponent();
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtResult01.Text = "";
            txtResult02.Text = "";
            txtResult03.Text = "";
            txtResult03b.Text = "";
            txtResult04.Text = "";
            txtResult04b.Text = "";
            txtResult05.Text = "";
            txtResult05b.Text = "";
            txtResult06.Text = "";
            txtResult06b.Text = "";
            txtResult07.Text = "";
            txtResult08.Text = "";
            txtResult09.Text = "";
            txtResult09b.Text = "";
            txtResult10.Text = "";

            //01
            decimal subtotal = Convert.ToDecimal(txtInput01a.Text);
            txtResult01.Text = (
                LogicalOperations.q01(subtotal)
                ).ToString();

            //02
            int timeInService = Convert.ToInt32(txtInput02a.Text);
            txtResult02.Text = (
                LogicalOperations.q02(timeInService)
                 ).ToString();

            //03 - 06 initial
            bool isValid = Convert.ToBoolean(txtInput03a.Text);
            int years = Convert.ToInt32(txtInput03c.Text);

            //03
            int counter = Convert.ToInt32(txtInput03b.Text);
            txtResult03.Text = (
                LogicalOperations.q03(isValid, years, counter)
                ).ToString();
            txtResult03b.Text = counter.ToString();

            //04
            counter = Convert.ToInt32(txtInput03b.Text);
            txtResult04.Text = (
               LogicalOperations.q04(isValid, years, counter)
                ).ToString();
            txtResult04b.Text = counter.ToString();

            //05
            counter = Convert.ToInt32(txtInput03b.Text);
            txtResult05.Text = (
                LogicalOperations.q05(isValid, years, counter)
                ).ToString();
            txtResult05b.Text = counter.ToString();

            //06
            counter = Convert.ToInt32(txtInput03b.Text);
            txtResult06.Text = (
                LogicalOperations.q05(isValid, years, counter)
                ).ToString();
            txtResult06b.Text = counter.ToString();

            //07
            DateTime startDate = Convert.ToDateTime(txtInput07a.Text);
            DateTime expirationDate = Convert.ToDateTime(txtInput07b.Text);
            DateTime date = Convert.ToDateTime(txtInput07c.Text);
            isValid = Convert.ToBoolean(txtInput07d.Text);

            txtResult07.Text = (
                LogicalOperations.q07(startDate, expirationDate,  date,  isValid)
                ).ToString();

            //08
            decimal thisYTD = Convert.ToDecimal(txtInput08a.Text);
            decimal lastYTD = Convert.ToDecimal(txtInput08b.Text);
            string empType = txtInput08c.Text;
            int startYear = Convert.ToInt32(txtInput08d.Text);
            int currentYear = Convert.ToInt32(txtInput08e.Text);
            txtResult08.Text = (
                LogicalOperations.q08(thisYTD, lastYTD, empType, startYear, currentYear)
                ).ToString();

            //09
            counter = Convert.ToInt32(txtInput09a.Text);
            years = Convert.ToInt32(txtInput09b.Text);
            txtResult09.Text = (
                !(counter++ >= years)
                ).ToString();
            txtResult09b.Text = counter.ToString();

            //10
            int a = Convert.ToInt32(txtInput10a.Text);
            int b = Convert.ToInt32(txtInput10b.Text);
            int c = Convert.ToInt32(txtInput10c.Text);
            int d = Convert.ToInt32(txtInput10d.Text);

            txtResult10.Text = (
                LogicalOperations.q10(a, b, c, d)
                ).ToString();

            //11, 12, 13
            bool member = Convert.ToBoolean(txtInput11a.Text);
            decimal price = Convert.ToInt32(txtInput11b.Text);
            float weight = Convert.ToSingle(txtInput11c.Text);
          


            txtResult11.Text = (
                LogicalOperations.q11(member, price, weight)
                ).ToString();

            //12
            member = Convert.ToBoolean(txtInput12a.Text);
            price = Convert.ToInt32(txtInput12b.Text);
            weight = Convert.ToSingle(txtInput12c.Text);

            txtResult12.Text = (
                LogicalOperations.q12(member, price, weight)
                ).ToString();

            //13
            string shipState = Convert.ToString(txtInput13a.Text);
            string itemType = Convert.ToString(txtInput13b.Text);

            txtResult13.Text = (
                LogicalOperations.q13(shipState, itemType)
                ).ToString();

        }

        private void frm2e_Load(object sender, EventArgs e)
        {

        }

        private void txtInput13a_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
