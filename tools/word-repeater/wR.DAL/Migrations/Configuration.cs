using System;
using wR.Core.Domain;

namespace wR.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Languages.AddOrUpdate(l => l.Id,
                new Language
                {
                   Id = Guid.NewGuid(),
                   Code = "EN",
                   Name = "English"
                },
                new Language
                {
                    Id = Guid.NewGuid(),
                    Code = "DE",
                    Name = "German"
                },
                new Language
                {
                    Id = Guid.NewGuid(),
                    Code = "FR",
                    Name = "French"
                },
                new Language
                {
                    Id = Guid.NewGuid(),
                    Code = "ES",
                    Name = "Spanish"
                },
                new Language
                {
                    Id = Guid.NewGuid(),
                    Code = "PL",
                    Name = "Polish"
                });

        }
    }
}
