using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Beginner
{
    public class StringTest
    {
        public void Test()
        {
            // immutable
            string s1 = "C#";
            string s2 = "Programming";

            // char 
            char c1 = 'A';
            char c2 = 'B';

            // concatenation
            string s3 = s1 + " " + s2;
            Console.WriteLine("String: {0}", s3);

            // substring
            string s3substring = s3.Substring(1, 5);
            Console.WriteLine("Substring: {0}", s3substring);

            string s = "C# Studies";

            // String is array of char
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, s[i]);
            }

            // string to charArray
            string str = "Hello";
            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }

            // char array to string
            char[] charArray2 = { 'A', 'B', 'C', 'D' };
            s = new string(charArray2);

            Console.WriteLine(s);

            // one char has one ASCII code which is actual number value. Therefore it can be operated with plus, minus, multiply and divide
            // NOTE: char operation is different from string operation
            // ref: 
            char c11 = 'A';
            char c22 = (char)(c11 + 3);
            Console.WriteLine(c22);

            // string and stringBuilder
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= 26; i++)
            {
                sb.Append(i.ToString());
                sb.Append(System.Environment.NewLine);
            }
            string sbstring = sb.ToString();

            Console.WriteLine(sbstring);
        }
    }
}
