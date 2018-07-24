using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tutorial.Models
{
    public class Users
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public int age { get; set; }

        [Display(Name = "Updated Date Time")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime updatedDateTime { get; set; }
    }

    public class UsersDBContext : DbContext
    {
        public DbSet<Users> usersList { get; set; }
    }
}