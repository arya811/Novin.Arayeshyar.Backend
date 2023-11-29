using Microsoft.EntityFrameworkCore;
using Novin.Arayeshyar.Backend.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.Infrastructure.Database
{
    public class ArayeshyarDB : DbContext
    {   
        public DbSet<SistemAdmin> SistemAdmins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BarberOwner> BarberOwners { get; set; }
        public ArayeshyarDB(DbContextOptions<ArayeshyarDB>options)
            : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SistemAdmin>().HasKey(m => m.Username);
            modelBuilder.Entity<BarberOwner>().HasKey(m => m.Mobilenumber);
            modelBuilder.Entity<Customer>().HasKey(m => m.Mobilenumber);
        }
    }
}
