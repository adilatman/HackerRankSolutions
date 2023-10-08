using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class IceCreamParlor
    {
        public static List<int> icecreamParlor(int m, List<int> arr)
        {
            List<int> arr2 = new List<int>();
            for (int i = 1; i <= arr.Count - 1; i++)
            {
                for (int j = i + 1; j <= arr.Count; j++)
                {
                    if (arr[i - 1] + arr[j - 1] == m)
                    {
                        arr2.Add(i);
                        arr2.Add(j);
                        break;
                    }
                }
                if (arr2.Count > 0) { break; }
            }
            return arr2;
        }
    }
}
