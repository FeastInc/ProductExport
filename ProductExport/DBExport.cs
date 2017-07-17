using System;
using System.ComponentModel.Design;
using MySql.Data.MySqlClient;

namespace ProductExport
{
    class DBExport : IDisposable
    {
        public MySqlConnection Connection { get; }

        public DBExport(string server, string database, string user, string pass)
        {
            Connection = new MySqlConnection($"Server={server}; database={database}; UID={user}; password={pass};");
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}
