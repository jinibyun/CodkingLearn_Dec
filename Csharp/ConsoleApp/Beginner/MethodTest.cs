using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Beginner
{
    public class MethodTest
    {
        // pass by value
        public void TestPassByValue(int a)
        {
            a *= 2;
        }

        // pass by ref
        public double TestPassByRef(ref int a, ref double b)
        {
            return ++a * ++b;
        }

        // pass by out
        public bool TestPassByOut(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a - b;
            return true;
        }

        // optional or default parameter
        public int TestDefaultParam(int a, int b, string calcType = "+")
        {
            switch (calcType)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                default:
                    throw new ArithmeticException();
            }
        }

        // params keyword
        public long TestParams(params int[] values)
        {
            long sum = 0L;
            foreach(var member in values)
            {
                sum += member;
            }
            return sum;
        }
    }
}
