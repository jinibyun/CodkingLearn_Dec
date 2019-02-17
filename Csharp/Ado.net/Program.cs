using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.net
{
    class Program
    {
        static void Main(string[] args)
        {
            // var obj = new testSqlConnection();
            // var obj = new testSqlCommand();
            // var obj = new testDynamicSQL();
            var obj = new testStoreProc();
            obj.DoTest();
        }
    }
}
