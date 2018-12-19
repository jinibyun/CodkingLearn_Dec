using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Advanced
{
    // To make extension method
    // 1. It must be defined static class
    // 2. this keyword at first parameter. The type with this keyword will be extended.

    public static class ExtensionMethodTest
    {
        // String extension method with "NO" parameter
        public static string ToChangeCase(this String str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var ch in str)
            {
                if (ch >= 'A' && ch <= 'Z')
                    sb.Append((char)('a' + ch - 'A'));
                else if (ch >= 'a' && ch <= 'x')
                    sb.Append((char)('A' + ch - 'a'));
                else
                    sb.Append(ch);
            }
            return sb.ToString();
        }

        // String extension method with one parameter (char type)
        public static bool Found(this String str, char ch)
        {
            int position = str.IndexOf(ch);
            return position >= 0;
        }
    }
}
