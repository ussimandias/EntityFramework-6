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

            public List<SearchCriteria> FindPerson(string lastName, string firstName, string claimNumber,
                string certificateNumber, string companyName, DateTimeOffset effectiveDate, int account, string creditor,
                int loanNumber)
            {
                return
                    new List<SearchCriteria>
                    {

                        new SearchCriteria
                        {

                            LastName = "Ryan",
                            FirstName = "Jack",
                            Account = 12345,
                            CertificateNumber = "B12345",
                            ClaimNumber = "123456",
                            CompanyName = "Fortegra",
                            Creditor = "Wells Fargo",
                            EffectiveDate = DateTimeOffset.Now,
                            LoanNumber = 012345

                        },
                        new SearchCriteria
                        {

                            LastName = "Tom",
                            FirstName = "Iris",
                            Account = 1234545,
                            CertificateNumber = "512345",
                            ClaimNumber = "123456t",
                            CompanyName = "Fortegra Carclubs",
                            Creditor = "Bank of America",
                            EffectiveDate = DateTimeOffset.Now,
                            LoanNumber = 012345
                        },

                        new SearchCriteria
                        {

                            LastName = "Clinton",
                            FirstName = "Dent",
                            Account = 134234545,
                            CertificateNumber = "512345",
                            ClaimNumber = "1234s56t",
                            CompanyName = "Zenith",
                            Creditor = "Chase",
                            EffectiveDate = DateTimeOffset.Now,
                            LoanNumber = 0123457
                        }
                    };
            }



        //throw new NotImplementedException();
            }
        }

    }

 
