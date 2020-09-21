using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T1_Diars.Models.Maps;

namespace T1_Diars.Models
{
    public class PersonaContext : DbContext 
    {
        public DbSet<Persona> Personas { get; set; }

        public PersonaContext(DbContextOptions<PersonaContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PersonaMap());
        }
    }
}
