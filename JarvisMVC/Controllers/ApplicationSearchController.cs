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

        public ApplicationSearchController() : this(MockDependencyInjection.DependencyFactory.NewResultsService())
        {         
  
        }

        public ApplicationSearchController(MockDependencyInjection.ISearchResultsService resultsService)
        {
            _resultsService = resultsService;
        }

        //var data = claim.FirstName + claim.Account + claim.CertificateNumber + claim.CompanyName + claim.ClaimNumber + claim.Creditor + claim.EffectiveDate + claim.LastName + claim.LoanNumber ;

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Claims()
        {
            var claimCollection = new List<SearchCriteria>();

            if (Session["ClaimCollection"] != null)
            {
                claimCollection = (List<SearchCriteria>)Session["ClaimCollection"];

            }
            return View(claimCollection);
        }


        [HttpGet]
        public ActionResult SearchClaim()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchClaim(SearchCriteria newClaim)
        {
            var claimCollection = new List<SearchCriteria>();

            if (Session["ClaimCollection"] != null)
            {
                claimCollection = (List<SearchCriteria>)Session["ClaimCollection"];

            }

            claimCollection.Add(newClaim);
            Session["ClaimCollection"] = claimCollection;

            if (ModelState.IsValid)
            {
                return RedirectToAction("Claims");
            }
            else
            {
                return View();
            }


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
