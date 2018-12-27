using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Beginner
{
    public class DataType
    {
        public void Test()
        {
            // ref: https://www.programiz.com/csharp-programming/variables-primitive-data-types

            // Datatype

            // 1. Value Type: Predifened datatype
            // 모든 struct 는 value type
            // char 는 value type

            // 2. reference Type : User Defined datatype (Class)
            // 모든 String 은 reference type (string는 char의 array 이기때문)
            // 모든 array 는 refernece type (ex: long[] int[] datatime[]) 
            
        
          
            

            // Bool
            bool b = true;

            // Numeric
            short sh = -32768;

            int i = 2147483647;
            // short의 2배

            long l = 1234L;      // L suffix
            // int 의 2배 (L이 없으면 int로 인식)


            float f = 123.45F;   // F suffix
            // float 는 VB 에서는 SINGLE (DOUBLE 은 2배)


            double d1 = 123.45;
            double d2 = 123.45D; // D suffix
            // without D suffix, will be defined as float!

            decimal d = 123.45M; // M suffix
            //저장 범위가 제일 넓음 

            // Char/String
            char c = 'A';
            string s = "Hello";

            string a = new string(new char[] { 'H', 'e', 'l', 'l', 'o' });
            // value type 이 아님, reference type 임!!!
            // refernece type 이지만 value type  처럼 간편하게 쓸 수 있음. 

            // DateTime  2011-10-30 12:35
            DateTime dt = new DateTime(2011, 10, 30, 12, 35, 0);

            // Min and Max

            // Nullable
            int? ivalue = null;
            ivalue = 101;
            // value type can contain null
            // int nulltype = null; ← 에러발생 (null 은 refence 지만 메모리 포인터 (=주소) 가 없음)

            bool? bvalue = null;

            //int? to int
            Nullable<int> j = null;
            j = 10;
            int k = j.Value;
        }
    }
}
