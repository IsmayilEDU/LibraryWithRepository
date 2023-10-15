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
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            #region Configure fields
            //  Id
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  FirstName
            builder.Property(a => a.FirstName).HasColumnName("FirstName").HasColumnType("nvarchar").HasMaxLength(50).IsRequired();

            //  LastName
            builder.Property(a => a.LastName).HasColumnName("LastName").HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            #endregion

            
        }

        
    }
}
