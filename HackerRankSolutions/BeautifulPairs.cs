using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class BeautifulPairs
    {
        public int beautifulPairs(List<int> A, List<int> B)
        {
            HashSet<int> indexJ = new HashSet<int>();
            HashSet<int> indexI = new HashSet<int>();
            
            int count = 0;
            for (int i = 0; i < B.Count; i++)
            {
                int forChange = 0;
                for (int j = 0; j < A.Count; j++)
                {
                    if ((!indexJ.Contains(j))&&B[i]==A[j])
                    {
                        indexJ.Add(j);
                        count++;
                        forChange++;
                        break;
                    }
                }
                if (forChange == 0) { indexI.Add(i); }
            }
            return indexI.Count > 0 ? count + 1 : count-1; //hepsi uyusuyorsa bir tane degistirmek zorunda oldugumuzdan -1 yaparak donuyoruz.
        }
    }
}
