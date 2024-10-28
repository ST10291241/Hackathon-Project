using MauiApp2.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.ConnectionClass
{
    public class ConnectionTo_SQL
    {
        private static SQLiteConnection _database;

        public static SQLiteConnection DatabaseConnection()
        {
            if (_database == null)
            {
                string dbPath = Path.Combine(FileSystem.AppDataDirectory, "items.db3");
                _database = new SQLiteConnection(dbPath);
                _database.CreateTable<Users>();  // Create table if it doesn't exist
            }
            return _database;
        }
    }
}
