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

    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {

            builder.HasKey(I => I.Id);

            builder.Property(I => I.Id).UseIdentityColumn(1, 1);

            builder.Property(I => I.Name)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(256);

            builder.Property(I => I.Address)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(256);

            builder.Property(I => I.Salary)
                   .IsRequired()
                   .HasColumnType("money");


            builder.Property(I => I.DeptId).IsRequired();

        }

       
    }
}
