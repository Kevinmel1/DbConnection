using System;

namespace DatabaseConnection
{
    class Program
    {
        static void Main()
        {
            try
            {
                var oracleConn = new OracleConnection("OracleDatabaseDemo/TableDemo");
                oracleConn.Open();
                oracleConn.Close();

                Console.WriteLine();

                var sqlConn = new SqlConnection("SqlDatabaseDemo/TableDemo");

                Console.WriteLine();

                sqlConn.Open();
                sqlConn.Close();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
