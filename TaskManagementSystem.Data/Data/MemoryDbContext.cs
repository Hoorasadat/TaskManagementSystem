using System;
using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Lib.Models;

namespace TaskManagementSystem.Data.Data
{
    public class MemoryDbContext : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase(databaseName: "TaskDB");
        }

        public DbSet<Duty> Duties { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}
