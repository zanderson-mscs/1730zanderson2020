﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

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

            //String
             public static string StringCalc01(string a)
        {
           string result = "Invalid input";
           try{
                    a = a.Remove(0, 1);
                    a = a.Insert(0, "cr");
                    result = a;
              }
               catch { }

            return result;
        }
                public static string StringCalc02(string a)
        {
          string result = "Invalid input";
           try{
                    a = a.Remove(0, 1);
                    a = a.Insert(0, "rit");
                    result = a;
              }
               catch { }

            return result;
        }
                   public static string StringCalc03(string a)
        {
          string result = "Invalid input";
           try{
                    a = a.Substring(0, 2).ToUpper();
                    result = a;
              }
               catch { }

            return result;
        }

            public static string StringCalc04(string a)
        {
          string result = "Invalid input";
           try{
                    a = a.PadLeft(10);           //ten characters, pad with star. Didn't show up with any hints so I'm just guessing by what you said
                    result = a;
              }
               catch { }

            return result;
        }

           public static string StringCalc05(string a)
        {
          string result = "Invalid input";
           try{
                    a = a.Replace("(", "");
                    a = a.Replace(")", "");
                    a = a.Replace("-", "");
                    result = a;
              }
               catch { }

            return result;
        }
              public static string StringCalc06(string a)
        {
          string result = "Invalid input";
           try{
                    a = a.Replace("(", "");
                    a = a.Replace(")", "");
                    a = a.Replace("-", "");
                    if (a.Length(10))
                        a.Insert(3, ".");
                        a.Insert(7, ".");
                    else
                        a.Insert(3, ".");
              }
               catch { }

            return result;
        }
             public static string StringCalc07(string a)
        {
        string result = "Invalid input";
           try{
                a = a.ToLower();
                  if(a.Contains("pioneer") )
                    result = "Found";
                  else if (a.Contains("pioneer") != true )         //Does not contain
                    result = "Not found";
              }
               catch { }

            return result;
        }

             public static string StringCalc08(string a)
        {
          string result = "Invalid input";
           try{
                 int aIndex = a.IndexOf(",") + 1;
                a = a.Substring(aIndex);

                 result = a;
              }
               catch { }

            return result;
        }

            public static string StringCalc09(string a)
        {
         string  result = "Invalid input";
           try{
                 int aLastIndex = a.LastIndexOf(" ") + 1;
                a = a.Substring(aLastIndex);

                 result = a;
              }
               catch { }

            return result;
        }

             public static string StringCalc10(string s1, string s2, string s3)
        {
                StringBuilder sb = new StringBuilder(100);
                sb.Append(s1);
                sb.Append(s2);
                sb.Append(s3);
                return sb.ToString();
        }

        }
    }
}