using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;

namespace Database.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            #region Configure fields
            //  Id
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  FirstName
            builder.Property(s => s.FirstName).HasColumnName("FirstName").HasColumnType("nvarchar(50)").IsRequired();

            //  LastName
            builder.Property(s => s.LastName).HasColumnName("LastName").HasColumnType("nvarchar(50)").IsRequired();

            //  Id_Group
            builder.Property(s => s.Id_Group).HasColumnName("Id_Group").HasColumnType("int").IsRequired();

            //  Term
            builder.Property(s => s.Term).HasColumnName("Term").HasColumnType("int").IsRequired();
            #endregion

            #region Relations with other tables
            builder.HasOne<Group>().WithMany(group => group.Students).HasForeignKey(student => student.Id_Group);
            #endregion
        }
    }
}
