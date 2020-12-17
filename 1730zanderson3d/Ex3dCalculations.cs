using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1730zanderson3d
{
    public class Ex3dCalculations
    {
        public static string ArrayToString(int[] values)
        {
            StringBuilder sbResult = new StringBuilder(200);
            string result = "Invalid input";
            int i = 0;
            foreach (int value in values)
            {
                sbResult.Append(values[i]); //     convert current value to string, append to sbResult
                sbResult.Append(", ");

                result = sbResult.ToString();
                i++;
            }
            result = sbResult.ToString();
            return result.Remove(result.LastIndexOf(", "));

            
        }

        public static int ValueCount(int[] values, int searchValue)
        {
            int count = 0;
            int i = 0;
            foreach (int value in values)
            {
                if (values[i] == searchValue)
                    count += 1;
                else
                    count += 0;

                i++;
            }
            return count;
        }

        public static int RangeCount(int[] values, int searchMin, int searchMax)
        {
            int count = 0;
            int i = 0;
            foreach (int value in values)
            {
                if (values[i] >= searchMin && values[i] <= searchMax)
                {
                    count += 1;
                }
                else count += 0;

                i++;
            }
        
            return count;
        }
    }
}
