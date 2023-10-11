using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class FloydCityOfBlindingLights
    {
        class Program
        {
            class Solution
            {
                //public static void Main(string[] args)
                //{
                //    string[] roadNodesEdges = Console.ReadLine().TrimEnd().Split(' ');

                //    int roadNodes = Convert.ToInt32(roadNodesEdges[0]);
                //    int roadEdges = Convert.ToInt32(roadNodesEdges[1]);

                //    // Matrisi oluşturun ve başlangıç değerlerini ayarlayın
                //    int[,] distance = new int[roadNodes + 1, roadNodes + 1];
                //    int infinity = int.MaxValue / 2;

                //    for (int i = 1; i <= roadNodes; i++)
                //    {
                //        for (int j = 1; j <= roadNodes; j++)
                //        {
                //            if (i == j)
                //                distance[i, j] = 0;
                //            else
                //                distance[i, j] = infinity;
                //        }
                //    }

                //    for (int i = 0; i < roadEdges; i++)
                //    {
                //        string[] roadFromToWeight = Console.ReadLine().TrimEnd().Split(' ');

                //        int roadFrom = Convert.ToInt32(roadFromToWeight[0]);
                //        int roadTo = Convert.ToInt32(roadFromToWeight[1]);
                //        int roadWeight = Convert.ToInt32(roadFromToWeight[2]);

                //        // Kenarları ekleyin
                //        distance[roadFrom, roadTo] = roadWeight;
                //    }

                //    // Floyd-Warshall algoritması
                //    for (int k = 1; k <= roadNodes; k++)
                //    {
                //        for (int i = 1; i <= roadNodes; i++)
                //        {
                //            for (int j = 1; j <= roadNodes; j++)
                //            {
                //                if (distance[i, k] + distance[k, j] < distance[i, j])
                //                {
                //                    distance[i, j] = distance[i, k] + distance[k, j];
                //                }
                //            }
                //        }
                //    }

                //    int q = Convert.ToInt32(Console.ReadLine().Trim());

                //    for (int qItr = 0; qItr < q; qItr++)
                //    {
                //        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                //        int x = Convert.ToInt32(firstMultipleInput[0]);
                //        int y = Convert.ToInt32(firstMultipleInput[1]);

                //        // İki şehir arasındaki en kısa yol uzunluğunu yazdırın
                //        if (distance[x, y] == infinity)
                //            Console.WriteLine("-1");
                //        else
                //            Console.WriteLine(distance[x, y]);
                //    }
                //}
            }
        }
    }
}
