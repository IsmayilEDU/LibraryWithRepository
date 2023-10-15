using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;


namespace Database.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            #region Configure fields
            //  Id
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  Name
            builder.Property(c => c.Name).HasColumnName("Name").HasColumnType("nvarchar(50)").IsRequired();
            #endregion

        }
    }
}
