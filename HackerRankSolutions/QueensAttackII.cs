using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class QueensAttackII
    {
        /// <summary>
        /// Asagidaki kod sonucu dogru veriyor ancak O(n^2) zamanda calistigi icin verimli degil. Commentlenen kodun altinda optimize edilmis metot blogu bulunmaktadir.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <param name="r_q"></param>
        /// <param name="c_q"></param>
        /// <param name="obstacles"></param>
        /// <returns></returns>
        //public int queensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
        //{
        //    int count = 0;
        //    for (int a = r_q - 1; a >= 1; a--)
        //    {
        //        int temp = 0;
        //        foreach (var item in obstacles)
        //        {
        //            if (item[0] == a && item[1] == c_q)
        //            {
        //                temp++;
        //                break;
        //            }
        //            else
        //            {
        //                count++;
        //            }
        //        }
        //        if (temp > 0)
        //        {
        //            break;
        //        }
        //    }
        //    for (int b = r_q + 1; b <= n; b++)
        //    {
        //        int temp = 0;
        //        foreach (var item in obstacles)
        //        {
        //            if (item[0] == b && item[1] == c_q)
        //            {
        //                temp++;
        //                break;
        //            }
        //            else
        //            {
        //                count++;
        //            }
        //        }
        //        if (temp > 0)
        //        {
        //            break;
        //        }
        //    }
        //    for (int c = c_q - 1; c >= 1; c--)
        //    {
        //        int temp = 0;
        //        foreach (var item in obstacles)
        //        {
        //            if (item[0] == r_q && item[1] == c)
        //            {
        //                temp++;
        //                break;
        //            }
        //            else
        //            {
        //                count++;
        //            }
        //        }
        //        if (temp > 0)
        //        {
        //            break;
        //        }
        //    }
        //    for (int d = c_q + 1; d <= n; d++)
        //    {
        //        int temp = 0;
        //        foreach (var item in obstacles)
        //        {
        //            if (item[0] == r_q && item[1] == c_q)
        //            {
        //                temp++;
        //                break;
        //            }
        //            else
        //            {
        //                count++;
        //            }
        //        }
        //        if (temp > 0)
        //        {
        //            break;
        //        }
        //    }
        //    int row = r_q-1;
        //    int column = c_q+1;
        //    while (row<=n && column <=n)
        //    {
        //        int temp = 0;
        //        foreach (var item in obstacles)
        //        {
        //            if (item[0] == row && item[1] == column)
        //            {
        //                temp++;
        //                break;
        //            }
        //            else
        //            {
        //                count++;
        //            }
        //        }
        //        if (temp > 0)
        //        {
        //            break;
        //        }
        //        row--;
        //        column++;
        //    }
        //    row = r_q + 1;
        //    column = c_q - 1;
        //    while (row <= n && column <= n)
        //    {
        //        int temp = 0;
        //        foreach (var item in obstacles)
        //        {
        //            if (item[0] == row && item[1] == column)
        //            {
        //                temp++;
        //                break;
        //            }
        //            else
        //            {
        //                count++;
        //            }
        //        }
        //        if (temp > 0)
        //        {
        //            break;
        //        }
        //        row++;
        //        column--;
        //    }
        //    row = r_q - 1;
        //    column = c_q - 1;
        //    while (row <= n && column <= n)
        //    {
        //        int temp = 0;
        //        foreach (var item in obstacles)
        //        {
        //            if (item[0] == row && item[1] == column)
        //            {
        //                temp++;
        //                break;
        //            }
        //            else
        //            {
        //                count++;
        //            }
        //        }
        //        if (temp > 0)
        //        {
        //            break;
        //        }
        //        row--;
        //        column--;
        //    }
        //    row = r_q + 1;
        //    column = c_q + 1;
        //    while (row <= n && column <= n)
        //    {
        //        int temp = 0;
        //        foreach (var item in obstacles)
        //        {
        //            if (item[0] == row && item[1] == column)
        //            {
        //                temp++;
        //                break;
        //            }
        //            else
        //            {
        //                count++;
        //            }
        //        }
        //        if (temp > 0)
        //        {
        //            break;
        //        }
        //        row++;
        //        column++;
        //    }
        //    return count;
        //}
        public int queensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
        {
            int count = 0;
            var obstacleSet = new HashSet<string>();

            foreach (var obstacle in obstacles)
            {
                obstacleSet.Add($"{obstacle[0]}_{obstacle[1]}");
            }

            int[] dr = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dc = { -1, 0, 1, -1, 1, -1, 0, 1 };

            for (int i = 0; i < 8; i++)
            {
                int r = r_q + dr[i];
                int c = c_q + dc[i];

                while (r >= 1 && r <= n && c >= 1 && c <= n)
                {
                    if (obstacleSet.Contains($"{r}_{c}"))
                    {
                        break;
                    }
                    count++;
                    r += dr[i];
                    c += dc[i];
                }
            }
            return count;
        }
    }
}
