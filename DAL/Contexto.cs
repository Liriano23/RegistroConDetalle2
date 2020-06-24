using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using RegistroConDetalle2.Models;

namespace RegistroConDetalle2.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Suplidores> Suplidores { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Ordenes> Ordenes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source = Data/RegistroConDetalle2.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            {
                SuplidorId=1,
                Nombre = "Enmanuel"
            });

            modelBuilder.Entity<Productos>().HasData(new Productos
            {
                ProductosId = 1,
                Descripcion = "Lays",
                Costo = 25,
                Inventario = 50,
                SuplidorId =1
            });
        }
    }
}
