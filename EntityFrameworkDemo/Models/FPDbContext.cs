using System;
using System.Data.Entity;

namespace EntityFrameworkDemo.Models
{
    public class FPDbContext : DbContext
    {
        public FPDbContext() : base("name=FamousDB") {

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FPDbContext, EntityFrameworkDemo.Migrations.Configuration>());


        }

        public DbSet<FamousPerson> Celebrities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


        }
    }
}