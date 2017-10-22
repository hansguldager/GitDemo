using System.Data.Entity;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GitDemo.Models;

namespace GitDemo.DataAccessLayer
{
    public class RegisterContext : DbContext
    {
        public DbSet<Models.Employee> Employees { get; set; }

        //public RegisterContext(DbSet<Employee> employees)
        //{
        //    Employees = employees ?? throw new ArgumentNullException(nameof(employees));
        //}

        public RegisterContext() : base("DefaultConnection") { }
    }
}