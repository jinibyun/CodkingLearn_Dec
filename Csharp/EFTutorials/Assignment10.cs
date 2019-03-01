using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTutorials
{
    class Assignment10
    {
        public void test()
        {

          






            Console.WriteLine("*** Assignment 10  ***");

            // 1.Insert new author to Authors
            // 2.Delete one existing record from Authors

            Console.WriteLine("*** 1,2.Insert new record + Delete one existing record  (Author Table) ***");
            using (var context = new pubsEntities())
            {
                // logs(process) printed on console window
                //context.Database.Log = Console.WriteLine;


                var authorlist = context.authors.ToList();
                var ExAuthor = authorlist.Where(x => x.au_fname == "Lilly").FirstOrDefault();

                // if already exist, delete it
                if (ExAuthor != null)
                {
                    context.authors.Remove(ExAuthor);
                    context.SaveChanges();
                }

                // else, create new record
                else
                {

                    var newAuthor = context.authors.Add(
                        new author()
                        {
                            au_id = "313-46-8915",
                            au_lname = "Song",
                            au_fname = "Lilly",
                            phone = "435 548-7723",
                            contract = true
                        }
                     );
                    context.SaveChanges();
                }


                Console.WriteLine("\n");
                Console.WriteLine("*** 3. Update one existing record  (Author Table) ***");
                // 3. Update one existing record from Authors

                var ExAuthor2 = authorlist.Where(x => x.au_lname == "Shin").FirstOrDefault();

                // if already exist, update it (update first name)
                if (ExAuthor != null)
                {
                    ExAuthor2.au_fname = "Lidia";
                    context.SaveChanges();
                }


                Console.WriteLine("\n");
                Console.WriteLine("*** 4. Get one record whose titleid is equal to \"BU1032\" from titles using Linq expression or Linq query ***");
                // 4. Get one record whose titleid is equal to "BU1032" from titles 
                //    using Linq expression or Linq query

                var BU1032author = (from s in context.authors
                               join t in context.titleauthors
                               on s.au_id equals t.au_id
                               join i in context.titles
                               on t.title_id equals i.title_id
                               where (i.title_id == "BU1032")
                               select new { s.au_fname, s.au_lname }).ToArray().Select(x => x.au_fname + " " + x.au_lname);

                // var author3Array = author3.ToArray();

                // author3List.ForEach(x => Console.WriteLine("authors with title id \"BU1032\" are : " + x));

                // var printAuthor3Array = author3Array.Select(x => x.au_fname + " " + x.au_lname);

                Console.WriteLine("authors with title id \"BU1032\" are..." );

                foreach (var x in BU1032author)
                {
                    Console.WriteLine(x);
                }




                Console.WriteLine("\n");
                Console.WriteLine("*** 5. Get all records from sales using Linq expression or Linq query ***");
                // 5. Get all records from sales using Linq expression or Linq query

                //var allSalesRecord = (from s in context.sales select s).ToArray();
                var allSalesRecord = (from s in context.sales select new { s.stor_id,s.ord_num,s.ord_date,s.qty,s.payterms,s.title_id }).ToArray();
                foreach (var x in allSalesRecord) {
                    Console.WriteLine(x);
                }
                // Question: how to display all record (SELECT * FROM TABLE) without typing all column (s.xxxx, s.yyy....)


                // 6. Even if we did not study in the class, study about ExecuteRawSQLusingSqlQuery() and ExecuteSqlCommand() and EntityEntry(), OptimisticConcurrency() in advance.




            }











        }
    }
}


