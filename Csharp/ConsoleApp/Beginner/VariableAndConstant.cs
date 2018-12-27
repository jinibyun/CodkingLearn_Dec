using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Beginner
{

    // FULLSCREEN: SHIFT + ALT + ENTER
    public class VariableAndConstant
    {
        // global in class
        int globalVar;

        // difference between constant and readonly
        


        const int MAXVALUE = 1024;

        // MAXVALUE = 5; ← 상수는 한번 ASSIGN 후 끝. 
        readonly int Max;

        public VariableAndConstant()
        {
            Max = 1;
            // Readonly 는 생성자 메소드 (=컨스트럭터) 에서만 유효 (쓸수 있음)
            Max = 4;
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
