using System.Linq;
using System.Collections.Generic;

namespace LeetCode
{
    public class Anagram
    {
        // return if it is an anagram
        public bool isAnagram(string s, string t)
        {
            var myDict = new Dictionary<char, int>();


            foreach (var letter in s)
            {
                if (myDict.ContainsKey(letter))
                {
                    // increase letter count
                    var letterCount = ++myDict[letter];
                    myDict[letter] = letterCount;
                }
                else
                {
                    // Add new letter
                    myDict.Add(letter, 1);
                }
            }

            foreach (var letterB in t)
            {
                if (myDict.ContainsKey(letterB) && myDict[letterB] > 0)
                {
                    // Remove 1 count from the letter
                    var letterCount = --myDict[letterB];
                    myDict[letterB] = letterCount;
                }
                else
                {
                    return false;
                }
            }

            // Return false if It has some letter count bigger than 0;
            return !myDict.Any(x => x.Value > 0);
        }
    }
}