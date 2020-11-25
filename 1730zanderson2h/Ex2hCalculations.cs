using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1730zanderson2h
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }
           
            return result;

        }

        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {

                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;

        }


        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);


            result = date.ToShortDateString();
            return result;

        }

        public static string DateCalc09(string strA, string strB)
        {
            string result = "Invalid input";
          

            try
            {
                DateTime A = DateTime.Parse(strA);
                DateTime B = DateTime.Parse(strB);
                int timeSpan = (A - B).Days;

                result = timeSpan.ToString() + " days";

            }
            catch { }

            return result ;

        }

        public static string DateCalc10(string strA, string strB)
        {
            string result = "Invalid input";
            bool pastDue = false;
            try
            {
                DateTime A = DateTime.Parse(strA);
                DateTime B = DateTime.Parse(strB);
                if (A <= B)
                    pastDue = false;
                else if (A > B)
                {
                    pastDue = true;
                    int timeSpan = (A - B).Days;
                    result = timeSpan + " days past due";
                }
                else
                    result = "On time";
                    
            }
            catch { }

               
            
            return result;

        }
    }
}