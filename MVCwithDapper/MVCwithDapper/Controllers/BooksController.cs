using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using System.Data;
using MVCwithDapper.Models;
using System.Diagnostics;

namespace MVCwithDapper.Controllers
{
    [CustomExceptionFilter]
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {
            List<BooksModel> bm = new List<BooksModel>();
            using(IDbConnection dbCon=new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
            {
                bm = dbCon.Query<BooksModel>("select * from tbl_Books").ToList();
            }
            return View(bm);
        }

        [HandleError]
        // GET: Books/Details/5
        public ActionResult Details(int id)
        {
                BooksModel bk = new BooksModel();
                using (IDbConnection dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings["BkConStr"].ConnectionString))
                {
                    bk = dbcon.Query<BooksModel>("select * from tbl_Books where BookID=" + id, new { id }).SingleOrDefault();
                }
                return View(bk);
            throw new Exception("Error Occurred");
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        public ActionResult Create(BooksModel bm)
        {
            using (IDbConnection dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings["BKConStr"].ConnectionString))
            {
                string sqlQry = "insert into tbl_Books(Title,AuthorId,Price) values('" + bm.Title + "'," + bm.AuthorId + "," + bm.Price + ")";
                int rowins = dbcon.Execute(sqlQry);
            }
            return RedirectToAction("Index");
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int id)
        {
            BooksModel BKList = new BooksModel();
            using (IDbConnection dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
            {
                BKList = dbcon.Query<BooksModel>("select * from tbl_Books where BookId =" + id, new { id }).SingleOrDefault();
            }
            return View(BKList);
        }

        // POST: Books/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection, BooksModel model)
        {
            try
            {
                using (IDbConnection dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
                {
                    string sqlQry = "update tbl_Books set Title='" + model.Title + "', AuthorId=" + model.AuthorId + ", Price=" + model.Price + " where BookId=" + id;
                    int rowins = dbcon.Execute(sqlQry);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int id)
        {
            BooksModel BKList = new BooksModel();
            using (IDbConnection dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
            {
                BKList = dbcon.Query<BooksModel>("select * from tbl_Books where BookId =" + id, new { id }).SingleOrDefault();
            }
            return View(BKList);
        }

        // POST: Books/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (IDbConnection dbcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
                {
                    string sqlQry = "delete from tbl_Books where BookId=" + id;
                    int rowins = dbcon.Execute(sqlQry);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
    public class CustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            var ctrlName = filterContext.RouteData.Values["controller"];
            var methodName = filterContext.RouteData.Values["action"];
            Trace.WriteLine("You have started Excexuting this Application on " + DateTime.Now.ToString());
            Trace.WriteLine(" ");
            Trace.WriteLine("==========================================================================");
            Trace.WriteLine(" ");
            Trace.WriteLine("Exception Traced " + DateTime.Now.ToString());
            Trace.WriteLine(" ");
            Trace.WriteLine("==========================================================================");
            filterContext.Result = new RedirectResult("https://www.youtube.com/watch?v=hk15uPhpjNw");
        }
    }
}
