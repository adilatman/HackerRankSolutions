using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class StringReplacement
    {
        public static string getSmallestString(string word, string substr)
        {
            string smallest = "zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz";
            //string smallest = new string('z', word.Length);

            for (int j = 0; j < word.Length - 1; j++)
            {
                int subind = 0;
                char[] word2 = word.ToCharArray();
                for (int i = j; i < word.Length; i++)
                {
                    if (subind < substr.Length)
                    {
                        if (word[i] == substr[subind] || word[i] == '?')
                        {
                            word2[i] = substr[subind];
                            subind++;
                        }
                        else
                        {
                            word2 = word.ToCharArray();
                            subind = 0;
                        }
                    }
                    else
                    {
                        string newWord = new string(string.Concat(word2).Replace('?', 'a'));
                        smallest = string.Compare(newWord, smallest) < 0 ? newWord : smallest;
                        break;
                    }
                }
            }
            return smallest.Contains(substr) ? smallest : "-1";
        }
    }
}
