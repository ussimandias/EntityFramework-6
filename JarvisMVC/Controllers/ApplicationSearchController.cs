using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JarvisMVC.Models;

namespace JarvisMVC.Controllers
{
    public class ApplicationSearchController : Controller
    {
        private readonly MockDependencyInjection.ISearchResultsService _resultsService;

   
    

        public ApplicationSearchController() : this(JarvisMVC.Models.MockDependencyInjection.DependencyFactory.NewResultsService())
        {         
  
        }

        public ApplicationSearchController(MockDependencyInjection.ISearchResultsService resultsService)
        {
            _resultsService = resultsService;
        }

        // GET: ApplicationSearch
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search()
        {
            var data = this._resultsService.FindPerson("", "", "", "", "", DateTimeOffset.Now, 0, "", 1);
            return View(data);
        }

        public ActionResult claimView()
        {
            var claimCollection = new List<SearchCriteria>();

            if (Session["SearchCollection"] != null)
            {
                claimCollection = (List<SearchCriteria>)Session["SearchCollection"];
            }

            return View(claimCollection);
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

        // POST: ApplicationSearch/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
                return View();
        }

        [HttpPost]
        public ActionResult Search(SearchCriteria newClaim)
        {
            var claimCollection = new List<SearchCriteria>();

            if (Session["SearchCollection"] != null)
            {
                claimCollection.Add((SearchCriteria) Session["SearchCollection"]);

            }
            claimCollection.Add(newClaim);
            Session["SearchCollection"] = claimCollection;

            return RedirectToAction("Index");

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
                return View();
    }
    }
}
