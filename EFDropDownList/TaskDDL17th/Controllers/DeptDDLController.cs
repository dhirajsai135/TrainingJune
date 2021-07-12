using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskDDL17th.Models;

namespace TaskDDL17th.Controllers
{
    public class DeptDDLController : Controller
    {
        // GET: DeptDDL
        public ActionResult Index()
        {
            DeptModel mdl = new DeptModel();
            DataTable dt = mdl.GetDepartment();
            return View("Index", dt);
        }
    }
}