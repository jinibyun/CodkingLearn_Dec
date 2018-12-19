using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Intermediate
{
    public class Asset3
    {
        public string Name;
    }

    public class Stock3 : Asset3   // inherits from Asset3
    {
        public long SharesOwned;
    }

    public class House3 : Asset3   // inherits from Asset3
    {
        public decimal Mortgage;
    }
}
