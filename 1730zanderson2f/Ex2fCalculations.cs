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
            return "";
        }

        public static string Calc05(string input)
        {
            // #5 Better range test
            return "";
        }

        public static string Calc06(string inputA, string inputB)
        {
            // #6 Nested if
            return "";
        }

        public static string Calc07(string input)
        {
            // #7 Validate input: non-empty string
            return "";
        }

        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            return "";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            return "";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            return "";
        }
    }
}
