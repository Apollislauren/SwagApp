using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Swag_App
{
    internal class myDatabase
    {
        private SQLiteConnection _database;

        public static myDatabase Instance = new myDatabase();

        public myDatabase()
        {
            ///
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            path = path + "swag.db";

            _database = new SQLiteConnection(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);

            _database.CreateTable<swagProperties>();
        }

        public List<swagProperties> GetSwag()
        {
            return _database.Table<swagProperties>().OrderByDescending(x => x.JokeDate).ToList();
        }

        public void SaveDadJoke(swagProperties)
        {
            _database.Insert(joke);
        }
    }

}
