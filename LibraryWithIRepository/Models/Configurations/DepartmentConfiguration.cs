using ConsoleApp1.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            #region Configure fields
            //  Id
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  Name
            builder.Property(d => d.Name).HasColumnName("Name").HasColumnType("nvarchar(50)").IsRequired();
            #endregion
        }
    }
}
