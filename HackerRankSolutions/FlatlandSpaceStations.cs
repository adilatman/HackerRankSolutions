using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class FlatlandSpaceStations
    {
        static int flatlandSpaceStations(int n, int[] c)
        {
            Array.Sort(c);
            int maxDistance = 0;

            maxDistance = Math.Max(maxDistance, c[0]);

            for (int i = 1; i < c.Length; i++)
            {
                int distance = (c[i] - c[i - 1]) / 2;
                maxDistance = Math.Max(maxDistance, distance);
            }

            maxDistance = Math.Max(maxDistance, n - 1 - c[c.Length - 1]);

            return maxDistance;
        }
    }
}
