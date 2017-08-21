using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tutorial.SqlConn
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"KELVIN\SQLEXPRESS";

            string database = "TestDB";
            string username = "MyAppUser";
            string password = "1234";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }

}