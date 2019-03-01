using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Spatial;
using System.Linq;

namespace EFTutorials
{
    internal class Program
    {
        /*
        NOTE: These examples is based on site http://www.entityframeworktutorial.net
        Based on it, more and concrete explanation and examples will be added
        */
        private static void Main(string[] args)
        {


            AssignmentTest();

            // two versions: Insert, Update and Delete

            //AddUpdateDeleteEntityInConnectedScenario();
            //AddUpdateEntityInDisconnectedScenario();





            // LinqToEntitiesQueries();
            // FindEntity();
            // XXXX();
            // ExplicitLoading();
            // ExecuteRawSQLusingSqlQuery();
            // ExecuteSqlCommand();

            //// DynamicProxy(); // skip it

            // ReadDataUsingStoredProcedure();
            
            // ChangeTracker(); // skip it
            // SpatialDataType(); // skip it
            // EntityEntry();
            // OptimisticConcurrency();
            // TransactionSupport();
            // SetEntityState();

            Console.ReadLine();
        }

        private static void AssignmentTest()
        {
            var assignment10 = new Assignment10();
            assignment10.test();


        }
        /*
        Entity Framework builds and executes INSERT, UPDATE, and DELETE statements for the entities whose EntityState is Added, Modified, or Deleted 
        when the DbContext.SaveChanges() method is called. 
        In the connected scenario, an instance of DbContext keeps track of all the entities and so, 
        it automatically sets an appropriate EntityState to each entity whenever an entity is created, modified, or deleted.
        */
        public static void AddUpdateDeleteEntityInConnectedScenario()
        {
            Console.WriteLine("*** AddUpdateDeleteEntityInConnectedScenario Starts ***");

            using (var context = new SchoolDBEntities())
            {
                //Log DB commands to console
                context.Database.Log = Console.WriteLine;

                //Add a new student and address
                var newStudent = context.Students.Add(
                    new Student()
                    {
                        StudentName = "Dodam11",
                        //StudentAddress = new StudentAddress()
                        //{
                        //    Address1 = "51 maple",
                        //    City = "torinto City",
                        //    State = "ON"
                        //}
                    }
                 );
                context.SaveChanges(); // Executes Insert command


                //var students = context.Students.ToList();
                //var foundStu = students.Where(x => x.StudentName == "Jini").FirstOrDefault();

                //if (foundStu != null)
                //{
                //    //Edit student name
                //    foundStu.StudentName = "Alex";
                //    context.SaveChanges(); // Executes Update command
                //}


                //Remove student
                //context.Students.Remove(newStudent);
                //context.SaveChanges(); // Executes Delete command
            }

            Console.WriteLine("*** AddUpdateDeleteEntityInConnectedScenario Ends ***");
        }


        /*
        the DbContext is not aware of disconnected entities 
        because entities were added or modified out of the scope of the current DbContext instance. 
        So, you need to attach the disconnected entities to a context with appropriate EntityState 
        in order to perform CUD (Create, Update, Delete) operations to the database. 
        */
        public static void AddUpdateEntityInDisconnectedScenario()
        {
            Console.WriteLine("*** AddUpdateEntityInDisconnectedScenario Starts ***");

            //disconnected entities
            var newStudent = new Student() { StudentName = "Bill" };
            var existingStudent = new Student() { StudentID = 1, StudentName = "Chris" };

            using (var context = new SchoolDBEntities())
            {
                //Log DB commands to console
                context.Database.Log = Console.WriteLine;

                context.Entry(newStudent).State = newStudent.StudentID == 0 ? EntityState.Added : EntityState.Modified;
                context.Entry(existingStudent).State = existingStudent.StudentID == 0 ? EntityState.Added : EntityState.Modified;

                context.SaveChanges(); // Executes Delete command
            }

            Console.WriteLine("*** AddUpdateEntityInDisconnectedScenario Ends ***");
        }

