using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Beginner
{
    public class OperatorTest
    {
        public void Test()
        {
            // 1. arthmetic operator
            double firstNumber = 14.40, secondNumber = 4.60, result;
            int num1 = 26, num2 = 4, rem;

            // Addition operator
            result = firstNumber + secondNumber;
            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);

            // Subtraction operator
            result = firstNumber - secondNumber;
            Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);

            // Multiplication operator
            result = firstNumber * secondNumber;
            Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);

            // Division operator
            result = firstNumber / secondNumber;
            Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);

            // Modulo operator
            rem = num1 % num2;
            Console.WriteLine("{0} % {1} = {2}", num1, num2, rem);

            // 2. relational operator
            bool result2;
            int firstNumber2 = 10, secondNumber2 = 20;

            result2 = (firstNumber2 == secondNumber2);
            Console.WriteLine("{0} == {1} returns {2}", firstNumber, secondNumber, result2);

            result2 = (firstNumber2 > secondNumber2);
            Console.WriteLine("{0} > {1} returns {2}", firstNumber, secondNumber, result2);

            result2 = (firstNumber2 < secondNumber2);
            Console.WriteLine("{0} < {1} returns {2}", firstNumber, secondNumber, result2);

            result2 = (firstNumber2 >= secondNumber2);
            Console.WriteLine("{0} >= {1} returns {2}", firstNumber, secondNumber, result2);

            result2 = (firstNumber2 <= secondNumber2);
            Console.WriteLine("{0} <= {1} returns {2}", firstNumber, secondNumber, result2);

            result2 = (firstNumber2 != secondNumber2);
            Console.WriteLine("{0} != {1} returns {2}", firstNumber, secondNumber, result2);

            // 3. ? operator
            int number = 10;
            string result3;

            result3 = (number % 2 == 0) ? "Even Number" : "Odd Number";
            // 전자가 참이면 "Even Number"
            // else "Odd Number"

            // if(number%2 == 0)
            //result3 = "Even Number";
            // else
            // result3="Odd Number";

            Console.WriteLine("{0} is {1}", number, result3);

            // 4. ?? operator
            bool? b = null;

            //bool c=b == null ? true:false;
            bool c = b ?? true;
            // b가 null 이면 c에 true 넣음

            // ?. 숙제



        }
    }
}
