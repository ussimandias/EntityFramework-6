using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace JarvisMVC.Models
{
    public class MockDependencyInjection
    {
        public static class DependencyFactory
        {
            public static ISearchResultsService NewResultsService()
            {
                return new MockSearchResultsService();
            }
        }

        public interface ISearchResultsService
        {
           
            List<SearchCriteria> FindPerson(string lastName, string firstName, string claimNumber, string certificateNumber, string companyName, DateTimeOffset effectiveDate, int account, string creditor, int loanNumber);
        }

        public class MockSearchResultsService : ISearchResultsService
        {

             public List<SearchCriteria> FindPerson(string lastName, string firstName, string claimNumber, string certificateNumber, string companyName, DateTimeOffset effectiveDate, int account, string creditor, int loanNumber)
            {
                return new List<SearchCriteria>(new[] { new SearchCriteria { LastName = "Ryan", FirstName = "Bill", Account = 12345, CertificateNumber = "B12345", ClaimNumber = "123456", CompanyName = "Fortegra", Creditor = "Wells Fargo", EffectiveDate = DateTimeOffset.Now, LoanNumber = 012345} });//throw new NotImplementedException();
            }
        }

    }

  }
