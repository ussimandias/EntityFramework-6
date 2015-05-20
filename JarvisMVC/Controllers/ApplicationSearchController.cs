using JarvisMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JarvisMVC.Controllers
{
    public class ApplicationSearchController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: ApplicationSearch
        public ActionResult Index(string searchString)
        {
            var cust = from c in db.Customers
                       select c;

            if (!string.IsNullOrEmpty(searchString))
            {
                cust = cust.Where(s => s.Name.Contains(searchString));   
            }
            return View(cust);
        }

        //public ActionResult Index(string id)
        //{
        //    var cust = from c in db.Customers
        //               select c;

        //    if (!string.IsNullOrEmpty(id))
        //    {
        //        cust = cust.Where(s => s.Name.Contains(id));
        //    }
        //    return View(cust);
        //    }
    }
}