        /*
        Entity framework supports three types of queries: 
        1) LINQ-to-Entities
        2) Entity SQL 
        3) Native SQL 

        For testing, some students information is being inserted by calling method
        For Entity SQL and Native SQL, ref: http://www.entityframeworktutorial.net/Querying-with-EDM.aspx
       
        */
        public static void LinqToEntitiesQueries()
        {
            Console.WriteLine("*** LinqToEntitiesQueries Starts  ***");

            using (var context = new SchoolDBEntities())
            {
                // For testing
                string[] studentNames = new string[] { "Jini", "King", "Queen", "Jack", "Jack"};
                AddStudents(studentNames);

                //Log DB commands to console
                context.Database.Log = Console.WriteLine;

                //Retrieve students whose name is Bill - Linq-to-Entities Query Syntax
                var students = (from s in context.Students
                                where s.StudentName == "Jini"
                                select s).ToList();

                //Retrieve students with the same name - Linq-to-Entities Method Syntax
                var studentsWithSameName = context.Students
                    .GroupBy(s => s.StudentName)
                    .Where(g => g.Count() > 1)
                    .Select(g => g.Key);

                Console.WriteLine("Students with same name");
                foreach (var stud in studentsWithSameName)
                {
                    Console.WriteLine(stud);
                }

                //Retrieve students of standard 1
                var standard1Students = context.Students
                    .Where(s => s.StandardId == 1)
                    .ToList();
            }

            Console.WriteLine("*** LinqToEntitiesQueries Ends ***");
        }

        /*
        For LINQ Extension Methods confirmation 
        ref: http://www.entityframeworktutorial.net/querying-entity-graph-in-entity-framework.aspx
        */
        public static void FindEntity()
        {
            Console.WriteLine("*** FindEntity Starts  ***");

            using (var context = new SchoolDBEntities())
            {
                context.Database.Log = Console.WriteLine;

                var stud = context.Students.Find(7);

                Console.WriteLine(stud.StudentName + " found");
            }

            Console.WriteLine("*** FindEntity Ends ***");
        }

        /*
        Loading Related Entities
        3 kinds of Loading to memory (from database) in EF when querying over tables
        1. Eager Loading
            loads related entities as part of the query, so that we don't need to execute a separate query 
            for related entities. Eager loading is achieved using the Include() method.
            See example: http://www.entityframeworktutorial.net/eager-loading-in-entity-framework.aspx
        2. default
            default is the getting of related data.
            See example below
            Default: Lazy Loading set to true
        3. Explicit Loading
            Even with lazy loading disabled (in EF 6), it is still possible to lazily load related entities, 
            but it must be done with an explicit call. Use the Load() method to load related entities explicitly.
            See example below
        */
        public static void XXXX()
        {
            Console.WriteLine("*** LazyLoading Starts ***");

            using (var context = new SchoolDBEntities())
            {
                context.Database.Log = Console.Write;
                Student student = context.Students.Where(s => s.StudentID == 1).FirstOrDefault<Student>();

                Console.WriteLine("*** Retrieve standard from the database ***");
                Standard std = student.Standard;
            }

            Console.WriteLine("*** LazyLoading Ends ***");
        }

        public static void ExplicitLoading()
        {
            Console.WriteLine("*** ExplicitLoading Starts ***");

            using (var context = new SchoolDBEntities())
            {
                context.Database.Log = Console.Write;

                Student std = context.Students
                    .Where(s => s.StudentID == 1)
                    .FirstOrDefault<Student>();

                //Loading Standard for Student (seperate SQL query)
                context.Entry(std).Reference(s => s.Standard).Load();

                //Loading Courses for Student (seperate SQL query)
                context.Entry(std).Collection(s => s.Courses).Load();
            }

            Console.WriteLine("*** ExplicitLoading Ends ***");
        }

        public static void ExecuteRawSQLusingSqlQuery()
        {
            Console.WriteLine("*** ExecuteRawSQLusingSqlQuery Starts ***");

            using (var context = new SchoolDBEntities())
            {
                context.Database.Log = Console.Write;

                var studentList = context.Students.SqlQuery("Select * from Student").ToList<Student>();

                var student = context.Students.SqlQuery("Select StudentId, StudentName, StandardId, RowVersion from Student where StudentId = 1").ToList();
            }

            Console.WriteLine("*** ExecuteRawSQLusingSqlQuery Ends ***");
        }

        public static void ExecuteSqlCommand()
        {
            Console.WriteLine("*** ExecuteSqlCommand Starts ***");

            using (var context = new SchoolDBEntities())
            {
                context.Database.Log = Console.Write;

                //Insert command
                int noOfRowInsert = context.Database.ExecuteSqlCommand("insert into student(studentname) values('Robert')");

                //Update command
                int noOfRowUpdate = context.Database.ExecuteSqlCommand("Update student set studentname ='Mark' where studentname = 'Robert'");

                //Delete command
                int noOfRowDeleted = context.Database.ExecuteSqlCommand("delete from student where studentname = 'Mark'");
            }

            Console.WriteLine("*** ExecuteSqlCommand Ends ***");
        }

