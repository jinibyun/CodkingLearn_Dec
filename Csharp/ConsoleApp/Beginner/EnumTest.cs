using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Beginner
{
    public enum City
    {
        Seoul,   // 0
        Daejun,  // 1
        Busan = 5,  // 5
        Jeju = 10   // 10
    }


    public class EnumTest
    {
        City myCity;

        public void Test()
        {            
            // Access to enum
            myCity = City.Seoul;

            // enum to int casting
            int cityValue = (int)myCity;

            if (myCity == City.Seoul) // enum comparison
            {
                Console.WriteLine("Welcome to Seoul");
            }
        }
    }
}
