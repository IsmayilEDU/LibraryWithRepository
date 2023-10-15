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
    public class FacultyConfiguration : IEntityTypeConfiguration<Faculty>
    {
        public void Configure(EntityTypeBuilder<Faculty> builder)
        {
            #region Configure fields
            //  Id
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  Name
            builder.Property(f => f.Name).HasColumnName("Name").HasColumnType("nvarchar(50)").IsRequired();
            #endregion
        }
    }
}
