using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksManager.app.Core
{
    public class DBManager
    {
        private string connectionString = "Server=localhost;UserID=root;Password=b84gF345!!2;Database=booksmanager";
        public static DBManager instance = null;

        private DBManager()
        {
            //singleton
        }

        public static DBManager getInstance()
        {
            if (instance == null) instance = new DBManager();

            return instance;
        }

        public MySqlConnection Connect()
        {
            var con = new MySqlConnection(connectionString);

            return con;
        }
    }
}