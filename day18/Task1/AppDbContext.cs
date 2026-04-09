using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Task1
{
    public class AppDbContext : DbContext
    {
        public DbSet<EmployeeModel> Employees { get; set; }
        public DbSet<DepartmentModel> Departments { get; set; }
        public AppDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "hr.db");
            optionsBuilder.UseSqlite("Data Source=" + path);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentModel>().HasData(
                new DepartmentModel { Id = 1, Name = "Продажи" },
                new DepartmentModel { Id = 2, Name = "ИТ" },
                new DepartmentModel { Id = 3, Name = "Маркетинг" }
            );
        }
    }
}
