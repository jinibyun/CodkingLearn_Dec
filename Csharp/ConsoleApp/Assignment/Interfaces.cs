using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Assignment
{
    public class Documents
    {


        public string subject { get; set; }
        //public string content;

        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                if (value != "")
                    content = value;
                else
                    content = "blank page";
            }
        }

        public string content;

        public Documents(string su,string co)
        {
            subject = su;
            Content = co;
        }


        public override string ToString()
        {
            return String.Format("Subject: {0} \n Content: {1:c2} \n\r", subject, content);
        }
    }
    public interface IMachines
    {
        void Print(Documents d);
        void Fax(Documents d);
        void Scan(Documents d);
    }

    public class MultiFunctionPrinters : IMachines
    {
        public void Print(Documents d)
        {
            Console.WriteLine(string.Format("Printing.....{0}", d.ToString()));
        }

        public void Fax(Documents d)
        {
            Console.WriteLine(string.Format("Faxing.....{0}", d.ToString()));
        }

        public void Scan(Documents d)
        {
            Console.WriteLine(string.Format("Scanning.....{0}", d.ToString()));
        }
    }

    public class OldFashionedPrinters : IMachines
    {
        public void Print(Documents d)
        {
            Console.WriteLine(string.Format("Old Fashion Printing.....{0}", d.ToString()));
        }

        public void Fax(Documents d)
        {
            Console.WriteLine("Old Fashion Machine does not support faxing");
        }

        public void Scan(Documents d)
        {
            Console.WriteLine("Old Fashion Machine does not support scanning");
        }
    }
}