        public static void DynamicProxy()
        {
            Console.WriteLine("*** DynamicProxy Starts ***");

            using (var context = new SchoolDBEntities())
            {
                var student = context.Students.Where(s => s.StudentName == "Bill")
                        .FirstOrDefault<Student>();

                Console.WriteLine("Proxy Type: {0}", student.GetType().Name);
                Console.WriteLine("Underlying Entity Type: {0}", student.GetType().BaseType);

                //Disable Proxy creation
                context.Configuration.ProxyCreationEnabled = false;

                Console.WriteLine("Proxy Creation Disabled");

                var student1 = context.Students.Where(s => s.StudentName == "Steve")
                        .FirstOrDefault<Student>();

                Console.WriteLine("Entity Type: {0}", student1.GetType().Name);
            }

            Console.WriteLine("*** DynamicProxy Ends ***");
        }


        /*
        Before executing it, proper information should be on
        Student, Course and StudentCourse table

        For Insert, Update and Delete stored proc, please check it out with 
        http://www.entityframeworktutorial.net/EntityFramework5/CRUD-using-stored-procedures.aspx
        */
        public static void ReadDataUsingStoredProcedure()
        {
            Console.WriteLine("*** ReadDataUsingStoredProcedure Starts ***");

            using (var context = new SchoolDBEntities())
            {
                context.Database.Log = Console.Write;
                //get all the courses of student whose id is 1
                var courses = context.GetCoursesByStudentId(5);
                //Set Course entity as return type of GetCoursesByStudentId function
                //Open ModelBrowser -> Function Imports -> Right click on GetCoursesByStudentId and Edit
                //Change Returns a Collection of to Course Entity from Complex Type
                //uncomment following lines
                foreach (Course cs in courses)
                {
                    Console.WriteLine(cs.CourseName);
                }
            }

            Console.WriteLine("*** ReadDataUsingStoredProcedure Ends ***");
        }


        /*
        Entity Framework supports automatic change tracking of the loaded entities during the life-time of the context. 
        The DbChangeTracker class gives you all the information about current entities being tracked by the context.
        */
        public static void ChangeTracker()
        {
            Console.WriteLine("*** ChangeTracker Starts ***");

            using (var context = new SchoolDBEntities())
            {
                context.Configuration.ProxyCreationEnabled = false;

                var student = context.Students.Add(new Student() { StudentName = "Mili" });
                DisplayTrackedEntities(context);

                Console.WriteLine("Retrieve Student");
                var existingStudent = context.Students.Find(1);

                DisplayTrackedEntities(context);

                Console.WriteLine("Retrieve Standard");
                var standard = context.Standards.Find(1);

                DisplayTrackedEntities(context);

                Console.WriteLine("Editing Standard");
                standard.StandardName = "Grade 5";

                DisplayTrackedEntities(context);

                Console.WriteLine("Remove Student");
                context.Students.Remove(existingStudent);
                DisplayTrackedEntities(context);
            }

            Console.WriteLine("*** ChangeTracker Ends ***");
        }

        private static void DisplayTrackedEntities(SchoolDBEntities context)
        {
            Console.WriteLine("Context is tracking {0} entities.", context.ChangeTracker.Entries().Count());
            DbChangeTracker changeTracker = context.ChangeTracker;
            var entries = changeTracker.Entries();
            foreach (var entry in entries)
            {
                Console.WriteLine("Entity Name: {0}", entry.Entity.GetType().FullName);
                Console.WriteLine("Status: {0}", entry.State);
            }
        }

        public static void SpatialDataType()
        {
            Console.WriteLine("*** SpatialDataType Starts ***");

            using (var context = new SchoolDBEntities())
            {
                context.Database.Log = Console.Write;
                //Add Location using System.Data.Entity.Spatial.DbGeography
                context.Courses.Add(new Course() { CourseName = "New Course from SpatialDataTypeDemo", Location = DbGeography.FromText("POINT(-122.360 47.656)") });

                context.SaveChanges();
            }

            Console.WriteLine("*** SpatialDataTypeDemo Ends ***");
        }

