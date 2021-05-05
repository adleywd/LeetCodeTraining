using System.Collections.Generic;
using System.Linq;

//https://leetcode.com/problems/valid-parentheses/solution/
namespace LeetCode
{
    public class MatchParenteses20
    {
        public bool IsValidOnlyParentheses(string s)
        {
            // ((()))
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

        public bool IsValid(string s)
        {
            var parenthesesMatch = new Dictionary<char, char>();
            parenthesesMatch.Add(')', '(');
            parenthesesMatch.Add('}', '{');
            parenthesesMatch.Add(']', '[');
            // ({{)})
            var openParentheses = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    openParentheses.Push(s[i]);
                }
                else
                {
                    if (openParentheses.Any() && openParentheses.Peek() == parenthesesMatch[s[i]])
                    {
                        openParentheses.Pop();
                    }
                    else // If doesn't have the same type of opening partentheses in the top of the list, means that is not correctly closed
                    {
                        return false;
                    }
                }
            }


            return !openParentheses.Any();
        }
    }
}