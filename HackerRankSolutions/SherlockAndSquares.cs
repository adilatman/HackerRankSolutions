using System;

namespace HackerRankSolutions
{
    public class SherlockAndSquares
    {
        public int squares(int a, int b)
        {
            int result = 0;
            int min = (int)Math.Sqrt(a);
            int max = (int)Math.Sqrt(b);
            for (int i = min; i <= max; i++)
            {
                if(i*i>=a && i*i<=b)result++;
            }
            return result;
        }
    }
}