using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlcommand
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            SqlCommand cmd = conn.CreateCommand();

            // Sét Command Text
            cmd.CommandText = sql;
        }
    }
}
