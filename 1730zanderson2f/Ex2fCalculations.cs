using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1730zanderson2f
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;
            // #1: if
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            return discountPercent.ToString("n2");
        }

        public static string Calc02(string input)
        {
            // #2: if {block}
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            discountPercent = 0.0m;
            subtotal = Decimal.Parse(input);
            string status = "Standard rate: ";
            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: " + discountPercent.ToString("n2");
            }
            return status;
        }

        public static string Calc03(string input)
        {
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;
            discountPercent = 0.0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m)
                discountPercent = .2m;
            else
                discountPercent = .1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            // #4 if else if
            decimal discountPercent = 0.0m;
            decimal subtotal = 0.0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m && subtotal < 200)
                discountPercent = 0.2m;
            else if (subtotal >= 200 && subtotal < 300)
                discountPercent = 0.3m;
            else if (subtotal >= 300)
                discountPercent = .4m;
            else
                discountPercent = .1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            // #5 Better range test
            decimal discountPercent = 0.0m;
            decimal subtotal = 0.0m;
            discountPercent = 0.0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 300m)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = .2m;
            else
                discountPercent = .1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            // #6 Nested if
            decimal discountPercent = 0.0m;
            decimal subtotal = 0.0m;
           
            subtotal = Decimal.Parse(inputA);
            string customerType = inputB;

            if (customerType == "R")
            {
                if (subtotal >= 100)
                    discountPercent = .2m;
                else
                    discountPercent = .1m;
            }
            else
                discountPercent = .4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            // #7 Validate input: non-empty string
            decimal etherium = 0.0m;
            if (input != "")
            {
                decimal dollars = Decimal.Parse(input);
                etherium = 200 * dollars;
                return etherium.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            decimal shipping = 0.0m;
            decimal price = Decimal.Parse(inputA);
            decimal quantity = Decimal.Parse(inputB);

            if (inputA != "" && inputB != "")
            {
                shipping = quantity * price;
                
                if (shipping < 50)
                {
                    shipping = shipping + 5;
                    return shipping.ToString("n2");
                }
                else
                return shipping.ToString("n2");
                //return "Valid input";
            }
            else
            return "Invalid input";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            decimal a = decimal.Parse(inputA);
            decimal b = decimal.Parse(inputB);
            if (inputA != "" && inputB != "")
            {
                if (a < b)
                {
                    return "Invalid input";
                }
                else if (a >= b)
                {
                    decimal result = (b - a) * .1m;
                    return result.ToString("n2");
                }
            }
            return "Invalid input";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            decimal result = 0.0m;
            if (inputA != "" && inputB != "")
            {
                decimal a = decimal.Parse(inputA);
                decimal b = decimal.Parse(inputB);
                if (a > 0.0m && b > 0.0m)
                {
                    if (a > b)
                    {
                        result = a / b;
                    }
                    else
                    {
                        result = b / a;
                    }
                }
                else
                return "Invalid input";
            }
            return "Invalid input"; 
        }
    }
}
