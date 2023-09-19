using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class PalindromeIndex
    {
        public int palindromeIndex(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    if (isPalindrome(str.Substring(0, left) + str.Substring(left + 1)))
                    {
                        return left;
                    }
                    else if (isPalindrome(str.Substring(0, right) + str.Substring(right + 1)))
                    {
                        return right;
                    }
                    else
                    {
                        return -1;
                    }
                }
                left++;
                right--;
            }

            return -1;
        }

        static bool isPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
