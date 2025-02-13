using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task01.Entities;

namespace Task01_.Validations
{
    internal class DepartmentValidations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.HasKey(D => D.ID);
            D.Property(D => D.Name)
             .IsRequired()
             .HasMaxLength(200)
             .HasColumnName("DepartmentName");
            D.Property(D => D.Ins_ID)
             .IsRequired();
            D.Property(D => D.HiringDate)
             .IsRequired(false)
             .HasDefaultValueSql("GETDATE()");
        }
    }
}
