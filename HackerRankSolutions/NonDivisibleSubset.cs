using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class NonDivisibleSubset
    {
        public int nonDivisibleSubset(int k, List<int> s)
        {
            int[] remainders = new int[k];

            foreach (int num in s)
            {
                remainders[num % k]++;
            }

            int result = 0;

            if (remainders[0] > 0)
            {
                result++;
            }

            for (int i = 1; i <= k / 2; i++)
            {
                if (i != k - i)
                {
                    result += Math.Max(remainders[i], remainders[k - i]);
                }
                else
                {
                    result++;
                }
            }

            return result;

            ////Time Limit Exceeded
            //int counter = 0;

            //for (int i = 0; i < s.Count; i++)
            //{
            //    HashSet<int> newList = new HashSet<int>();
            //    newList.Add(s[i]);
            //    for (int j = 0; j < s.Count; j++)
            //    {
            //        int count = 0;
            //        foreach (var item in newList)
            //        {
            //            if ((item + s[j]) % k == 0)
            //            {
            //                count++;
            //                break;
            //            }
            //        }
            //        if (count == 0) newList.Add(s[j]);
            //    }
            //    if (newList.Count > counter) { counter = newList.Count; }
            //}
            //return counter;
        }
    }
}
