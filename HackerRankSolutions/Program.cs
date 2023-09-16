using System;
using System.Collections.Generic;

namespace HackerRankSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            new AlmostSorted().almostSorted(new List<int>() { 1, 2, 8, 7, 6, 5, 4, 3, 9, 10 });
            Console.WriteLine();

            new ExtraLongFactorials().extraLongFactorials(100);
            Console.WriteLine();

            Console.WriteLine(new BiggerIsGreater().biggerIsGreater("dcbb"));
            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
