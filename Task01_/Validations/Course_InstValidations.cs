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
    internal class Course_InstValidations : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> CI)
        {
            CI.HasKey(CI => new { CI.Course_ID, CI.Course_InstID });
            CI.Property(CI => CI.evaluation)
              .IsRequired();
        }

    }
}
