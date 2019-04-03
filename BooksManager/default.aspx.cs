using BooksManager.app.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BooksManager
{
    public partial class _default : System.Web.UI.Page
    {
        public DbSet<books> lastBooks;

        protected void Page_Load(object sender, EventArgs e)
        {
            lastBooks = Book.GetList("", Book.OrderBy.Id, Book.Order.DESC, 4);
            lastBooks.Add(new books() { title = "The test book" });
        }

        [WebMethod]
        public static string Login(string user, string pass)
        {
            if (user.Length == 0) throw new Exception("Debes ingresar un usuario");
            if (pass.Length == 0) throw new Exception("Debes ingresar una clave");
            return "ok";
        }
    }
}