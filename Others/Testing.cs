using System;

namespace LeetCode.Others
{
    public class Testing
    {
        public static bool GetExponentialValue(int baseValue, int valueTocheck)
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