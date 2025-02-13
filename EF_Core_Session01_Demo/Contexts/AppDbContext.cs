using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Core_Session01_Demo.Configurations;
using EF_Core_Session01_Demo.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Session01_Demo.Contexts
{
    // namespace called --> Microsoft.EntityFrameworkCore
    internal class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Fluent APIs
            //modelBuilder.Entity<Employee>().HasKey("EmpId");
            //modelBuilder.Entity<Employee>().HasKey(nameof(Employee.EmpId));
            //modelBuilder.Entity<Employee>().HasKey(E => E.EmpId);
            //modelBuilder.Entity<Employee>()
            //            .Property(E => E.Name)
            //            .IsRequired(true)
            //            .HasColumnType("varchar")
            //            .HasMaxLength(50)
            //            .HasColumnName("EmployeeName");
            //modelBuilder.Entity<Employee>()
            //            .Property(E => E.Age)
            //            .IsRequired(false);
            //modelBuilder.Entity<Employee>()
            //            .Property(E => E.Salary)
            //            .HasColumnType("money");

            ////modelBuilder.Entity<Employee>()
            ////            .Property(E => E.DateOfCreation)
            ////            .HasDefaultValue(DateTime.Now); // as soon as creating object from the employee datatype

            //modelBuilder.Entity<Employee>()
            //            .Property(E => E.DateOfCreation)
            //            .HasDefaultValueSql("GETDATE()"); // as soon as insertion takes place in the database

            //modelBuilder.Entity<Employee>(E =>
            //{
            //    E.HasKey(E => E.EmpId);

            //    E.Property(E => E.Name)
            //    .IsRequired(true)
            //    .HasColumnType("varchar")
            //    .HasMaxLength(50)
            //    .HasColumnName("EmployeeName");

            //    E.Property(E => E.Age)
            //     .IsRequired(false);

            //    E.Property(E => E.Salary)
            //     .HasColumnType("money");


            //    E.Property(E => E.DateOfCreation)
            //    .HasDefaultValueSql("GETDATE()");
            //}); 
            #endregion

            //modelBuilder.Entity<Employee>().ToView();
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
        }
        public AppDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-PEC2QL2\\SQLEXPRESS; Database = App01; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
