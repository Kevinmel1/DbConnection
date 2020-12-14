using System;

namespace DatabaseConnection
{
    class SqlConnection : DbConnection
    {
        private readonly string _connectionString;
        public SqlConnection(string connectionString) : base(connectionString)
        {
            this._connectionString = connectionString;
        }
        public override void Close()
        {
            Console.WriteLine("...Sql Connection closed.");
        }

        public override void Open()
        {
            Console.WriteLine("Sql Connection established...");
            Console.WriteLine($"Open on ConnectionString: {_connectionString}");
        }
    }
}
