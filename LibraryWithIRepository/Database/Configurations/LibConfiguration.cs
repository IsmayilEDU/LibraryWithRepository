using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;


namespace Database.Configurations
{
    public class LibConfiguration : IEntityTypeConfiguration<Lib>
    {
        public void Configure(EntityTypeBuilder<Lib> builder)
        {
            #region Configure fields
            //  Id
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  FirstName
            builder.Property(l => l.FirstName).HasColumnName("FirstName").HasColumnType("nvarchar(50)").IsRequired();

            //  LastName
            builder.Property(l => l.LastName).HasColumnName("LastName").HasColumnType("nvarchar(50)").IsRequired();
            #endregion
        }
    }
}
