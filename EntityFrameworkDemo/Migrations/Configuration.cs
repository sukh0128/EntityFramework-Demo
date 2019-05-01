namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EntityFrameworkDemo.Models;
    using System.Collections.Generic;
    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameworkDemo.Models.FPDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityFrameworkDemo.Models.FPDbContext context)
        {
            List<FamousPerson> CelebritiesList = new List<FamousPerson>();

            CelebritiesList.Add(new FamousPerson() { Id = 1, FirstName = "Richard", LastName = "Feynman", Birthdate = new DateTime(1990, 1, 1), FamousLevel = 3, PassedDate = new DateTime(1990, 1, 1) });
            CelebritiesList.Add(new FamousPerson() { Id = 2, FirstName = "Marlon", LastName = "Brando", Birthdate = new DateTime(1990, 1, 1), FamousLevel = 4, PassedDate = new DateTime(1990, 1, 1) });
            CelebritiesList.Add(new FamousPerson() { Id = 3, FirstName = "Morgan", LastName = "Freeman", Birthdate = new DateTime(1950, 1, 1), FamousLevel = 5, PassedDate = null });

            context.Celebrities.AddRange(CelebritiesList);

            base.Seed(context);
        }
    }
}
