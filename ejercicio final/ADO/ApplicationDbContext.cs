using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.IO;

namespace ADO
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }

        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define las configuraciones de las entidades aquí
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "notas.db"));
        }
    }
}
