﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1730zanderson3b
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            //0
            try
            {
                decimal subtotal = Decimal.Parse(this.inputTextBox0a.Text);
                decimal discountPercent = Ex3bCalculations.GetDiscountPercent(499m);
                resultTextBox0.Text = discountPercent.ToString("f3");
            }
            catch
            {
                resultTextBox0.Text = "";
                MessageBox.Show("Invalid inuput: " + this.inputTextBox0a.Text);
            }

            //1 Calculate discountPercent using output argument
            try
            {
                decimal subtotal = Decimal.Parse(this.inputTextBox0a.Text);
                decimal discountPercent;
                Ex3bCalculations.GetDiscountPercent(subtotal, out discountPercent);
                resultTextBox1.Text = discountPercent.ToString("f3");
            }
            catch
            {
                resultTextBox1.Text = "";
                MessageBox.Show("Invalid inuput: " + this.inputTextBox1a.Text);
            }

            //2
            try
            {
                int months = Int32.Parse(this.inputTextBox2a.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputTextBox2b.Text);
                decimal monthlyInterestRate = Decimal.Parse(this.inputTextBox2c.Text);
                decimal futureValue = Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months );
                resultTextBox2.Text = futureValue.ToString("c2");
            }
            catch
            {
                resultTextBox2.Text = "";
                MessageBox.Show("Invalid input: \n" 
                    + this.inputTextBox2a.Text + "\n"
                    + this.inputTextBox2a.Text + "\n"
                    + this.inputTextBox2c.Text + "\n" );
            }

            //3 Calculate futureValue using ref argument
            try
            {
                int months = Int32.Parse(this.inputTextBox2a.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputTextBox2b.Text);
                decimal monthlyInterestRate = Decimal.Parse(this.inputTextBox2c.Text);
                decimal futureValue = 0;
                    Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months, ref futureValue);
                resultTextBox2.Text = futureValue.ToString("c2");
            }
            catch
            {
                resultTextBox2.Text = "";
                MessageBox.Show("Invalid input: \n"
                    + this.inputTextBox2a.Text + "\n"
                    + this.inputTextBox2b.Text + "\n"
                    + this.inputTextBox2c.Text + "\n");
            }


            //4 F to C
            try
            {
                double input = Double.Parse(this.inputTextBox4.Text);
                double celcius = Ex3bCalculations.FahrenheitToCelsius(input);
                resultTextBox4.Text = celcius.ToString("f1");
            }
            catch
            {
                resultTextBox4.Text = "";
                MessageBox.Show("Invalid input: \n"
                    + this.inputTextBox4.Text);
            }

            //5
            try
            {
                double celcius = Double.Parse(this.inputTextBox5a.Text);
                Ex3bCalculations.CelciusToFahrenheit(celcius, out double fahrenheit);
                resultTextBox1.Text = fahrenheit.ToString("f3");
            }
            catch
            {
                resultTextBox1.Text = "";
                MessageBox.Show("Invalid inuput: " + this.inputTextBox1a.Text);
            }

            //6
            try
            {
                decimal hours = Decimal.Parse(this.inputTextBox6a.Text);
                decimal rate = Decimal.Parse(this.inputTextBox6b.Text);
                this.resultTextBox6.Text = Ex3bCalculations.GrossPay(hours, rate).ToString();
            }
            catch
            {
                resultTextBox6.Text = "";
                MessageBox.Show("Invalid input: \n"
                    + this.inputTextBox6a.Text + "\n"
                    + this.inputTextBox6b.Text);
            }

            //7 Total Hours
            try
            {
                this.resultTextBox7.Text =
                     Ex3bCalculations.TotalHours(this.inputTextBox7a.Text).ToString("n2");
            }
            catch
            {
                resultTextBox7.Text = "";
                MessageBox.Show("Invalid input: \n"
                    + this.inputTextBox7a.Text );
            }

            //8
            try
            {
                decimal rate = Decimal.Parse(this.inputTextBox8b.Text);
                this.resultTextBox8.Text =
                     Ex3bCalculations.GrossPay(this.inputTextBox8a.Text, rate).ToString("n2");
            }
            catch
            {
                resultTextBox8.Text = "";
                MessageBox.Show("Invalid input: \n"
                    + this.inputTextBox8a.Text + "\n"
                    + this.inputTextBox8b.Text);
            }

        }

         
    }
}
