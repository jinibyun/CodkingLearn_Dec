using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Assignment
{
    // 2. EXTENSION METHOD
    public static class StringExtensions
    {
        public static string ReverseString(this string input)
        {
            if (string.IsNullOrEmpty(input)) return "";
            return new string(input.ToCharArray().Reverse().ToArray());
        }
    }
    class Assignment7
    {
        List<string> str1 = new List<string>();
        
     

//1. Using Lambda expression
// Where, Select, Any, All, First, FirstOrDefault,Single, SingleDefault
// Above methods should be used.

//(If necessary, you can populate another value into str variables)

// 2. Research Extension method and exercise it (Copy & Paste is allowed)

// 3. What is the advantage of using extension method?

// 4. Research async and await and exercise it (Copy & Paste is allowed)
        public void Test()
        {
            List<string> str = new List<string>();

            str.Add("aaaa");
            str.Add("bbbb");
            str.Add("cccc");
            str.Add("aabb");
            str.Add("cccd");
            str.Add("bbcc");
            str.Add("dddd");

            str.Add("Lily");
            str.Add("Rose");
            str.Add("Daisy");
            str.Add("Alyssa");
            str.Add("Jasmine");
            str.Add("Cassia");
            str.Add("Violet");
            str.Add("Iris");
            str.Add("Heather");




            //1. Using Lambda expression
            // Where, Select, Any, All, First, FirstOrDefault,Single, SingleDefault
            // Above methods should be used.

            Console.WriteLine("1. LAMBDA EXPRESSION");
            Console.WriteLine("\n");


            // WHERE

            Console.WriteLine("WHERE METHOD");

            List<string> startA = str.Where((a => String.Compare(a,"b")<0)).ToList();
            List<string> startB = str.Where((a => String.Compare(a, "c") < 0 && String.Compare(a, "b") > 0)).ToList();

            List<string> NeitherAorB = str.Where((a => String.Compare(a, "b") > 0 )).ToList();
            // start with B~

            Console.WriteLine("str element start with A : " + String.Join(", ", startA));
            Console.WriteLine("str element start with B : " + String.Join(", ", startB));
            Console.WriteLine("str element except startA element  : " + String.Join(", ", NeitherAorB));

            // SELECT
            Console.WriteLine("\n");
            Console.WriteLine("SELECT METHOD");
            List<string> uppers = str.Select(element => element.ToUpper()).ToList();
            Console.WriteLine("str element ToUppers : " + String.Join(", ", uppers));


            // ANY
            Console.WriteLine("\n");
            Console.WriteLine("ANY METHOD");
            bool BB= str.Any(item => String.Compare(item, "B") > 0);
            // Any element start with B exist?
            Console.WriteLine(BB);


            bool XX = str.Any(item => String.Compare(item, "X") > 0);
            // Any element start with X exist?
            Console.WriteLine(XX);

            // ALL
            Console.WriteLine("\n");
            Console.WriteLine("ALL METHOD");
            bool AA= str.All(item => String.Compare(item, "A") > 0);
            // All element bigger than A? 

            Console.WriteLine(AA);
            bool CC = str.All(item => String.Compare(item, "C") > 0);
            // All element bigger than B? 
            Console.WriteLine(CC);

            // FIRST
            Console.WriteLine("\n");
            Console.WriteLine("FIRST METHOD");
            string firstF = str.First(a => String.Compare(a, "F") > 0);
            // first item bigger than F 
            Console.WriteLine(firstF);

            string firstAB = str.First(a => String.Compare(a, "AB") > 0);
            // first item bigger than AB
            Console.WriteLine(firstAB);

            /*string firstZ = str.First(a => String.Compare(a, "Z") > 0);
            // first item bigger than Z
            Console.WriteLine(firstZ==null);
            // No result, exception handling needed (-> firstordefault)*/


            // FIRSTORDEFAULT
            Console.WriteLine("\n");
            Console.WriteLine("FIRSTORDEFAULT METHOD");
            string firstK = str.FirstOrDefault(a => String.Compare(a, "K") > 0);
            // first item bigger than K
            Console.WriteLine(firstK);

            string firstOrdefaultZ = str.FirstOrDefault(a => String.Compare(a, "Z") > 0);
            // first or default item bigger than Z
            Console.WriteLine(firstOrdefaultZ == null);

            // SINGLE
            Console.WriteLine("\n");
            Console.WriteLine("SINGLE METHOD");
            
            string singleV = str.Single(a => String.Compare(a, "V") > 0);
            Console.WriteLine(singleV);

            // SINGLEORDEFAULT
            Console.WriteLine("\n");
            Console.WriteLine("SINGLEORDEFAULT METHOD");
           
            string singleX = str.SingleOrDefault(a => String.Compare(a, "X") > 0);
            // Element bigger than X == null
            Console.WriteLine(singleX==null);



            // 2. Research Extension method and exercise it (Copy & Paste is allowed)

            /* Extension methods are static methods that are always implemented in a static class. 
             * They don’t need a class object, they can be directly called. 
             * In C#, we already have some built-in extension methods like Union, Where and Zip. 
             * These extension methods need a System.Linq namespace declaration. */
            Console.WriteLine("\n");
            Console.WriteLine("2. EXTENSION METHOD");

            string dodam = "Dodam";
            string dodamReversed = dodam.ReverseString();

            Console.WriteLine("string dodam: " + dodam);
            Console.WriteLine("string dodamReversed: " + dodamReversed);





        // 3. What is the advantage of using extension method?

/* Extension methods is a very useful feature that was added in .NET Framework 3.0 
 * that gives the developer the ability to add or extend methods to existing types 
 * without creating a new derived type, recompiling, or modifying the original type.*/


// 4. Research async and await and exercise it (Copy & Paste is allowed)
 

}


}
}
