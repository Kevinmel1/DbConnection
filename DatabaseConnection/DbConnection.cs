using System;

namespace DatabaseConnection
{
    abstract class DbConnection
    {
        private readonly string _connectionString;

        public DbConnection(string connectionString)
        {
            if (connectionString == null || connectionString == "")
                throw new ArgumentException("ConnectionString cannot be null or empty.");

            this._connectionString = connectionString;
        }

        public abstract void Open();

        public abstract void Close();
    }
}
