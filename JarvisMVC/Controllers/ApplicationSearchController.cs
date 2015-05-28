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

        private readonly ISearchResultsService _resultsService;

        public ApplicationSearchController()
            : this(DependencyFactory.NewResultsService())
        {

        }

        public ApplicationSearchController(ISearchResultsService resultsService)
        {
            _resultsService = resultsService;
        }

        // GET: ApplicationSearch
        public ActionResult Index()
        {
            return View();
        }

        //public ViewResult Index(string searchString)
        //{
            
        //    //if (!String.IsNullOrEmpty(searchString))
        //    //{
        //    //    return View();
        //    //}


        //    return View();
        //}

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

        //[HttpPost]
        //public ActionResult Index(string name)
        //{
        //    ViewBag.Message = "You have pressed YES.";
        //    return View();

        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

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

        public static class DependencyFactory
        {
            public static ISearchResultsService NewResultsService()
            {
                return new MockSearchResultsService();
            }
        }

        public interface ISearchResultsService
        {
            List<SearchCriteria> FindClaims(string firstName, string lastName, string claimNumber, string certificateNumber, string companyName, DateTimeOffset effectiveDate, int account, string creditor, int loanNumber) ;
        }

        public class MockSearchResultsService : ISearchResultsService
        {
            public List<SearchCriteria> FindClaims(string firstName, string lastName, string claimNumber, string certificateNumber, string companyName, DateTimeOffset effectiveDate, int account, string creditor, int loanNumber)
            {
                return new List<SearchCriteria>(new[] {new SearchCriteria {
                    Account = 1234, 
                    CertificateNumber = "3435", 
                    ClaimNumber = "45433", 
                    CompanyName = "Fortegra", 
                    Creditor = "Wells Fargo", 
                    EffectiveDate = DateTime.Now, 
                    FirstName = "Kevin", 
                    LastName = "Love", 
                    LoanNumber = 2345}});


                //throw new NotImplementedException();
            }
        }

        public class Claim
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
    }
}
