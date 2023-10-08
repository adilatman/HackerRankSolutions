using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class WeightedUniformStrings
    {
        public List<string> weightedUniformStrings(string s, List<int> queries)
        {
            HashSet<int> weights = new HashSet<int>();
            int previous = ' ';
            int currentWeight = 0;
            foreach (char item in s)
            {
                int weight = item - 'a' + 1;
                if (item == previous)
                {
                    currentWeight += weight;
                }
                else
                {
                    currentWeight = weight;
                }
                weights.Add(currentWeight);
                previous = item;
            }
            List<string> result = new List<string>();
            foreach (var item in queries)
            {
                if (weights.Contains(item))
                {
                    result.Add("Yes");
                }
                else
                {
                    result.Add("No");
                }
            }
            return result;
        }
    }
}
