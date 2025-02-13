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
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(D => D.Id);

            builder.Property(D => D.Id)
                   .UseIdentityColumn(1, 1);

            builder.Property(D => D.Name)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(256);


            builder.Property(D => D.HiringDate).IsRequired();


        }

       
    }
}
