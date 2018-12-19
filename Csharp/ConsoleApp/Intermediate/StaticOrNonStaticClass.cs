using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Intermediate
{
    public static class StaticClass
    {
        public static int i = 100;
        static StaticClass()
        {

        }

        // usage: Utility (helper) classes often contain public static methods
        public static long sum(int i , int j)
        {
            return i+j;
        }

        // compile error
        //public long devide()
        //{
        //    return 100;
        //}
    }

    public class NonStaticClass
    {
        public static int i = 100;
        public NonStaticClass()
        {

        }
        public static long sum(int i, int j)
        {
            return i + j;
        }

        // no compile error
        public double devide(int i , int j)
        {
            if (j == 0)
                throw new Exception("cannot be devide by zero");
            return i /j ;
        }
    }
}
