using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // var twoSum = new TwoSum();
            // var result = twoSum.TwoSumSolution2(new int[4] { 2, 7, 11, 15 }, 9);
            // var result2 = twoSum.TwoSumSolution2(new int[3] { 3, 2, 4 }, 6);
            // var result3 = twoSum.TwoSumSolution2(new int[2] { 3, 3 }, 6);

            // var reverseInteger = new ReverseInteger();
            // var result = reverseInteger.Solution(92843);
            // var result2 = reverseInteger.Solution2(92843);
            // var result3 = reverseInteger.Solution2(-82943);
            // var result4 = reverseInteger.Solution2(120);

            // var dayOfTheYear = new DayOfTheYear1154();
            // var result = dayOfTheYear.DayOfTheYear("2020-03-09");

            // var isExponential = GetExponentialValue(5, 26);

            var matchParenteses = new MatchParenteses20();
            var valid = matchParenteses.IsValid("(((((())))))");
            var valid2 = matchParenteses.IsValid("()()()()");
            var valid3 = matchParenteses.IsValid("((()(())))");
            var invalid = matchParenteses.IsValid("(((((((()");
        }

        static bool GetExponentialValue(int baseValue, int valueTocheck)
        {
            var exponentialValue = 1;
            while (exponentialValue <= valueTocheck)
            {
                if (exponentialValue == valueTocheck)
                {
                    return true;
                }
                exponentialValue *= baseValue;
            }
            return false;
        }

        private void GetVelocityMeters(int kilometers)
        {
            Console.WriteLine(kilometers * 1000);
        }


    }

    public class Aloha : TestAbstract
    {
        public void retorna1()
        {
            Console.WriteLine(test());
        }
    }

    public abstract class TestAbstract
    {
        public int test()
        {
            return 1;
        }
    }
    class ClassA
    {
        public ClassA(int pValue) { }
    }

    public class TestStatic
    {
        public static int TestValue;

        public TestStatic()
        {
            if (TestValue == 0)
            {
                TestValue = 5;
            }
        }
        static TestStatic()
        {
            if (TestValue == 0)
            {
                TestValue = 10;
            }

        }

        public void Print()
        {
            if (TestValue == 5)
            {
                TestValue = 6;
            }
            Console.WriteLine("TestValue : " + TestValue);

        }
    }
}
