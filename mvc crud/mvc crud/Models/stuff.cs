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
        }

        public class PlanetContext : DbContext
        {
            public DbSet<Planet> Planets { get; set; }
        }

        

    
}