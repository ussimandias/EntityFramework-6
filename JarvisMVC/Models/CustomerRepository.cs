using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JarvisMVC.Models
{
    public class CustomerRepository
    {
        public IEnumerable<Customer> Customers { get; set; }

        //A repository for working with customer data

        private ApplicationDbContext db = new ApplicationDbContext();

        public int InsertCustomer(Customer cust)
        {
            db.Customers.Add(cust); //Call the InserstOnSubmit method
            db.SaveChanges(); //Remember to call the SubmitChanges button
            return cust.CustomerID;
        }

        public void UpdateCustomer(Customer cust)
        {
            var currentCust =
                (from currCust in db.Customers
                 where currCust.CustomerID == cust.CustomerID
                 select currCust)
                 .SingleOrDefault();

            if (currentCust != null)
            {
                currentCust.Age = cust.Age;
                currentCust.Birthday = cust.Birthday;
                currentCust.Income = cust.Income;
                currentCust.Name = cust.Name;

            }

            db.SaveChanges();
        }

        public Customer GetCustomer(int custID)
        {
            return
                (from cust in db.Customers
                 where cust.CustomerID == custID
                 select cust)
                    .SingleOrDefault();
        }

        public List<Customer> GetCustomers()
        {
            return
                (from cust in db.Customers
                 select cust)
                     .ToList();
        }

        public void DeleteCustomer(int custID)
        {
            var customer =
                (from cust in db.Customers
                 where cust.CustomerID == custID
                 select cust)
                     .SingleOrDefault();

            db.Customers.SingleOrDefault();
            db.SaveChanges();

        }

       
    }
}