using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class CaesarCipher
    {
        public string caesarCipher(string s, int k)
        {
            char[] ss = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (ss[i] >= 97 && ss[i] <= 122)
                {
                    ss[i] = (char)(((ss[i] - 97 + k) % 26) + 97);
                }
                else if (ss[i] >= 65 && ss[i] <= 90)
                {
                    ss[i] = (char)(((ss[i] - 65 + k) % 26) + 65);
                }
            }
            return new string(ss);
        }
    }
}
