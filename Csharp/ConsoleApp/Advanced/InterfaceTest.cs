using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Advanced
{
    public class Document
    {
        public override string ToString()
        {
            return "This is a document contents";
        }
    }

    public interface IMachine
    {
        void Print(Document d);
        void Fax(Document d);
        void Scan(Document d);
    }

    public class MultiFunctionPrinter : IMachine
    {
        public void Print(Document d)
        {
            Console.WriteLine(string.Format("Multi Printing.....{0}", d.ToString()));
        }

        public void Fax(Document d)
        {
            Console.WriteLine(string.Format("Multi Faxing.....{0}", d.ToString()));
        }

        public void Scan(Document d)
        {
            Console.WriteLine(string.Format("Multi Scanning.....{0}", d.ToString()));
        }
    }

    public class OldFashionedPrinter : IMachine
    {
        public void Print(Document d)
        {
            Console.WriteLine(string.Format("Old Fashion Printing.....{0}", d.ToString()));
        }

        public void Fax(Document d)
        {
            Console.WriteLine("Old Fashion Machine does not support faxing");
        }

        public void Scan(Document d)
        {
            Console.WriteLine("Old Fashion Machine does not support scanning");
        }
    }
}
