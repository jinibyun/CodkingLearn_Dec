using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Intermediate
{
    public class ClassTest_Indexer
    {
        string[] words = "The quick brown fox".Split();
       
        /*
        Indexers provide a natural syntax for accessing elements in a class or struct that
        encapsulate a list or dictionary of values. Indexers are similar to properties, but are
        accessed via an index argument rather than a property name              
        */

        public string this[int wordNum]      // indexer
        {
            get { return words[wordNum]; }
            set { words[wordNum] = value; }
        }
    }
}
