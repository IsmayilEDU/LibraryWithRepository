using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Configurations
{
    public class ThemeConfiguration : IEntityTypeConfiguration<Theme>
    {
        public void Configure(EntityTypeBuilder<Theme> builder)
        {
            #region Configure fields
            //  Id
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  Name
            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("nvarchar(50)").IsRequired();
            #endregion
        }
    }
}
