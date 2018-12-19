using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Beginner
{
    public class VariableAndConstant
    {
        // global in class
        int globalVar;

        // difference between constant and readonly
        const int MAXVALUE = 1024;
        readonly int Max;

        public VariableAndConstant()
        {
            Max = 1;
        }
        public void Test()
        {
            // local
            int localVar;        
            localVar = 100;

            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);
        }
    }
}
