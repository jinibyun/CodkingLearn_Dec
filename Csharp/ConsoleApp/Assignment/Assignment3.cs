using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp.Beginner;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Assignment
{
 
    public class Assignment3
    {
        public void Test()
        {
            Console.WriteLine("===Assignment3 Start===");
            Console.WriteLine("\n");

            // 1. FOR LOOP
            // Loop 1 through 100, get sum only for odd number. 

            Console.WriteLine("===== 1. For Loop ======");
            Console.WriteLine(" Loop 1 through 100, get sum only for odd number. ");

            int forSum = 0;

            for (int i = 1; i <= 100; i++)
            {              
                if (i % 2 != 0)
                {
                    forSum += i;
                }
            }
            Console.WriteLine("Sum of odd number from 1 to 100 is : {0}", forSum);
            Console.WriteLine("\n\n");





            // 2. FOR LOOP
            Console.WriteLine("===== 2. While Loop ======");
            Console.WriteLine(" Implement #1 using while loop ");

            int whileSum = 0;
            int j = 1;
            while (j <= 100){
                if (j % 2 != 0)
                {
                    whileSum += j;
                }
                j++;
            }

           Console.WriteLine("Sum of odd number from 1 to 100 is : {0}", whileSum);
           Console.WriteLine("\n\n");




            // 3. FOREACH STATEMENT

            Console.WriteLine("===== 3. Loop using foreach statement and Console.WriteLine ======");
            // However, show number only once. eg. There are three 9, it should NOT duplicate	

           int[] oddArray = new int[] { 1, 3, 3, 3, 5, 7, 9, 9, 9, 11, 11, 13, 15, 17, 17, 19, 21,21 };

            // Reference : https://stackoverflow.com/questions/9673/how-do-i-remove-duplicates-from-a-c-sharp-array

            int[] oddArray2 = oddArray.Distinct().ToArray();

            Console.WriteLine(" #1 Use LINQ");
            foreach (int i in oddArray2)
            {
                Console.WriteLine("Element of oddArray : {0}", i);
            }
            Console.WriteLine("\n");

            Console.WriteLine(" #2 Use METHOD");
            foreach (int i in removeDuplicate(oddArray))
            {
                Console.WriteLine("Element of oddArray : {0}", i);
            }
            Console.WriteLine("\n\n");
            //Console.WriteLine("Element of oddArray : {0}", string.Join(",",removeDuplicate(oddArray)));








            // 4. VAR VS DYNAMIC

            Console.WriteLine("===== 4. var keyword and dynamic keyword ======");
            // Both are being used define data type. Research on them and write example
            // Then, explain difference between them

            Console.WriteLine("REFERENCE (1) : https://www.youtube.com/watch?v=SsvJY33vc5g");
            Console.WriteLine("REFERENCE (2) : https://www.codeproject.com/Tips/460614/%2FTips%2F460614%2FDifference-Between-var-and-dynamic-in-Csharp");
           
            
            
            //var varDodam1; <- ERROR
            var varDodam2 = "Dodam"; 
            //   EARLY BOUNDED / CHECKING DATATYPE AND PROPERTIES DURING COMPILE TIME
            int lenVarDodam2 = varDodam2.Length;
            // INTELLIGENCE WORKING!
            // Datatype defined as string




            // dynamic dynamicDodam1; <- OK
            dynamic dynamicDodam2 = "Dodam"; 
            //  LATE BOUNDED / CHECKING DATATYPE AND PROPERTIES DURING RUN-TIME 
            //  SO, BEFORE DEBUGING IT BUILT SUCCESSFULLY BUT WHEN IT RUNS IT GENERATES ERROR
            int lenDynamicDodam2 = dynamicDodam2.Length;
            // INTELLIGENCE NOT WORKING! 
            // SHOUD BE AWARE OF CASE-SENSITIVE : dynamicDodam2.length generates error
            // Datatype defined as dynamic 

            Console.WriteLine("varDodam.length : {0}", lenVarDodam2);
            Console.WriteLine("dynamicDodam.length : {0}", lenDynamicDodam2);
            Console.WriteLine("\n");
            // Var is statically typed (early bounded) and
            // Dynamic is late bounded or checked on runtime

            Console.WriteLine("As part of the process, variables of type dynamic are compiled into variables of type object. " +
                "\nTherefore, type dynamic exists only at compile time, not at run time.");
            Console.WriteLine("\n\n");




            // 5. SWITCH STATEMENT
            Console.WriteLine("===== 5. Switch statement. ======");
            Console.WriteLine("Research on them and write example ");

            Console.Write(" # Please type your age: ");
            string userInput= Console.ReadLine();

            try
            {
                int userAge = Convert.ToInt32(userInput);

                switch (userAge)
                {
                    case int n when (n >= 70):
                        Console.WriteLine($" # You are 70 or above: {n}, you are senior");
                        break;

                    case int n when (n < 70 && n >= 20):
                        Console.WriteLine($"# You are between 70 and 20: {n}, you are adult");
                        break;

                    case int n when (n < 20):
                        Console.WriteLine($"# You are less than 20: {n}, you are junior");
                        break;

                    default:
                        Console.WriteLine($"# Please type your age properly");
                        break;
                }
            }

            catch
            {
                Console.WriteLine($"# Please type your age properly");
            }

            Console.WriteLine("\n\n");


            // 6. REF VS OUT PARAMETER

            Console.WriteLine("===== 6. ref keyword & out keyword in parameter of method ======");
            Console.WriteLine(" Research on them and write example ");
            Console.WriteLine("\n");
            //-파라메터  ref 와 out 의 차이점 


            // out 은 값을 assign 하지 않아도 됨(flexible)
            // out : Argument is not initialized and it must be initialized in the method

            int outValue = 4;
            string dodam1 = "This is dodam1";
            string dodam2 = "This is dodam2";

            OutMethod(out outValue,dodam1,dodam2);
            Console.WriteLine("int outValue = 4; \nstring dodam1 = \"This is dodam1\" \nstring dodam2 = \"This is dodam2\"");
            Console.WriteLine("\n");

            Console.WriteLine("Pass parameter into method (OutMethod)");
            Console.WriteLine("OutMethod(out outValue,dodam1, dodam2);");
            Console.WriteLine("\n");
            Console.WriteLine("int outValue = {0}, \nstring dodam1 = {1}, \nstring dodam2 = {2} ",outValue,dodam1,dodam2);
            Console.WriteLine("\n");
            Console.WriteLine("Out parameter is changed if it is previously assigned (or assigned if it is not assigned previously");
            Console.WriteLine("Non-out parameters (dodam1, dodam2) is not changed");

            Console.WriteLine("\n");

            //ref 는 반드시 assign 해줘야 함(= should be innitialized)
            //ref : Argument is already initialized and it can be read and updated in the method.

            //int refValue;
            //RefMethod(ref refValue); <= 에러남

            int refValue = 77;
            int a = 200;
            int b = 300;

            RefMethod(ref refValue,ref a,ref b);
            Console.WriteLine("int refValue = 77; \nint a = 200; \nint b = 300");
            Console.WriteLine("\n");
            Console.WriteLine("Pass parameter into method (RefMethod)");
            Console.WriteLine("RefMethod(ref refValue,200,300)");
            Console.WriteLine("\n");
            Console.WriteLine("refValue= {0}", refValue);
            Console.WriteLine("\n\n");



            // 7. params keyword
            // 7-1. I want to call method this way:
            // using params keyword, define method TestParams()
            //methodTest.TestParams("abc", "xyz", "www", "http", "This", "That");
            Console.WriteLine("===== 7. params keyword ======");

            var methodTest = new MethodTest();

            Console.WriteLine("7-1. I want to call method this way: ");
            Console.WriteLine("using params keyword, define method TestStringParams() ");
            Console.WriteLine("methodTest.TestStringParams(\"abc\", \"xyz\", \"www\", \"http\", \"This\", \"That\");");
            Console.WriteLine("\n");
            Console.WriteLine("methodTest.TestStringParams(\"abc\", \"xyz\", \"www\", \"http\", \"This\", \"That\") = {0}",methodTest.TestStringParams("abc", "xyz", "www", "http", "This", "That"));

            Console.WriteLine("\n");
            Console.WriteLine("7-2. I want to call method this way: ");
            Console.WriteLine("using params keyword, define method TestObjectParams() ");
            Console.WriteLine("methodTest.TestObjectParams(\"abc\", 1, \"www\", true, \"This\", 12.98M)");
            Console.WriteLine("\n");
            Console.WriteLine("methodTest.TestObjectParams(\"abc\", 1, \"www\", true, \"This\", 12.98M) = {0} ", methodTest.TestObjectParams("abc", 1, "www", true, "This", 12.98M));

            Console.WriteLine("\n\n");

            // 8. Define Class Elements about following Product class

            Console.WriteLine("===== 8. Define Class ======");









            // 10. Research on struct and make example (copy and paste is allowed)
            // Can you tell me the difference between class and struct? 

            Console.WriteLine("REFERENCE (1) : https://www.codeproject.com/Articles/265755/Difference-between-Class-and-Structure-in-NET");
            // 1) Classes are Reference types and Structures are Values types.


            // Struct

            // In C#, a structure is a value type data type. 
            // It helps you to make a single variable hold related data of various data types. 
            // The struct keyword is used for creating a structure.
            MyClass _myClassObject1 = new MyClass();
            _myClassObject1.DataMember = 10;
            MyClass _myClassObject2 = _myClassObject1;
            _myClassObject2.DataMember = 20;

        }


        // # 3 Method
        public static int[] removeDuplicate(int[] a)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < a.Length-1 ; i++)
            {
                if (a[i] != a[i + 1])
                {
                    result.Add(a[i]);
                }
            }

            result.Add(a[a.Length - 1]);
            return result.ToArray();
        }


        // # 6 Method
        static void OutMethod(out int i, string a, string b)
        {
            i = 37;
            a = "This is a";
            b = "This is b";
        }

        static void RefMethod(ref int i,ref int a, ref int b)
        {
            i = a + b;
            i = 30;
        }



    

        /*public static string GetNextName(ref int id)
        {
            string returnText = "Next-" + id.ToString();
            id += 1;
            return returnText;
        }

        public static string GetNextNameByOut(out int id)
        {
            id = 1;
            string returnText = "Next-" + id.ToString();
            return returnText;
        } */
    }


    class MyClass
    {
        public int DataMember;  //By default, accessibility of class data members 
                                //will be private. So I am making it as Public which 
                                //can be accessed out side of the class.
    }

}
