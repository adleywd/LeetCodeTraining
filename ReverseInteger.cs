using System.Linq;
namespace LeetCode
{
    public class ReverseInteger
    {
        //https://leetcode.com/problems/reverse-integer/submissions/
        //First Attempt
        public int Solution(int x)
        {
            var charIntsArray = x.ToString().ToCharArray();
            for (int i = 0; i < charIntsArray.Length; i++)
            {
                for (int j = i + 1; j < charIntsArray.Length; j++)
                {
                    if (int.Parse(charIntsArray[j].ToString()) > int.Parse(charIntsArray[i].ToString()))
                    {
                        char temp = charIntsArray[i];
                        charIntsArray[i] = charIntsArray[j];
                        charIntsArray[j] = temp;
                    }
                }
            }
            return int.Parse(new string(charIntsArray));
        }

        public int Solution2(int x)
        {
            if (x == 0) return 0;

            var minus = x.ToString().Contains("-") ? "-" : "";
            var sorted = x.ToString().Replace("-", string.Empty)
                                    .OrderByDescending(x => x)
                                    .ToList();
            var resultString = minus + string.Join("", sorted);
            return int.Parse(resultString);
        }
    }
}