using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTutorials
{
    class Assignment11
    {
        public void test()
        {
            // 1. Find Eager Loading example here 
            // http://www.entityframeworktutorial.net/eager-loading-in-entity-framework.aspx and pratcise


            // 2. Can you say difference between eager loading and lazy loading? What is benefit of each one?
            /*
             * 
             * Eager Loading, Lazy Loading and Explicit Loading -- 
             * refer to the process of loading the related entities. 
             * They define when to load the related entities or child entities.
             */

            /*Eager Loading helps to load all your needed entities at once; 
             * i.e., all your child entities will be loaded at single database call. 
             * This can be achieved, using the Include method, which returns the related entities 
             * as a part of the query and a large amount of data is loaded at once.
             * For example, you have a User table and a UserDetails table (related entity to User table), 
             * then you will write the code given below. 
             * 
             * Here, we are loading the user with the Id equal to userId along with the user details. 
             * User usr = dbContext.Users.Include(a => a.UserDetails).FirstOrDefault(a => a.UserId == userId); 
             */




            /*It is the default behavior of an Entity Framework, 
             * where a child entity is loaded only when it is accessed for the first time. 
             * It simply delays the loading of the related data, until you ask for it.
             * 
             * For example, when we run the query given below, 
             * 
             * UserDetails table will not be loaded along with the User table. 
             * User usr = dbContext.Users.FirstOrDefault(a => a.UserId == userId); 
             * 
             * It will only be loaded when you explicitly call for it, as shown below. 
             * UserDeatils ud = usr.UserDetails; 
             */

            // 3. Currently, there are several courses on table "Course" where all teacher Id is null. 
            // Also none of teacher is added to table "Teacher". 
            // (If you see relationship between course and teacher, course is referencing teacher).

            
       




        }
    }
}
