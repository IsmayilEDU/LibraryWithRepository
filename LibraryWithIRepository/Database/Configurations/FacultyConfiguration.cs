using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;

namespace Database.Configurations
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
