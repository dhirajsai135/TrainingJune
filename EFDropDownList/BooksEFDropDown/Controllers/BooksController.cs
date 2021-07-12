using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BooksEFDropDown.Models;

namespace BooksEFDropDown.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {
            using (BooksDBEntities BookList = new BooksDBEntities())
            {
                var InfoBooksEf = new SelectList(BookList.tbl_Books.ToList(), "BookId", "Title");
                ViewData["ViewBooks"] = InfoBooksEf;
            }
                return View();
        }
    }
}