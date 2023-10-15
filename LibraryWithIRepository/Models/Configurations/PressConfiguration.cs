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
    public class PressConfiguration : IEntityTypeConfiguration<Press>
    {
        public void Configure(EntityTypeBuilder<Press> builder)
        {
            #region Configure fields
            //  Id
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  Name
            builder.Property(p => p.Name).HasColumnName("Name").HasColumnType("nvarchar(50)").IsRequired();
            #endregion
        }
    }
}
