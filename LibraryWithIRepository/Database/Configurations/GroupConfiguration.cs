using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;

namespace Database.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            #region Configure fields
            //  Id
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  Name
            builder.Property(g => g.Name).HasColumnName("Name").HasColumnType("nvarchar(50)").IsRequired();

            //  Id_Faculty
            builder.Property(g => g.Id_Faculty).HasColumnName("Id_Faculty").HasColumnType("int").IsRequired();
            #endregion

            #region Relations with other tables
            builder.HasOne<Faculty>().WithMany(faculty => faculty.Groups).HasForeignKey(group => group.Id_Faculty);
            #endregion
        }
    }
}
