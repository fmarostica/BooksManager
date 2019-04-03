using BooksManager.app.Core;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BooksManager.app.models
{
    public class Book
    {
        public enum OrderBy { Id, Title }
        public enum Order { ASC, DESC }
        private BooksEntities booksEntities = new BooksEntities();

        public static DbSet<books> GetList(string filter="", OrderBy order_by=OrderBy.Title, Order order=Order.ASC, int limit=0)
        {
            List<Book> books = new List<Book>();
            BooksEntities booksEntities = new BooksEntities();
            var lst = booksEntities.books;
            return lst;
        }

        public bool Add(string title, int author_id)
        {
            booksEntities.books.Add(new books() { title = title, author_id = author_id });
            booksEntities.SaveChanges();

            return true;
        }

        
    }
}