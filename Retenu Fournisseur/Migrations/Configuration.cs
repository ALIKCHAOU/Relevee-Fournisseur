namespace Retenu_Fournisseur.Migrations
{
    using Retenu_Fournisseur.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Retenu_Fournisseur.Model.ContextApplication>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Retenu_Fournisseur.Model.ContextApplication context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            IList<User> defaultAccounts = new List<User>();
            if (context.Users.Count() == 0)
            {

                context.Users.AddOrUpdate(
                  new User { ID = Guid.NewGuid(), Login = "Admin", Password = "Admin", EmailAddress = "Admin@gmail.com", FirstName = "Admin", LastName = "Admin", IsAdmin = true },
                 new User
                 {
                     ID = Guid.NewGuid(),
                     Login = "User",
                     Password = "User",
                     EmailAddress = "User@gmail.com",
                     IsAdmin = false,
                     LastName = "User",
                     FirstName = "User"
                 });
            }
        }
    }
}
