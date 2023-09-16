using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class ExtraLongFactorials
    {
        public void extraLongFactorials(int n)
        {
            if (n == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                BigInteger faktoriyel = new BigInteger(1);
                for (int i = 2; i <= n; i++)
                {
                    faktoriyel *= i;
                }
                Console.WriteLine(faktoriyel);
            }
        }
    }
}