        public static void EntityEntry()
        {
            Console.WriteLine("*** EntityEntry Starts ***");

            using (var context = new SchoolDBEntities())
            {
                //get student whose StudentId is 1
                var student = context.Students.Find(5);

                //edit student name
                student.StudentName = "Monica";

                //get DbEntityEntry object for student entity object
                var entry = context.Entry(student);

                //get entity information e.g. full name
                Console.WriteLine("Entity Name: {0}", entry.Entity.GetType().FullName);

                //get current EntityState
                Console.WriteLine("Entity State: {0}", entry.State);

                Console.WriteLine("********Property Values********");

                foreach (var propertyName in entry.CurrentValues.PropertyNames)
                {
                    Console.WriteLine("Property Name: {0}", propertyName);

                    //get original value
                    var orgVal = entry.OriginalValues[propertyName];
                    Console.WriteLine("     Original Value: {0}", orgVal);

                    //get current values
                    var curVal = entry.CurrentValues[propertyName];
                    Console.WriteLine("     Current Value: {0}", curVal);
                }
            }

            Console.WriteLine("*** EntityEntryDemo Ends ***");
        }

        /*
        In Entity Framework, the SaveChanges() method internally creates a transaction 
        and wraps all INSERT, UPDATE and DELETE operations under it. 
        Multiple SaveChanges() calls, create separate transactions, perform CRUD operations and then commit each transaction.

        NOTE: To see more clearly, test one context at a time
        */
        public static void TransactionSupport()
        {
            Console.WriteLine("*** TransactionSupport Starts ***");

            //using (var context = new SchoolDBEntities())
            //{
            //    Console.WriteLine("Built-in Transaction");
            //    //Log DB commands to console
            //    context.Database.Log = Console.WriteLine;

            //    //Add a new student and address
            //    context.Students.Add(new Student() { StudentName = "Kapil" });

            //    var existingStudent = context.Students.Find(5);
            //    //Edit student name
            //    existingStudent.StudentName = "Alex";

            //    context.SaveChanges(); // Executes Insert & Update command under one transaction
            //}

            Console.WriteLine("External Transaction");
            using (var context = new SchoolDBEntities())
            {
                context.Database.Log = Console.Write;

                using (DbContextTransaction transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Students.Add(new Student()
                        {
                            StudentName = "Arjun"
                        });
                        context.SaveChanges();

                        context.Courses.Add(new Course() { CourseName = "Entity Framework" });
                        context.SaveChanges();

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error occurred.");
                    }
                }
            }

            Console.WriteLine("*** TransactionSupport Ends ***");
        }

        public static void SetEntityState()
        {
            Console.WriteLine("*** SetEntityState Starts ***");

            var student = new Student()
            {
                StudentID = 1, // root entity with key
                StudentName = "Bill",
                StandardId = 1,
                Standard = new Standard()   //Child entity (with key value)
                {
                    StandardId = 1,
                    StandardName = "Grade 1"
                },
                Courses = new List<Course>() {
                    new Course(){  CourseName = "Machine Language" }, //Child entity (empty key)
                    new Course(){  CourseId = 2 } //Child entity (with key value)
                }
            };

            using (var context = new SchoolDBEntities())
            {
                context.Entry(student).State = EntityState.Modified;

                foreach (var entity in context.ChangeTracker.Entries())
                {
                    Console.WriteLine("{0}: {1}", entity.Entity.GetType().Name, entity.State);
                }
            }

            Console.WriteLine("*** SetEntityState Ends ***");
        }

        /*
        FYI,
        
        ref: https://blogs.msdn.microsoft.com/marcelolr/2010/07/16/optimistic-and-pessimistic-concurrency-a-simple-explanation/
        */
        public static void OptimisticConcurrency()
        {
            Console.WriteLine("*** OptimisticConcurrency Starts ***");

            Student student = null;

            using (var context = new SchoolDBEntities())
            {
                student = context.Students.First();
            }

            //Edit student name
            student.StudentName = "Robin";

            using (var context = new SchoolDBEntities())
            {
                context.Database.Log = Console.Write;

                try
                {
                    context.Entry(student).State = EntityState.Modified;
                    context.SaveChanges();

                    Console.WriteLine("Student saved successfully.");
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    Console.WriteLine("Concurrency Exception Occurred.");
                }
            }

            Console.WriteLine("*** OptimisticConcurrency Ends ***");
        }


     

        private static void AddStudents(string[] studentNames)
        {
            using (var context = new SchoolDBEntities())
            {
                foreach (var member in studentNames)
                {
                    var newStudent = context.Students.Add(
                        new Student()
                        {
                            StudentName = member
                        }
                     );
                    context.SaveChanges(); // Executes Insert command
                }
            }
        }


    }
}
