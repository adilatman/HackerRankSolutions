using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class TwoCharacters
    {
        public int alternate(string s)
        {
            int maxLength = 0;

            var unique = s.Distinct().ToList();

            for (int i = 0; i < unique.Count; i++)
            {
                for (int j = i+1; j < unique.Count; j++)
                {
                    char first = unique[i];
                    char second = unique[j];
                    string newString = new string(s.Where(c=> c==first || c==second).ToArray());
                    if (IsAlternating(newString))
                    {
                        maxLength = Math.Max(newString.Length,maxLength);
                    }
                }
            }
            return maxLength;
        }
        public bool IsAlternating(string s)
        {
            for (int i = 0; i < s.Length-1; i++)
            {
                if (s[i]==s[i+1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
