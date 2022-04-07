using EquipmentBookingApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentBookingApp.Domain
{
    public class EquipmentBookingDbContext : DbContext
    {
        public EquipmentBookingDbContext(DbContextOptions<EquipmentBookingDbContext> options) : base(options)
        {
        }

        public DbSet<Equipment> Equipment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Equipment>().HasData(
                new Equipment
                {
                    Id = 1,
                    Name = "Hammer",
                    Category = "tools",
                    Price = 69.99,
                    Description = "Secure loose objects with minimal effort. "
                },
                new Equipment
                {
                    Id = 2,
                    Name = "Wrench",
                    Category = "tools",
                    Price = 49.99,
                    Description = "Tighten loose nuts and bolts. "
                },
                new Equipment
                {
                    Id = 3,
                    Name = "Pulley",
                    Category = "tools",
                    Price = 64.99,
                    Description = "Lift any item, no matter how heavy. "
                },
                new Equipment
                {
                    Id = 4,
                    Name = "Pliers",
                    Category = "tools",
                    Price = 79.99,
                    Description = "Tighten any screw professionaly. "
                }
            );
        }
    }
}
