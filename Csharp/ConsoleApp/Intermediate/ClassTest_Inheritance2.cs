using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Intermediate
{
    public class Asset2
    {
        public string Name;
    }

    public class Stock2 : Asset2   // inherits from Asset2
    {
        public long SharesOwned;
    }

    public class House2 : Asset2  // inherits from Asset2
    {
        public decimal Mortgage;
    }
}
