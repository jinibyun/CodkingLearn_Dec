using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Assignment
{
    class InternalUser
    {
        public string Name;

        public string Location;

        public int Age;

        public string Level;
        internal InternalUser(string name, string location, int age, string level)
        {
            Name = name;
            Location = location;
            Age = age;
            Level = level;
        }

        internal void GetInternalUserDetails()

        {
            Console.WriteLine(" **** ProtectedUser's Detail **** ");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);

        }
    }
}
