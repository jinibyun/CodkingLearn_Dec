using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Assignment
{
    class Product
    {
        // 1. Define member 5 fields
        // One of them. Define 4 more with private access modifier

        private string productName;
        private double productPrice;
        private string productCode;
        private string productCategory;
        private string productColor;


        // 2.
        // Define constructor and initialize above 5 field with parameter
        public Product(string pname, double pprice, string pcode, string pcategory, string pcolor)
        {
            productName = pname;
            productPrice = pprice;
            productCode = pcode;
            productCategory = pcategory;
            productColor = pcolor;
        }

        public enum Status
        {
            InStock = 1,
            OutofStock = 2
        }
        // 3. Let's define there are two kinds of product status: InStock, OutofStock
        // Define these two as enum type



        // 4. 5 field should be accessed through public property. Define 5 public property with get and set 
    }
}
