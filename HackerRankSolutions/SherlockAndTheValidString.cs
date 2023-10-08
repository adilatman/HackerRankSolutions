using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class SherlockAndTheValidString
    {
        public string isValid(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Sort(arr);
            if (arr.Length == 1)
            {
                return "YES";
            }
            var unique = new HashSet<char>();
            var countChar = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                if (!unique.Contains(arr[i]))
                {
                    unique.Add(arr[i]);
                    count++;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (unique.Contains(arr[j]))
                        {
                            count++;
                        }
                    }
                    countChar.Add(count);
                }
            }
            countChar.Sort();
            int nonOrSingle = 0;
            for (int k = 1; k < countChar.Count; k++)
            {
                if (countChar[0].CompareTo(countChar[k]) != 0)
                {
                    nonOrSingle++;
                }
            }
            if (nonOrSingle == 0 || (nonOrSingle > 1 && countChar[0] == 1 && countChar[0] < countChar[1] && countChar[1] == countChar[countChar.Count - 1]) || (nonOrSingle == 1 && countChar[countChar.Count - 1] - countChar[0] == 1))
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}
