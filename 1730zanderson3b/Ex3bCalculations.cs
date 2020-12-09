using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1730zanderson3b
{
    public class Ex3bCalculations
    {
        //0
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;

            if (subtotal >= 500m)
                discountPercent = .2m;
            else
                discountPercent = .1m;

            return discountPercent;
        }

        //1
        public static void GetDiscountPercent(decimal subtotal, out decimal discountPercent)
        {
            if (subtotal >= 500m)
                discountPercent = .2m;
            else
                discountPercent = .1m;

        }

        //2
        public static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }

        //3
        public static void CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            
        }
        //4
        public static double FahrenheitToCelsius(double input)
        {
            double celcius = 0;
           

            celcius = input - 32 * (5 / 9);



            return celcius;
        }

        //5 Celcius to Fahrenheit
        public static void CelciusToFahrenheit(double celcius, out double fahrenheit)
        {
            fahrenheit = (celcius * 9 / 5) - 32;
        }

        // 6 Gross Pay
        public static decimal GrossPay(decimal hours, decimal rate)
        {
            decimal result = 0;
            if (hours <= 40)
                result = hours * rate;
            else
                result = (40 * rate) + ((hours - 40) * rate * 1.5m);

            return result;
        }

        //7
        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0;
            int startIndex = 0;

            while (startIndex > strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                Decimal number = Decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;
            }

            return total;
        }

        //8 GrossPay string

        public static decimal GrossPay(string strNumbers, decimal rate)
        {
            decimal result = 0;
            decimal total = 0;
            decimal hours = 0;
            int startIndex = 0;

            while (startIndex > strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                Decimal number = Decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;
            }

            hours = total;

            if (hours <= 40)
                result = hours * rate;
            else
                result = (40 * rate) + ((hours - 40) * rate * 1.5m);

            return result;
        }

    }
}
