using Pwrliftr.DataAccess.Entities;
using System.Collections.Generic;
using System;

namespace Pwrliftr.DataAccess
{
    public class PwrliftrInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PwrliftrContext>
    {
        protected override void Seed(PwrliftrContext context)
        {
            var competitors = new List<Competitor>
            {
            new Competitor
            {
                FirstName = "Jack",
                LastName = "Pedleham",
                Country = "United Kingdom",
                City = "Leeds",
                DateOfBirth = new DateTime(1992, 02, 10),
                KiogramWeight = 90
            },
             new Competitor
            {
                FirstName = "Arnold",
                LastName = "Schwarzenegger",
                Country = "United States",
                City = "California",
                DateOfBirth = new DateTime(1947, 07, 30),
                KiogramWeight = 90
            }
            };

            competitors.ForEach(s => context.Competitors.Add(s));
            context.SaveChanges();
        }
    }
}