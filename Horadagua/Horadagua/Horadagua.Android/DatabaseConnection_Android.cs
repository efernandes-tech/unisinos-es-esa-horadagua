using Horadagua.Droid;
using Horadagua.Infraestrutura;
using SQLite;
using System;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(DatabaseConnection_Android))]
namespace Horadagua.Droid
{
    public class DatabaseConnection_Android : IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "HoradaguaDb.db");
            return new SQLiteConnection(path);
        }
    }
}