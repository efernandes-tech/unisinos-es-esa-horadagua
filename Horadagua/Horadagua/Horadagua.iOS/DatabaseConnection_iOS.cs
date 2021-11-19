using Horadagua.Infraestrutura;
using Horadagua.iOS;
using SQLite;
using System;
using System.IO;

namespace Horadagua.iOS
{
    public class DatabaseConnection_iOS : IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", "CCFoodsDb.db");
            return new SQLiteConnection(path);
        }
    }
}