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
            string result = "Invalid input";
            index = index - 1;
            if (index >= 0 && index <= 7)
                result = days[index];
            else
                result = "Invalid input";
            
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
            double avg = 0;
            int count = Int32.Parse(inputListBox5a.Text);
            if (count > 0)
            {
                double total = Ex3cCalculations.Calc3(numbers, count);
                avg = total / Double.Parse(inputListBox4a.Items.Count.ToString());
            }
            else
                MessageBox.Show("Invalid input" + "\n" + inputTextBox1a.Text);
            return avg;                         //This needs to be powerwashed. I'm missing some major concept here
        }

        public static double[] Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<Double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);
                foreach(int number in AboveAvg)
                    if(numbers >= avg)
                aboveAvgList.Add(numbers);
            }
            return aboveAvgList.ToArray();

            
        }
    }
}
