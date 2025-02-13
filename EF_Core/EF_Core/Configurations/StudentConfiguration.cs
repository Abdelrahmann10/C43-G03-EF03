using EF_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using EF_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
       

        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(S => S.Id);

            builder.Property(S => S.FName)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(256);

            builder.Property(S => S.LName)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(256);


            builder.Property(S => S.Address)
                 .HasColumnType("varchar")
                 .HasMaxLength(256);

            builder.Property(S => S.Age)
                   .IsRequired();

        }
    }
}

