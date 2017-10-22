namespace GitDemo.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GitDemo.DataAccessLayer.RegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GitDemo.DataAccessLayer.RegisterContext context)
        {

            context.Employees.AddOrUpdate(
                f => f.FirstName,
                new Employee { FirstName = "Adam", LastName = "Aaaa", Department = "onFloor", Position = "slave", Salary = 30 },
                new Employee { FirstName = "Bob", LastName = "Bbb", Department = "office", Position = "Boss", Salary = 300 },
                new Employee { FirstName = "Chuck", LastName = "Ccccc", Department = "onFloor", Position = "slave", Salary = 30 },
                new Employee { FirstName = "Deb", LastName = "Dee", Department = "onFloor", Position = "bitch", Salary = 20 },
                new Employee { FirstName = "Frank", LastName = "Fffff", Department = "outdoor", Position = "harmless", Salary = 10 }
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
