using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using JarvisMVC.Models;

namespace JarvisMVC.ClaimsContext
{
    public class ClaimsDataContext : DbContext
    {
        public ClaimsDataContext() : base("ClaimsDataContext")
        {
            
        }

        public DbSet<ClaimsDatabase> Cdb { get; set; }


    }
}