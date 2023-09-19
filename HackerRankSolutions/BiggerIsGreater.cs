using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class BiggerIsGreater
    {
        /// <summary>
        /// The process called "Next Permutation"
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public string biggerIsGreater(string w)
        {
            char[] word = w.ToCharArray();
            if (word.Length == 1)
            {
                return "no answer";
            }
            int i = word.Length - 2;
            while (i >= 0 && word[i] >= word[i + 1])
            {
                i--;
            }
            if (i < 0)
            {
                return "no answer";
            }
            int j = word.Length - 1;
            while (j >= 0 && word[j] <= word[i])
            {
                j--;
            }
            (word[i], word[j]) = (word[j], word[i]);

            // 41. satirin muadili (swap/yer degistirme)
            //var temp = word[j];
            //word[j] = word[i];
            //word[i] = temp;

            //Array.Sort(word);

            Array.Sort(word, i + 1, word.Length - i - 1);

            return new string(word);
        }
    }
}
