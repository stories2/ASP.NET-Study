using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tutorial.Models
{
    public class MyProfile
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime updateDateTime { get; set; }
        public string memo { get; set; }
        public decimal age { get; set; }
    }

    public class MyProfileDBContext : DbContext
    {
        public DbSet<MyProfile> Profiles { get; set; }
    }
}