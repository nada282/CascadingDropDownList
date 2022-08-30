using CascadingDropDownList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadingDropDownList.Controllers
{
    public class HomeController : Controller
    {
        ListEntities List = new ListEntities();

        public ActionResult Index()
        {
            ViewBag.city=List.City_Table.ToList();
            ViewBag.country = List.CountryTable.ToList();

            // ViewBag.city = new SelectList(List.City_Table.ToList(), "City_id", "City_name");
            //  ViewBag.country = new SelectList(List.CountryTable.ToList(), "Country_id", "Country_name");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult DisplayCountry(int cityid)
        {


            return Json(List.CountryTable.Where(c => c.Country_id == cityid).Select(c => new
            {
                Id = c.Country_id,
                Name=c.Country_name,
            }).ToList(),JsonRequestBehavior.AllowGet) ;
        }

    }
}