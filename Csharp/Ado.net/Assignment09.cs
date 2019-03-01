using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.net
{
    class Assignment09
    {
        public void test()
        {
            Console.WriteLine("Assignment09 - ADO.NET");

            //RunSP1();
            runSP2();

        }

        public void RunSP1()
        {
            SqlConnection conn = null;
            SqlDataReader rdr = null;

            string au_id = "123-45-7777";
            string au_lname = "Shin";
            string au_fname = "Songyi";
            string phonenum = "4379817523";
            string address = "51 Maple Road";
            string city = "Toronto";
            string prov = "ON";
            string zip = "12345";
            bool contract = true;

            try
            {
                conn = new SqlConnection(
                @"Data Source=LAPTOP-L82N2TN1\SQLEXPRESS;Initial Catalog=Pubs;Integrated Security=SSPI");
                conn.Open();

                SqlCommand cmd = new SqlCommand("usp_authors_insert", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(
                    new SqlParameter("@au_id", au_id));
                cmd.Parameters.Add(
                    new SqlParameter("@au_lname", au_lname));
                cmd.Parameters.Add(
                   new SqlParameter("@au_fname", au_fname));
                cmd.Parameters.Add(
                    new SqlParameter("@phone", phonenum));
                cmd.Parameters.Add(
                  new SqlParameter("@address", address));
                cmd.Parameters.Add(
                    new SqlParameter("@city", city));

                cmd.Parameters.Add(
                   new SqlParameter("@state", prov));
                cmd.Parameters.Add(
                    new SqlParameter("@zip", zip));
                cmd.Parameters.Add(
                   new SqlParameter("@contract", contract));

                rdr = cmd.ExecuteReader();
                Console.WriteLine("Success! ");

            }
            catch
            {
                Console.WriteLine("Error");
            }

            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
        }



        public void runSP2()
        {
            SqlConnection conn = null;
            SqlDataReader rdr = null;

            string title_id = "TL1717";
            string title = "TestBook2";
            string type = "TestType2";
            string pub_id = "0877";
            string price = "30.75";
            string advance = "300.75";
            int royalty = 30;
            int ytd_sales = 375;
            string notes = "TEST CASE2";
            string pubdate = "20190301";

            try
            {
                conn = new SqlConnection(
                @"Data Source=LAPTOP-L82N2TN1\SQLEXPRESS;Initial Catalog=Pubs;Integrated Security=SSPI");
                conn.Open();

                SqlCommand cmd = new SqlCommand("usp_titles_insert", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(
                    new SqlParameter("@title_id", title_id));
                cmd.Parameters.Add(
                    new SqlParameter("@title",title));
                cmd.Parameters.Add(
                   new SqlParameter("@type", type));
                
                cmd.Parameters.Add(
                  new SqlParameter("@pub_id", pub_id));


                cmd.Parameters.Add(
                    new SqlParameter("@price", price));

                cmd.Parameters.Add(
                   new SqlParameter("@advance", advance));
                cmd.Parameters.Add(
                    new SqlParameter("@royalty", royalty));
                cmd.Parameters.Add(
                   new SqlParameter("@ytd_sales", ytd_sales));
                cmd.Parameters.Add(
                   new SqlParameter("@notes", notes));
                cmd.Parameters.Add(
                   new SqlParameter("@pubdate", pubdate));

                rdr = cmd.ExecuteReader();
                Console.WriteLine("Success! ");

            }
            catch
            {
                Console.WriteLine("Error");
            }

            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
        }
    }
}
