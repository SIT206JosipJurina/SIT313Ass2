using SIT313Assignment2.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SIT313Assignment2.Data
{
    public class TokenDataBaseController
    {
        static object locker = new object();

        SQLiteConnection database;

        public TokenDataBaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Token>();
        }
        public Token GetToken()
        {
            lock (locker)
            {
                if (database.Table<Token>().Count() == 0)
                {
                    return null;
                }
                else
                    return database.Table<Token>().First();
            }
        }
        public int SaveToken(Token user)
        {
            lock (locker)
            {
                if (user.Id != 0)
                {
                    database.Update(user);
                    return user.Id;
                }
                else
                    return database.Insert(user);
            }
        }
        public int DeleteToken(int id)
        {
            lock (locker)
            {
                return database.Delete<Token>(id);
            }
        }
    }
}
