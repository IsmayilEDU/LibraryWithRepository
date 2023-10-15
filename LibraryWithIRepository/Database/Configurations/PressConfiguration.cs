using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;

namespace Database.Configurations
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
