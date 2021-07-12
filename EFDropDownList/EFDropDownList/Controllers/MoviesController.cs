using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDropDownList.Models;

namespace EFDropDownList.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            using(MoviesEntities Mlist=new MoviesEntities())
            {
                var InfoEF = new SelectList(Mlist.tbl_Movies.ToList(),"Movie_Id","Movie_Name");
                ViewData["ViewMovies"] = InfoEF;
            }
            return View();
        }
    }
}