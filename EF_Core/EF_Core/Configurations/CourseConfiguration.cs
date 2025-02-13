using EF_Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Configurations
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {



            builder.HasKey(C => C.Id);


            builder.Property(C => C.Name)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(256);



            builder.Property(C => C.Description)
                   .HasColumnType("varchar")
                   .HasMaxLength(256);

        }

       
    }
}
