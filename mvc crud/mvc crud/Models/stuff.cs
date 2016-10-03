using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace mvc_crud.Models
{
    
        public class Planet
        {
            public int PlanetId { get; set; }
            public string Name { get; set; }
            public long Population { get; set; }
        }

        public class PlanetContext : DbContext
        {
            public DbSet<Planet> Planets { get; set; }

            public PlanetContext()
            {
                Database.SetInitializer<PlanetContext>(
                    new MyInitializer()
                    );
            }

        public class MyInitializer : DropCreateDatabaseIfModelChanges<PlanetContext>
        {
            protected override void Seed(PlanetContext context)
            {
                base.Seed(context);
                context.Planets.Add(new Planet()
                {
                    Name = "earth",
                    Population = 700000000
                });
                context.SaveChanges();
            }
        }

        

    
}