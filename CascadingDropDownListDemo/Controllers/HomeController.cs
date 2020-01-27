using CascadingDropDownListDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadingDropDownListDemo.Controllers
{
    public class HomeController : Controller
    {
        MVCTutorialEntities db = new MVCTutorialEntities();
        public ActionResult Index()
        {
            List<Country> CountryList = db.Countries.ToList();
            ViewBag.CountryList = new SelectList(CountryList, "CountryId", "CountryName");
            return View();
        }

        public JsonResult GetStateList(int CountryId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<State> StateList = db.States.Where(x => x.CountryId == CountryId).ToList();
            return Json(StateList, JsonRequestBehavior.AllowGet);

        }
        
    }
}