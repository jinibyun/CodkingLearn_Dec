using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Intermediate
{
    public class ClassTest_Basic2
    {
        public ClassTest_Basic2()
        {
            BenchmarkShare = 99;
        }

        decimal currentPrice;           // The private "backing" field
        public decimal CurrentPrice     // The public property
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }

        decimal sharesOwned;           // The private "backing" field
        public decimal SharesOwned     // The public property
        {
            get { return sharesOwned; }
            set { sharesOwned = value; }
        }

        // automatic property
        public decimal BenchmarkPrice { get; set; }


        decimal benchmarkPrice;
        public decimal BenchemarkPrice
        {
            get;
            set;
        }

        // automatic property : readonly (public and private)
        public int BenchmarkShare { get; }

        // readonly property
        public decimal Worth
        {
            get { return currentPrice * sharesOwned; }
        }

    }
}
