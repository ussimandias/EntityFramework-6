﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JarvisMVC.Models
{
    public class SearchCriteria : IValidatableObject
    {

        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "Last Name Should be no more than 50 Characters")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        [StringLength(75, ErrorMessage = "First Name Should be no more than 75 Characters")]
        public string FirstName { get; set; }

        [Display(Name = "Claim Number")]
        [StringLength(15, ErrorMessage = "Claim Number Should be no more than 15 Characters")]
        public string ClaimNumber { get; set; }

        [Display(Name = "Certificate Number")]
        [StringLength(15, ErrorMessage = "Certificate Number Should be no more than 15 Characters")]
        public string CertificateNumber { get; set; }

        [Display(Name = "Company Name")]
        [StringLength(100, ErrorMessage = "Company Name Should be no more than 100 Characters")]
        public string CompanyName { get; set; }

        [Display(Name = "Effective Date")]
        [DataType(DataType.Date)]
        public DateTimeOffset EffectiveDate { get; set; }

        //[Display(Name = "Social Security Number")]
        //[RegularExpression(@"^\d{9}|\d{3}-\d{2}-\d{4}$", ErrorMessage = "Invalid Social Security Number")]
        //public string SocialSecurityNumber { get; set; }

        //[Display(Name = "Age")]
        //[Range(0, 120)]
        //public int Age { get; set; }

        [Display(Name = "Account")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Please use numeric data only")]
        public int Account { get; set; }

        [Display(Name = "Creditor")]
        public string Creditor { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "Use numeric data only")]
        [Display(Name = "Loan Number")]
        public int LoanNumber { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var field = new[] { "EffectiveDate" };

            if (EffectiveDate > DateTime.Now)
            {
                yield return new ValidationResult(" Date can not be in the future", field);
            }
            if (EffectiveDate < DateTime.Now.AddYears(-50))
            {
                yield return new ValidationResult("Date can not be 50 years in the past", field);
            }
            //throw new NotImplementedException();
        }
    }

    
}