using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Assignment
{
 // Q1. 1) define delegate which should return type of "datetime" and parameter type of "datetime" 
       // Answer 1
       delegate DateTime DodamDelegate(DateTime dt);


   


    // Q2. create new class named "DelegateAssignment"
    // Answer 2
    public class DelegateAssignment
       {

        DateTime theDay = new DateTime(2017, 1, 18);

       // Here, you will have to define method named "GetLastDateOfMonth". 
       // This method should return type of datetime with parameter type of datetime. 
        public DateTime GetLastDateOfMonth(DateTime dt)
        {          
            return new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year,dt.Month));
        } // This is method to get last day of the month


        private void Display(DodamDelegate dele1)
        {          
            Console.WriteLine("The last day of " + theDay.ToString("MMMM") + " is " +  dele1(theDay).ToShortDateString());
        } // This is method for displaying 
        


        public void methodFor2()
        {
            DateTime theDay = new DateTime(2017, 1, 18);
            Console.WriteLine("Q2,Q3 - Call DodamDelegate \n");

 // Q3. 1) declare member type of #1's delegate
        // Answer 1)
       DodamDelegate del = new DodamDelegate(GetLastDateOfMonth);
       // del Contains to pointer to method GetLastDateOfMont



//     2) how to call "del" delegate?
       // Answer 2)
       Display(del);
       Console.WriteLine("\n");
       // Display to call (show) Delegate del

        }


 // Q4. change above using "delegate" keyword

        public void methodFor4(DateTime d4)
        {
            DodamDelegate del4 = new DodamDelegate(
          delegate (DateTime dt) {
              Console.WriteLine("Q4 - Call DodamDelegate using delegate keyword \n");
              Console.WriteLine("The last Day of " + dt.ToString("MMM") + " is ");
              return new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month));
          });

            Console.WriteLine(del4(d4).ToShortDateString() + "\n");
        }
    

// Q5. change above using anonymous delegate using lambda expression

        public void methodFor5(DateTime d5)
        {
            Console.WriteLine("Q5 - Call DodamDelegate using lamda expression \n");
            Console.WriteLine("The last Day of " + d5.ToString("MMM") + " is ");
            DodamDelegate del5 = DateTime => new DateTime(d5.Year, d5.Month, DateTime.DaysInMonth(d5.Year, d5.Month));


            Console.WriteLine(del5(d5).ToShortDateString() + "\n");
        }

// Q6. change above using Func which is built-in delegate

        public void methodFor6(DateTime d6)
        {
            Console.WriteLine("Q6 - Call DodamDelegate using Func \n");
            Func<DateTime> del6 = ()=> new DateTime(d6.Year, d6.Month, DateTime.DaysInMonth(d6.Year, d6.Month));

            Console.WriteLine("The last Day of " + d6.ToString("MMM") + " is ");
            Console.WriteLine(del6().ToShortDateString() + "\n");

            //Action<DateTime> del6 = DateTime => Console.WriteLine("Last Day of " + d6.ToString("MMM") + " is " + DateTime.ToShortDateString());
            //Console.WriteLine("Q6 - Call DodamDelegate using Func \n");
            //del6(d6);
        }

// Q6 + using Action

        public void methodFor6plus(DateTime d6plus)
        {
            Action<DateTime> del6plus = DateTime => Console.WriteLine("Last Day of " + d6plus.ToString("MMM") + " is \n" + 
                new DateTime(d6plus.Year, d6plus.Month, DateTime.DaysInMonth(d6plus.Year, d6plus.Month)).ToShortDateString());
            Console.WriteLine("Q6 plus - Call DodamDelegate using Action \n");
            del6plus(d6plus);
        }

        // Q7. what is the difference between Func and Action


        /* Action is a delegate (pointer) to a method, that takes zero, one or more input parameters, 
         * but does not return anything.
         * 
         * Func is a delegate (pointer) to a method, that takes zero, one or more input parameters, 
         * and returns a value (or reference). 
         */


        public delegate void DodamsDelegate();
        public event DodamsDelegate MyDelegateEvent;
    }

    // Q8. Research on Event (You may need two classes: one for publisher, another for subscriber) 
    // and exercise here (copy and paste is allowed)

    // Event?

    /* Events are based on the publisher and subscriber model of programming. 
     * There is a type which is publisher or broadcaster which allows the type or instance of type(itself) to notify other objects
     * (which are subscribers) that something has happened.
     * 
     * Events are type(publishers) members that allow this interaction.
     */

    public delegate void SubscribeDodamsDelegate(string blogName, string articleName);
    public class BlogSubscriptionSerivce
    {
        public event SubscribeDodamsDelegate BlogSubscribeEvent;

        public void ArticleCompleted(string articleName, string blogName)
        {
            if (BlogSubscribeEvent != null)
                BlogSubscribeEvent(articleName, blogName);
        }
    }

    public class Blog
    {
        public string BlogName { get; set; }

        public BlogSubscriptionSerivce BlogSubscribtionService { get; set; }
        public Blog()
        {
            BlogSubscribtionService = new BlogSubscriptionSerivce();
        }
    }

    public class Reader
    {
        public string ReaderName { get; set; }

        public Reader(string readerName)
        {
            ReaderName = readerName;
        }

        public void SubscribeForBlog(Blog blog)
        {
            blog.BlogSubscribtionService.BlogSubscribeEvent += BlogSubscribtionService_BlogSubscribeEvent;
        }

        private void BlogSubscribtionService_BlogSubscribeEvent(string articleName, string blogName)
        {
            Console.WriteLine("{0} is read by {1} in the blog {2}", articleName, ReaderName, blogName);
        }
    }

    public class Writer
    {
        private Blog blogProp;
        public Writer(Blog blog)
        {
            this.blogProp = blog;
        }

        public void ArticleCompleted()
        {
            if (blogProp == null)
                blogProp = new Blog();

            blogProp.BlogSubscribtionService.ArticleCompleted("Dodam's Event", blogProp.BlogName);
        }
    }




    class Assignment6
{
public void Test()
{
    Console.WriteLine("==== Assignment 6 Start here ====");
    Console.WriteLine("\n");


}
}
}
