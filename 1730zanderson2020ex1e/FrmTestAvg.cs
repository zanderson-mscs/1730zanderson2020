﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730zanderson2020ex1e
{
    public partial class frmTestAvg : Form
    {
        public frmTestAvg()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTest1.Text = "0.00";
            txtTest2.Text = "0.00";
            txtTest3.Text = "0.00";
            txtAverage.Text = "0.00";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtAverage.Text = (
                (Convert.ToDecimal(txtTest1.Text) +
                 Convert.ToDecimal(txtTest2.Text) +
                 Convert.ToDecimal(txtTest3.Text) )
                 / 3

                ).ToString("0.00");
        }
    }
}
