using MVCDropDownCasc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDropDownCasc.Controllers
{
    public class ProductsController : Controller
    {
        AdventureWorksEntities ae = new AdventureWorksEntities();
        // GET: Products
        public ActionResult Index()
        {
            List<ProductCategory> pe = ae.ProductCategories.ToList();
            ViewBag.ProductCat = new SelectList(pe, "ProductCategoryID", "Name");
            return View();
        }
        public JsonResult GetProducts(int ProductCategoryId)
        {
            List<ProductSubcategory> psc = ae.ProductSubcategories.Where(i => i.ProductCategoryID == ProductCategoryId).ToList();
            return Json(psc, JsonRequestBehavior.AllowGet);
        }
    }
}