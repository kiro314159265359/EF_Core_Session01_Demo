using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Core_Session01_Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core_Session01_Demo.Configurations
{
    internal class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {
            E.HasKey(E => E.EmpId);

            E.Property(E => E.Name)
            .IsRequired(true)
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .HasColumnName("EmployeeName");

            E.Property(E => E.Age)
             .IsRequired(false);

            E.Property(E => E.Salary)
             .HasColumnType("money");


            E.Property(E => E.DateOfCreation)
            .HasDefaultValueSql("GETDATE()");
        }
    }
}
