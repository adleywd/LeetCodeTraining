using System.Collections.Generic;

namespace LeetCode
{
    public class TwoSum
    {
        //nums = [2,7,11,15], target = 9
        public int[] TwoSumSolution(int[] nums, int target)
        {
            var result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
            return result;
        }

        //Optimized
        public int[] TwoSumSolution2(int[] nums, int target)
        {
            var result = new int[2];
            var myDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var valueNeeded = target - nums[i];
                if (myDict.ContainsKey(valueNeeded))
                {
                    return new int[2] { i, myDict[valueNeeded] };
                }
                myDict.Add(nums[i], i);
            }

            return result;
        }
    }
}