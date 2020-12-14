using System;

namespace DatabaseConnection
{
    class OracleConnection : DbConnection
    {
        private readonly string _connectionString;

        public OracleConnection(string connectionString) : base(connectionString)
        {
            this._connectionString = connectionString;
        }
        public override void Close()
        {
            Console.WriteLine("...Oracle Connection closed.");
        }

        public override void Open()
        {
            Console.WriteLine("Oracle Connection established...");
            Console.WriteLine($"Open on ConnectionString: {_connectionString}");
        }
    }
}
