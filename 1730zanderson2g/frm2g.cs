using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730zanderson2g
{
    public partial class frm2g : Form
    {
        public frm2g()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //1a
            txtResultSwitch01.Text = Ex2gCalculations.Switch01(txtInput1a.Text);

            //1b
            txtResultIf01.Text = Ex2gCalculations.If01(txtInput1a.Text);

            //1c if else if
            txtResultElseIf01.Text = Ex2gCalculations.ElseIf01(txtInput1a.Text);

            //1d
            txtResultNestedIfElse01.Text = Ex2gCalculations.NestedIfElse01(txtInput1a.Text);

            //1e
            txtResultSwitchDefault01.Text = Ex2gCalculations.SwitchDefault01(txtInput1a.Text);

            //1f
            txtResultIfDefault01.Text = Ex2gCalculations.IfDefault01(txtResultIfDefault01.Text);

            //1g
            txtResultElseIfDefault01.Text = Ex2gCalculations.ElseIfDefault01(txtResultElseIfDefault01.Text);

            //1h
            txtResultNestedIfDefault01.Text = Ex2gCalculations.NestedIfElseDefault01(txtResultNestedIfDefault01.Text);

            //2a
            txtResultSwitch02.Text = Ex2gCalculations.Switch02(txtResultSwitch02.Text);

            //2b
            txtResultIf02.Text = Ex2gCalculations.If02(txtResultIf02.Text);

            //2c
            txtResultElseIf02.Text = Ex2gCalculations.ElseIf02(txtResultElseIf02.Text);

            //2d 
            txtResultNestedIfElse02.Text = Ex2gCalculations.NestedIfElse02(txtResultNestedIfElse02.Text);



        }
    }
}
