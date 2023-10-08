using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class SuperReducedString
    {
        public static string superReducedString(string s)
        {
            var stack = new Stack<char>();
            foreach (char item in s)
            {
                if (stack.Count > 0 && stack.Peek() == item)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(item);
                }
            }
            if (stack.Count > 0)
            {
                return new string(stack.ToArray().Reverse().ToArray());
            }
            else
            {
                return "Empty String";
            }
        }
    }
}
