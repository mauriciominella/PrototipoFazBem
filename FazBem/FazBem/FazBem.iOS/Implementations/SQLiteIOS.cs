using FazBem.Interfaces;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FazBem.iOS.Implementations
{
    public class SQLiteIOS : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "fazbem.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder instead
            var path = Path.Combine(libraryPath, sqliteFilename);

            // This is where we copy in the prepopulated database
            Console.WriteLine(path);
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            var conn = new SQLiteConnection(new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS(), path);

            // Return the database connection 
            return conn;
        }
    }
}
