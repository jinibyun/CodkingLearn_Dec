using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Beginner
{
    public class yieldTest
    {
        public void Test()
        {
            foreach (int num in GetNumber())
            {
                Console.WriteLine(num);
            }
        }

        IEnumerable<int> GetNumber()
        {

            // "yield return" returns one by one. Not in total
            // When data is huge. Lazy calculation
            // Mostly it will be used with collection
            yield return 10;  
            yield return 20;  
            yield return 30;                
        }
    }
}
