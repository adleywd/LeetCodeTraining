using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            /* TWO SUM */
            // var twoSum = new TwoSum();
            // var result = twoSum.TwoSumSolution2(new int[4] { 2, 7, 11, 15 }, 9);
            // var result2 = twoSum.TwoSumSolution2(new int[3] { 3, 2, 4 }, 6);
            // var result3 = twoSum.TwoSumSolution2(new int[2] { 3, 3 }, 6);

            /* REVERSE INTEGER, not working yet */
            var reverseInteger = new ReverseInteger();
            // var result = reverseInteger.Solution(92843);
            // var result2 = reverseInteger.Solution(92843);
            // var result3 = reverseInteger.Solution(-82943);
            // var result4 = reverseInteger.Solution(120);
            // var result5 = reverseInteger.Solution(901000);
            // var result6 = reverseInteger.Solution(-123);
            var result7 = reverseInteger.Solution(1534236469);

            /* RANDOM TESTS */
            // var dayOfTheYear = new DayOfTheYear1154();
            // var result = dayOfTheYear.DayOfTheYear("2020-03-09");

            /* EXPONENTIAL VALUE */
            /* var isExponential = LeetCode.Others.Testing.GetExponentialValue(5, 26);

            /* MATCH PARENTESES */
            // var matchParenteses = new MatchParenteses20();
            // var valid = matchParenteses.IsValid("(((((())))))");
            // var valid2 = matchParenteses.IsValid("()()()()");
            // var valid3 = matchParenteses.IsValid("((()(())))");
            // var invalid = matchParenteses.IsValid("(((((((()");
            // var valid4 = matchParenteses.IsValid("[()]");

            /* ANAGRAM */
            // var anagram = new Anagram();
            // var isValid1 = anagram.isAnagram("anagram", "angaram");
            // var isValid2 = anagram.isAnagram("rat", "car");
        }

    }


}
