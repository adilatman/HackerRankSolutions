using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class AlmostSorted
    {
        public void almostSorted(List<int> arr)
        {
            List<int> arr2 = new List<int>(arr);
            arr2.Sort();
            int count3 = 0;
            for (int o = 0; o < arr2.Count; o++)
            {
                if (arr2[o] != arr[o]) { count3++; break; }
            }

            if (count3 == 0) { Console.WriteLine("yes"); return; }

            int l = -1;
            int r = -1;

            for (int i = 0; i < arr.Count - 1; i++)
                if (arr[i] > arr[i + 1]) { l = i; break; }
            for (int j = arr.Count - 1; j > 0; j--)
                if (arr[j] < arr[j - 1]) { r = j; break; }

            List<int> temp = new List<int>(arr);
            (temp[l], temp[r]) = (temp[r], temp[l]);

            int count = 0;
            for (int k = 0; k < temp.Count; k++)
            {
                if (arr2[k] != temp[k]) { count++; break; }
            }

            if (count == 0) { Console.WriteLine("yes"); Console.WriteLine($"swap {l + 1} {r + 1}"); return; }

            List<int> temp2 = new List<int>((arr.Take(l)));
            List<int> temp3 = new List<int>((arr.Skip(l).Take(r - l + 1)).Reverse());
            List<int> temp4 = new List<int>((arr.Skip(r + 1).Take((arr.Count) - (r + 1))));

            temp2.AddRange(temp3);
            temp2.AddRange(temp4);
            int count2 = 0;

            for (int m = 0; m < temp.Count; m++)
            {
                if (arr2[m] != temp2[m]) { count2++; break; }
            }

            if (count2 == 0) { Console.WriteLine("yes"); Console.WriteLine($"reverse {l + 1} {r + 1}"); return; }

            Console.WriteLine("no");
        }
    }
}
