using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JarvisMVC.Controllers
{
    public class ApplicationSearchController : Controller
    {
        // GET: ApplicationSearch
        public ActionResult Index()
        {
            return View();
        }

        // GET: ApplicationSearch/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApplicationSearch/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name)
        {
            //ViewBag.Message = "You have pressed YES.";
            return View();

            //try
            //{
            //    // TODO: Add insert logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // POST: ApplicationSearch/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        


        // GET: ApplicationSearch/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApplicationSearch/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ApplicationSearch/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApplicationSearch/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
