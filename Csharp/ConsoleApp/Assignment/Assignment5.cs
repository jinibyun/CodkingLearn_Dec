using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Assignment
{
    // 1. OVERRIDE

        //1) Make three classes: Computer, Desktop and Laptop
    public class Computer
    {
        //2) Computer class should have following method
        //TurnOn(): It must be virtual method
        //TurnOff() : It must be non-virtual method

        public virtual string TurnOn()
        {
            return "The computer is turning on ";
        }

        public string TurnOff()
        {
            return "The system is turning off";
        }
    }
      
    public class Desktop : Computer
    {
        // 3)  In Desktop class and Laptop class, they should override TurnOn method
        public override string TurnOn()
        {
            return "The desktop is turning on ";
        }
    }


  
    public class Laptop
    {

    }



    // POLIMORPHISM
    class Cafe
    {
        public Cafe()
        {
            Console.WriteLine("This is Cafe (Constructor)");
        }
        public void HavingCoffee()
        {
            Console.WriteLine("I am having a cup of coffee at the cafe");
        }
        public void Studying()
        {
            Console.WriteLine("I am studying in the cafe");
        }
        public virtual void Meeting()
        {
            Console.WriteLine("I am meeting a friend in the cafe");
        }
    }

    class Starbucks : Cafe
    {
        public Starbucks()
        {
            Console.WriteLine("This is Starbucks (Constructor)");
        }
        public new void Studying()
        {
            Console.WriteLine("I am studying at the starbucks");
        }
        public override void Meeting()
        {
            Console.WriteLine("I am meeting my friend in the starbucks");
        }
    }


    // 5. LINKED LIST

    class Cookie
    {
        public string category { get; set; }
        public double price;

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                    price = value;
                else
                    price = 0.0;
            }
        }

        public Cookie(string ca, double pr)
        {
            price = pr;
            category = ca;
        }

        public override string ToString()
        {
            return String.Format("CookieName: {0} Price: {1:c2} \n", category, price);
        }

    }

    class Assignment5
    {
        public void Test()
        {
            Console.WriteLine("==== Assignment 5 Start here ====");
            Console.WriteLine("\n");
            Console.WriteLine("1. OVERRIDE");
            Computer mycom = new Computer();
            Console.WriteLine(mycom.TurnOn());

            Desktop mydetop = new Desktop();
            Console.WriteLine(mydetop.TurnOn());
            Console.WriteLine("\n");


            Console.WriteLine("2. POLIMORPHISM");


            /* Polymorphism plays an important role in allowing the different objects to share the same external interface although the implementation may be different. 
            Thus, it is seen that Polymorphism helps to design the extensible software components as we can add new objects to the design without rewriting the existing methods.*/

            // POLIMORPHISM is 'late binding' during runtime

            //1 command may invoke different implementation for the different related objects.



            /* Base classes may define and implement virtual methods, and derived classes can override them, 
            which means they provide their own definition and implementation. At run-time, when client code calls the method,
            the CLR looks up the run-time type of the object, and invokes that override of the virtual method. 
            Thus in your source code you can call a method on a base class, and cause a derived class's version of the method to be executed.*/

            // https://www.codeproject.com/Articles/1445/Introduction-to-inheritance-polymorphism-in-C

            Console.WriteLine("\n");

            Console.WriteLine("3. POLIMORPHISM TEST");
            Console.WriteLine("Cafe myCafe = new Cafe();");
            Cafe myCafe = new Cafe();
            myCafe.HavingCoffee();
            myCafe.Meeting();
            myCafe.Studying();

            Console.WriteLine("\n");
            Console.WriteLine("Cafe yourCafe = new Starbucks();");
            Console.WriteLine("\n");

            Cafe yourCafe = new Starbucks();
            // This is Cafe (Constructor)
            // This is Starbucks (Constructor)




            yourCafe.HavingCoffee();
            Console.WriteLine("\n");
            // call HavingCofee() and find that the method that's executed is the base class method (Cafe) 
            // "I am having a cup of coffee in the cafe"


            yourCafe.Meeting();
            Console.WriteLine("\n");
            // call Meeting () and the derived class method (starbucks) has got called. 
            //This is because in the base class the method is prototyped as virtual void 
            //"I am meeting my friend in the starbucks"

            yourCafe.Studying();
            Console.WriteLine("\n");
            // the base class (Cafe) method gets called. 
            // the derived class (Starbucks) has not even implemented the method.(only havingcoffee + meeting)
            // "I am studying in the cafe"


            //4.What is generic class? Can you answer to it on questioned in job interview?

            Console.WriteLine("4. GENERIC CLASS");
            Console.WriteLine("\n");

            // The Generics is another mechanism offered by the Common Language Runtime (CLR) and programming languages that provide one more form of code re-use and algorithm re-use.

            /*Generics provide a code template for creating type-safe code without referring to specific data types.
             * Generics allow you to realize type safety at compile time.They allow you to create a data structure without committing to a specific data type.
             * When the data structure is used, however, the compiler ensures that the types used with it are consistent for type safety. 
             * I want to discuss two benefits of generics, one is type safety and another is performance before explaining with an example.
             */



            // 5.Specifically, define generic class about LinkedList.Research on it and exercise(copy and paste is allowed)

            Console.WriteLine("5.LINKEDLIST");

            Cookie cookie1 = new Cookie("Chocolate", 1.74);
            Cookie cookie2 = new Cookie("Greentea", 2.5);
            Cookie cookie3 = new Cookie("White", 1.74);
            Cookie cookie4 = new Cookie("Vanilla", 2.5);
            Cookie cookie5 = new Cookie("Caramel", 2.5);
            Cookie cookie6 = new Cookie("Coffee", 1.74);
            Cookie cookie7 = new Cookie("Mint", 2.5);

            LinkedList<Cookie> CookieBox = new LinkedList<Cookie>();

            CookieBox.AddLast(cookie1);
            CookieBox.AddLast(cookie2);
            CookieBox.AddLast(cookie3);
            CookieBox.AddLast(cookie4);


            CookieBox.AddFirst(cookie5);
            CookieBox.AddFirst(cookie6);
            CookieBox.AddFirst(cookie7);

            DisplayBox(CookieBox);

            Console.WriteLine("\n");

            //6.What is the difference between LinkedList and List? 
            //Can you answer to it on questioned in job interview?

            Console.WriteLine("6.LINKEDLIST vs LIST");

            /* There is one benefit to LinkedList over List 
             * since the List is backed by an internal array, 
             * it is allocated in one contiguous block. 
             * If that allocated block exceeds 85000 bytes in size, 
             * it will be allocated on the Large Object Heap, a non-compactable generation.
             * Depending on the size, this can lead to heap fragmentation, a mild form of memory leak. */

            /* LinkedList<T> is only at it's most efficient if you are accessing sequential data (either forwards or backwards) -
             * random access is relatively expensive since it must walk the chain each time (hence why it doesn't have an indexer). 
             * However, because a List<T> is essentially just an array (with a wrapper) random access is fine.

             * List<T> also offers a lot of support methods - Find, ToArray, etc; 
             * however, these are also available for LinkedList<T> with .NET 3.5/C# 3.0 via extension methods - 
             * so that is less of a factor.*/

            Console.WriteLine("\n");

            //7.On code(Program.cs), please exercise interface. 
            //It depicts basic concept of interface and class. 
            //(Print, fax and scanner)
            Console.WriteLine("7. INTERFACE");


            Documents docu1 = new Documents("Hello, Dodam", "How are you??");
            Documents docu2 = new Documents("No Reply Message", "");
            IMachines machine = new MultiFunctionPrinters();

            machine.Fax(docu1);
            machine.Print(docu1);
            machine.Scan(docu1);

            machine.Fax(docu2);
            machine.Print(docu2);
            machine.Scan(docu2);

            Console.WriteLine("\n");

            // 8. What is the difference between class and interface?

            Console.WriteLine("8. CLASS vs INTERFACE");
            Console.WriteLine("\n");
            Console.WriteLine("Interface - describe the behavior");
            /*an interface is a set of rules. 
             * It regulates that certain methods, delegates, and/or events 
             * must be defined. */


            Console.WriteLine("Class - do the behavior");
            /*A class extending another class inherits the behavior. 
             *Implementing an interface just says it need to behave that way,
             * but the class still has to know the how-to.*/

            // http://www.jordanirwin.net/2014/09/01/csharp-interface-vs-class/
            Console.WriteLine("\n");

            // 9. The reason why we use interface.
            Console.WriteLine("9. USAGE OF INTERFACE");
            Console.WriteLine("\n");
            /* Interfaces are useful because they provide contracts that 
             * objects can use to work together without needing to know anything else about each other.*/


            // 다중상속
            /*  An interface in C# is similar to an abstract class in which all the methods are abstract. 
            However, a class or struct can implement multiple interfaces, but a class can inherit only a single class, abstract or not. 
            Therefore, by using interfaces, you can include behavior from multiple sources in a class.*/

            // https://www.c-sharpcorner.com/UploadFile/d0e913/abstract-class-interface-two-villains-of-every-interview756/
            Console.WriteLine("1) To allow a class to inherit multiple behaviors from multiple interfaces.");

            Console.WriteLine("2) To avoid name ambiguity between the methods of the different classes as was in the use of multiple inheritance in C++.");

            Console.WriteLine("3) To allow Name hiding. Name hiding is the ability to hide an inherited member name from any code outside the derived class..");
            Console.WriteLine("\n");
            /* Interfaces are to coding objects like a plug is to household wiring. 
             * Would you solder your radio directly to your house wiring? How about your vacuum cleaner? 
             * Of course not. The plug, and the outlet it fits into, form the "interface" between your house wiring and the device that needs the power from it. 
             * Your house wiring needs to know nothing about the device other than it uses a three-prong grounded plug and requires electrical power at 120VAC <=15A.
             * Conversely, the device requires no arcane knowledge of how your house is wired, other than that it has one or more three-prong outlets conveniently located that provide 120VAC <=15A.

             * Interfaces perform a very similar function in code. An object can declare that a particular variable, parameter or return type is of an interface type. 
             * The interface can't be instantiated directly with a new keyword, but my object can be given, or find, the implementation of that interface that it will need to work with. 
             * Once the object has its dependency, it doesn't have to know exactly what that dependency is, it just has to know it can call methods X, Y and Z on the dependency. 
             * Implementations of the interface don't have to know how they will be used, they just have to know they will be expected to provide methods X, Y and Z with particular signatures.*/

            // https://www.codeproject.com/Articles/11155/Abstract-Class-versus-Interface
            // https://softwareengineering.stackexchange.com/questions/108240/why-are-interfaces-useful

            // 10.There are certain rule to define interface. 
            // For example, interface cannot have implementation code.
            // only definition.
            // What else are there? It is very important to know. Please describe them.
            Console.WriteLine("10. DEFINE INTERFACE RULE");
            Console.WriteLine("\n");

            Console.WriteLine("1) No access modifier is allowed with interface methods.");
            Console.WriteLine("2) We must declare these methods as public in derived classes, when we provide implementations to these methods.");
            Console.WriteLine("3) We cannot declare these methods as static.");
            // https://www.c-sharpcorner.com/UploadFile/d0e913/abstract-class-interface-two-villains-of-every-interview756/
        }

        private static void DisplayBox(LinkedList<Cookie> cbox)
{

Console.WriteLine("------- CookieBox -------");

foreach (var thing in cbox)
{
Console.Write($"{thing}");
}
Console.WriteLine("\n------------------------");
Console.WriteLine("\n");
}

}
}
