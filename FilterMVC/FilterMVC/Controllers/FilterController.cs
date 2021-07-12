using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Web.Mvc;

namespace FilterMVC.Controllers
{
    public class FilterController : Controller,IActionFilter
    {
        // GET: Filter
        public ActionResult Index()
        {
            return View();
        }
        
        void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext)
        {
            Trace.WriteLine(" this Application has Excecuted on " + DateTime.Now.ToString());
            Trace.WriteLine(" ");
            Trace.WriteLine("==========================================================================");

        }
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            Trace.WriteLine("You have started Excexuting this Application on " + DateTime.Now.ToString());
            Trace.WriteLine(" ");
            Trace.WriteLine("==========================================================================");
            filterContext.Result = new RedirectResult("https://www.youtube.com/watch?v=f0L1xh1yFlY");
        }
        [HandleError]
        public ActionResult Exceptions()
        { 
            throw new Exception("Some unknown error Occured!");
        }
    }
}