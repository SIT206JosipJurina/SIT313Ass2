using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using SIT313Assignment2.Data;
using SIT313Assignment2.iOS.Data;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_IOS))]
namespace SIT313Assignment2.iOS.Data
{
    public class SQLite_IOS : ISQLite
    {
        public SQLite_IOS() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var filename = "Testdb.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, filename);
            var connection = new SQLite.SQLiteConnection(path);

            return connection;
        }
    }
}