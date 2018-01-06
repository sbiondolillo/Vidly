namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Vidly.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Vidly.Models.ApplicationDbContext context)
        {
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

            context.Movies.AddOrUpdate(
                m => m.Name,
                new Models.Movie
                {
                    Name = "Die Hard",
                    GenreId = 1,
                    ReleaseDate = new DateTime(1988, 7, 15),
                    DateAdded = DateTime.Now,
                    NumberInStock = 3,
                    NumberAvailable = 3
                },
                new Models.Movie
                {
                    Name = "The Godfather",
                    GenreId = 3,
                    ReleaseDate = new DateTime(1972, 3, 24),
                    DateAdded = DateTime.Now,
                    NumberInStock = 5,
                    NumberAvailable = 5
                },
                new Models.Movie
                {
                    Name = "Aladdin",
                    GenreId = 5,
                    ReleaseDate = new DateTime(1992, 11, 25),
                    DateAdded = DateTime.Now,
                    NumberInStock = 1,
                    NumberAvailable = 1
                },
                new Models.Movie
                {
                    Name = "The Princess Bride",
                    GenreId = 2,
                    ReleaseDate = new DateTime(1987, 9, 25),
                    DateAdded = DateTime.Now,
                    NumberInStock = 4,
                    NumberAvailable = 4
                });
        }
    }
}
