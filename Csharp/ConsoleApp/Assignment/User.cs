using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Assignment
{
    public class User
    {
        public string Name;

        public string Location;

        public int Age;

        public User(string name,string location, int age)
        {
            Name = name;
            Location = location;
            Age = age;
        }

        public void GetUserDetails()

        {
            Console.WriteLine(" **** User's Detail **** ");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);

        }
    }
}
