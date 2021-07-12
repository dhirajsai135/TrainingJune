using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxDropDown.Controllers
{
    public class CascController : Controller
    {
        // GET: Casc
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCountry()
        {
            List<string> countries = new List<string>();
            countries.Add("India");
            countries.Add("USA");
            countries.Add("Japan");
            return Json(countries, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetStates(string country)
        {
            var States = new List<string>();
            if (!string.IsNullOrWhiteSpace(country))
            {
                if (country.Equals("USA"))
                {
                    States.Add("California");
                    States.Add("New York");
                }
                if (country.Equals("India"))
                {
                    States.Add("Andhra Pradesh");
                    States.Add("Tamil Nadu");
                }
                if (country.Equals("Japan"))
                {
                    States.Add("Kanto");
                    States.Add("Chugoku");
                }
            }
            return Json(States, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetCity(string state)
        {
            var Cities = new List<string>();
            if (!string.IsNullOrWhiteSpace(state))
            {
                if (state.Equals("California"))
                {
                    Cities.Add("Los Angeles");
                    Cities.Add("San Francisco");
                }
                if (state.Equals("New York"))
                {
                    Cities.Add("Brooklyn");
                    Cities.Add("Buffalo");
                }
                if (state.Equals("Andhra Pradesh"))
                {
                    Cities.Add("Nellore");
                    Cities.Add("Kadapa");
                }
                if (state.Equals("Andhra Pradesh"))
                {
                    Cities.Add("Nellore");
                    Cities.Add("Kadapa");
                }
                if (state.Equals("Tamil Nadu"))
                {
                    Cities.Add("Chennai");
                    Cities.Add("Madhurai");
                }
                if (state.Equals("Kanto"))
                {
                    Cities.Add("Tokyo");
                    Cities.Add("Saitama");
                }
                if (state.Equals("Chugoku"))
                {
                    Cities.Add("Hiroshima");
                    Cities.Add("Nagasaki");
                }
            }
            return Json(Cities, JsonRequestBehavior.AllowGet);
        }
    }
}