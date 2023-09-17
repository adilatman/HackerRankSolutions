using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            //new AlmostSorted().almostSorted(new List<int>() { 1, 2, 8, 7, 6, 5, 4, 3, 9, 10 });
            //Console.WriteLine();

            //new ExtraLongFactorials().extraLongFactorials(100);
            //Console.WriteLine();

            //Console.WriteLine(new BiggerIsGreater().biggerIsGreater("dcbb"));
            //Console.WriteLine();
            timeConversion("12:00:00AM");


            Console.ReadLine();
        }
        public static string timeConversion(string s)
        {
            int hourPM = Convert.ToInt32(s.Split(':')[0]);
            char[] sss = s.ToCharArray();
            string hour = "";
            if (sss[8] == 'A')
            {
                if (hourPM == 12)
                {
                    hour = "00:" + s.Skip(3).Take(5);
                }
                else
                {
                    hour = s.Take(8).ToString();
                }
            }
            else
            {
                if (hourPM != 12)
                {
                    hourPM += 12;
                    hour = hourPM.ToString() + s.Skip(3).Take(5);
                }
                else
                {
                    hour = s.Take(8).ToString();
                }
            }
            return hour;
        }
    }
}
