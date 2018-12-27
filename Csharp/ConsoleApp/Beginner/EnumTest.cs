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
        Jeju = 10,   // 10
        Toronto = 7  //7
    }


    public class EnumTest
    {
        City myCity;

        public void Test()
        {
            // Access to enum
            myCity = City.Toronto;

            // enum to int casting
            int cityValue = (int)myCity;

            if (myCity == City.Toronto) // enum comparison
            {
                Console.WriteLine("Welcome to " + myCity.ToString() + 
                    "\n City Code is : " + cityValue.ToString());
            }
        }
    }
}
