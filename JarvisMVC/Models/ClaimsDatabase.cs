using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace JarvisMVC.Models
{
    public class ClaimsDatabase
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int ClaimNumber { get; set; }
        public int CertificateNumber { get; set; }
        public string CompanyName { get; set; }
        public DateTimeOffset EffectiveDate { get; set; }
        public int AccountNumber { get; set; }
        public string Creditor { get; set; }


    }


}