using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1730zanderson3c
{
   public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            string result = "Invalid index";
    
            if (index >= 1 && index <= 7)
                result = days[index - 1];
            else
                result = "Invalid index";
            
            return result;
        }

        public static string Calc1(string search)
        {
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };

            search = search.Trim();
            search = search.ToUpper();

            string result = "Invalid input";

            
            int index = Array.IndexOf(days, search);
            if (index >= 0)
                result = hours[index];
            else
                result = "Invalid input";
            
            return result;
        }

        public static int Calc2(int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
                sum += number;
            return sum; 
        }
        public static double Calc3(double[] numbers, int count)
        {
            double sum = 0.0;

            int length = numbers.GetLength(0);
            if (length >= count)
                for (int i = 0; i < count; i++)
                    sum += numbers[i];
            else
                sum = 0.0;

            return sum;
        }
        public static double Calc5(double[] numbers)
        {
            double avg = -1;
            double sum = 0;
            if (numbers.GetLength(0) > 0)
                 sum = Calc3(numbers, numbers.GetLength(0));
            else
                avg = -1;
            avg = sum / numbers.GetLength(0);
            return avg;                        
        }

        public static double[] Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<Double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers) / length;
                foreach (int number in numbers)
                {
                    if (number >= avg)


                        aboveAvgList.Add(numbers[number]); 
                }

            }
            else aboveAvgList.Add(-1);
            
            return aboveAvgList.ToArray();
            

            
        }
    }
}
