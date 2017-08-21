using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.SqlConn;
using System.Data.SqlClient;
using System.Data.Common;

namespace CsSQLServerTutorial
{
    class QueryDataExample
    {
        static void Main(string[] args)
        {

            // Lấy ra đối tượng Connection kết nối vào DB.
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                QueryEmployee(conn);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                // Đóng kết nối.
                conn.Close();
                // Hủy đối tượng, giải phóng tài nguyên.
                conn.Dispose();
            }
            Console.Read();
        }

        private static void QueryEmployee(SqlConnection conn)
        {
            string sql = "Select Emp_Id, Emp_No, Emp_Name, Mng_Id from Employee";

            // Tạo một đối tượng Command.
            SqlCommand cmd = new SqlCommand();
            // Liên hợp Command với Connection.
            cmd.Connection = conn;
            cmd.CommandText = sql;


            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    // Read advances to the next row.
                    while (reader.Read())
                    {
                        // Vị trí của cột Emp_ID trong câu SQL.
                        int empIdIndex = reader.GetOrdinal("Emp_Id"); // 0


                        long empId = Convert.ToInt64(reader.GetValue(0));

                        // Cột Emp_No có index = 1.
                        string empNo = reader.GetString(1);
                        int empNameIndex = reader.GetOrdinal("Emp_Name");// 2
                        string empName = reader.GetString(empNameIndex);

                        // Vị trí cả cột Mng_Id trong câu SQL.
                        int mngIdIndex = reader.GetOrdinal("Mng_Id");

                        long? mngId = null;

                        // Kiểm tra cột có thể null hay không.
                        if (!reader.IsDBNull(mngIdIndex))
                        {
                            mngId = Convert.ToInt64(reader.GetValue(mngIdIndex));
                        }
                        Console.WriteLine("--------------------");
                        Console.WriteLine("empIdIndex:" + empIdIndex);
                        Console.WriteLine("EmpId:" + empId);
                        Console.WriteLine("EmpNo:" + empNo);
                        Console.WriteLine("EmpName:" + empName);
                        Console.WriteLine("MngId:" + mngId);
                    }
                }
            }

        }
    }

}