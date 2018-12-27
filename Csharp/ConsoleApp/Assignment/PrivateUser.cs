using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Assignment
{
    class PrivateUser
    {
       private string Name;
       private string Location;
       private int Age;
       private string Code;


        PrivateUser(string name, string location, int age, string code)
        {
            Name = name;
            Location = location;
            Age = age;
            Code = code;
        }


        void GetPriveUserDetails()
        {
            Console.WriteLine(" **** Private User's Detail **** ");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);

        }
    }
}
