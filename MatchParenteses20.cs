using System.Collections.Generic;
using System.Linq;

//https://leetcode.com/problems/valid-parentheses/solution/
namespace LeetCode
{
    public class MatchParenteses20
    {
        public bool IsValid(string s)
        {
            // ({{)})
            var allParentheses = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    allParentheses.Push(s[i]);
                }
                else
                {
                    if (allParentheses.Any())
                    {
                        allParentheses.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }


            return !allParentheses.Any();
        }
    }
}