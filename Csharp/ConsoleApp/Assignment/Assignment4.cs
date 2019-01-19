using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Assignment
{
    // 1. Define date time array and initialize them with 4-5 values 
    public class dt_Indexer
    {
        DateTime[] dtBirthday = new DateTime[]
        {new DateTime(1986,07,28),
         new DateTime(1984,06,14),
         new DateTime(1992,05,15),
         new DateTime(2001,08,30)};

        // and expose it with "indexer"
        public DateTime this[int num]      // indexer
        {
            get { return dtBirthday[num]; }
            set { dtBirthday[num] = value; }
        }
    }

    public class MainCategory
    {
        public int Id;
        public string Name;

        public MainCategory(int i,string n)
        {
            Id = i;
            Name = n;
        }

        public virtual void Display()
        {
            Console.WriteLine("This is MainCategory Class");
        }

    }

    public class SubCategory : MainCategory
    {
        public int SubId;
        public string SubName;

        public SubCategory(int i, string n) : base(i,n)
        {
            SubId = i;
            SubName = n;
        }
        public override void Display()
        {
            Console.WriteLine("This is SubCategory Class");
        }

        public void DisplaySub()
        {
            Console.WriteLine("SubCategory ID: {0}, SubCategory Name: {1}", SubId, SubName);
        }
    }

    public class Products : SubCategory
    {
        public int ProductId;
        public string ProductName;

        public Products(int i, string n) : base(i, n)
        {
            ProductId = i;
            ProductName = n;
        }

        public override void Display()
        {
            Console.WriteLine("This is Products Class");
        }

        public void DisplayPro()
        {
            Console.WriteLine("Product ID: {0}, Product Name: {1}",ProductId,ProductName);
        }
    }




    public static class StClass
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }


    public class Assignment4
    {
        

        

        // 3. Define these classes using "inheritance"
        public void Test()
        {
            Console.WriteLine("==== Assignment 4 Start here ====");
            Console.WriteLine("\n");



            Console.WriteLine("Question 1 : Indexer ");

            var Qs1 = new dt_Indexer();
            Console.WriteLine("Qs1[2] : {0}",Qs1[2]);       // 
            Qs1[2] = new DateTime(2008, 12, 25);
            Console.WriteLine("Qs1[2] : {0}",Qs1[2]);       //   

            Console.WriteLine("\n");





            Console.WriteLine("Question 2 : Indexer definition ");
            //2. What would you answer to "indexer" definition when you are asked in technical interview?

            // Answer
            // Indexers allow instances of a class or struct to be indexed just like arrays, 
            // they are most frequently implemented in types whose primary purpose is to encapsulate an internal collection or array.


            // If I have several thousands of objects, and I need the one before last. 
            // Instead of iterating over all of the items in the collection, you simply use the index of the object you want.

            Console.WriteLine("\n");


            Console.WriteLine("Question 3 : Class Inheritance");

            int id = 27;
            string name = "Dodam";
            MainCategory cat1 = new MainCategory(id, name );
            Console.WriteLine("cat1.Id : {0}  cat1.Name: {1}", cat1.Id, cat1.Name);

            int sid = 34;
            string sname = "Lidia";
            SubCategory cat2 = new SubCategory(sid, sname);
            Console.WriteLine("cat2.SubId : {0}  cat2.SubName: {1}", cat2.SubId, cat2.SubName);


            int pid = 4532;
            string pname = "ABC";
            Products pro1 = new Products (pid, pname );
            Console.WriteLine("pro1.ProductId : {0}  pro1.ProductName: {1}", pro1.ProductId, pro1.ProductName);

            Console.WriteLine("\n");


            Console.WriteLine("Question 4 : Upcast & Downcast Practice");

            //SubCategory s1 = new SubCategory();


            // Shape s = new Circle(100, 100);


            //We have cast Circle to the type Shape. This is perfectly legal code(as we saw in the Polymorphism example).
            //This is possible, because Circle has been derived from Shape and you expect all methods and properties of Shape to exist in Circle.
            //Executing the Draw method by doing s.Draw() gives the following output:




            // UPCASTING
            MainCategory m1 = new MainCategory(id, name);
            Console.WriteLine("Before UPCASTING");
            Console.WriteLine("m1.Display();");
            m1.Display();
            Console.WriteLine("\n");

            m1 = new SubCategory(sid,sname);

            Console.WriteLine("After UPCASTING 1");
            Console.WriteLine("SubCategory -> MainCategory");
            Console.WriteLine("MainCategory m1 = new SubCategory(sid,sname);");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("m1.Display();");
            m1.Display();
           
            Console.WriteLine("\n");

            m1 = new Products(pid, pname);
            Console.WriteLine("After UPCASTING 2");
            Console.WriteLine("Products -> SubCategory");
            Console.WriteLine("SubCategory s1 = new Products(pid, pname);");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("m1.Display();");
            m1.Display();

            Console.WriteLine("\n\n");

            // DOWNCAST
            //SubCategory s2 = new SubCategory(sid, sname);
            Console.WriteLine("This is DOWNCASTING 1");
            Console.WriteLine("MainCategory -> SubCategory");
            MainCategory m2 = new SubCategory(70, "sub");
            m2.Display(); // Result is 'This is SubClass' however, cannot call SubDisplay Method
            
            ((SubCategory)m2).DisplaySub(); // now you can call SubDisplay Method by DOWNCASTING
            Console.WriteLine("\n\n");
            /*Console.WriteLine("This is DOWNCASTING 2");
            MainCategory m3 = new MainCategory(100, "main");
            DownCasting(m3);*/


            Console.WriteLine("Question 5 : Sealed class & Static class ");

            // Static class: you cannot instantiate the class
            // A static class is very similar to non-static class, 
            // however there's one difference: a static class  can't be instantiated. In different words, you can not use the new keyword to make a variable of that class type. As a result of there's no instance variable, you access the static class members  by using class name. 
            // It is a sealed class
            // As static class is sealed, so no class can inherit from a static class.

            int st1 = StClass.Add(3, 7);
            Console.WriteLine("int st1 = {0}", st1);


            // Sealed class: you cannot inherit from the class

        }

        public static void DownCasting(MainCategory m)
        {
            SubCategory s = (SubCategory)m;
            s.DisplaySub();
        }

    }
    }

