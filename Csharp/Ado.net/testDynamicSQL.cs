using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.net
{
    public class testDynamicSQL
    {
        public void DoTest()
        {
            // conn and reader declared outside try
            // block for visibility in finally block
            SqlConnection conn = null;
            SqlDataReader reader = null;

            string titleId = "BU1032";
            try
            {
                // instantiate and open connection
                conn = new
                    SqlConnection(@"Data Source=LAPTOP-L82N2TN1\SQLEXPRESS;Initial Catalog=Pubs;Integrated Security=SSPI");
                conn.Open();

                // don't ever do this
                // SqlCommand cmd = new SqlCommand(
                // "select * from Customers where city = '" + inputCity + "'";

                // 1. declare command object with parameter
                SqlCommand cmd = new SqlCommand(
                    "select * from Titles where title_id = @TitleId", conn); // oracle ?

                // 2. define parameters used in command object
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@TitleId";
                param.Value = titleId;

                // 3. add new parameter to command object
                cmd.Parameters.Add(param);

                // get data stream
                reader = cmd.ExecuteReader();

                // write each record
                while (reader.Read())
                {
                    Console.WriteLine("{0}, {1}",
                        reader["title_id"],
                        reader["title"]);
                }
            }
            finally
            {
                // close reader
                if (reader != null)
                {
                    reader.Close();
                }

                // close connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
