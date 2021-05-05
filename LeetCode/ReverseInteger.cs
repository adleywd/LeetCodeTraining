using System.Linq;
namespace LeetCode
{
    public class ReverseInteger
    {
        //https://leetcode.com/problems/reverse-integer/submissions/
        //Not working.
        //Input is too large or too small 1534236469

        public int Solution(int x)
        {
            if (x == 0) return 0;
            var resultString = x.ToString();
            var hasMinus = resultString.First() == '-';
            if (hasMinus)
            {
                resultString = resultString.Replace("-", string.Empty);
            }
            while (resultString.Last() == '0')
            {
                resultString = resultString.Substring(0, resultString.Length - 1);
            }
            resultString = string.Join(string.Empty, resultString.Reverse());

            // HERE THE PROBLEM
            int result = 0;
            var parset = int.TryParse(hasMinus ? "-" + resultString : resultString, out result);

            if (result > int.MaxValue && result < int.MinValue) return 0;

            return result;
        }
    }
}