﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730zanderson20201g
{
    public partial class frm1g : Form
    {
        public frm1g()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // 1
            textBox1C.Text = textBox1A.Text + textBox1B.Text;
            // 2
            textBox2C.Text = (
                    Convert.ToInt32(textBox2A.Text) + Convert.ToInt32(textBox2B.Text)
                ).ToString();
            // 3
            textBox3C.Text = (
                    Convert.ToInt32(textBox3A.Text + textBox3B.Text)
                ).ToString();
            // 4
            textBox1A.Text = (
                Convert.ToInt32(textBox1B.Text).ToString() + textBox1C.Text
                ).ToString();
            // 5
            textBox2A.Text = textBox2B.Text + Convert.ToInt32(textBox2C.Text).ToString();
            // 6
            textBox3A.Text = (
                    textBox3B.MaxLength + textBox3C.SelectionLength
                ).ToString();
            // 7
            textBox1B.Text = (
                    Convert.ToInt32(textBox1A.Text) - Convert.ToInt32(textBox1C.Text)
                ).ToString("n2");
            // 8
            textBox2B.Text = (
                    Convert.ToDecimal(textBox1A.Text) * Convert.ToDecimal(textBox1C.Text)
                ).ToString("n2");
            // 9
            textBox3B.Text = (
                    Convert.ToDecimal(textBox3A.Text) / Convert.ToDecimal(textBox3C.Text)
                ).ToString("n2");
        }
    }
}
