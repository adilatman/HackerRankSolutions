using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    class ClimbingTheLeaderboard
    {
        public List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            ////Time Limit Exceeded
            //var rankedSet = new HashSet<int>(ranked);
            //var rankedSorted = rankedSet.OrderByDescending(x => x).ToList();
            //var ranking = new List<int>();

            //foreach (var score in player)
            //{
            //    var rank = rankedSorted.Count + 1;
            //    for (int i = 0; i < rankedSorted.Count; i++)
            //    {
            //        if (score >= rankedSorted[i])
            //        {
            //            rank = i + 1;
            //            break;
            //        }
            //    }

            //    ranking.Add(rank);
            //}

            //return ranking;

            ////Time Limit Exceeded
            List<int> ranking = new List<int>();
            //List<int> ranked2 = new List<int>();
            //foreach (var item in ranked)
            //{
            //    if (!ranked2.Contains(item)) { ranked2.Add(item); }
            //}
            //for (int i = 0; i < player.Count; i++)
            //{
            //    ranked2.Sort((x, y) => y.CompareTo(x));
            //    int rank = ranked2.IndexOf(player[i]);
            //    if (rank >= 0)
            //    {
            //        ranking.Add(rank + 1);
            //    }
            //    else
            //    {
            //        int last = 0;
            //        for (int j = 0; j < ranked2.Count; j++)
            //        {
            //            if (ranked2[j] < player[i])
            //            {
            //                ranking.Add(j + 1);
            //                last++;
            //                break;
            //            }
            //        }
            //        if (last == 0) { ranking.Add(ranked2.Count + 1); }
            //    }
            //}
            return ranking;
        }
    }
}
