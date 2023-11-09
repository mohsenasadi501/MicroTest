using Microsoft.EntityFrameworkCore;
using MicroTest.Models;

namespace MicroTest.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
        }
        private static void SeedData(AppDbContext context)
        {
            context.Database.Migrate();

            if (!context.Platforms.Any())
            {
                Console.WriteLine("--> Seeding data ...");
                context.Platforms.AddRange(
                    new Platform()
                    {
                        Name = ".Net",
                        Publisher = "Microsoft",
                        cost = "Free"
                    },
                    new Platform()
                    {
                        Name = "Sql Server Express",
                        Publisher = "Microsoft",
                        cost = "Free"
                    },
                    new Platform()
                    {
                        Name = "Kubernetes",
                        Publisher = "Cloud Native Foundation",
                        cost = "Free"
                    });

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}
