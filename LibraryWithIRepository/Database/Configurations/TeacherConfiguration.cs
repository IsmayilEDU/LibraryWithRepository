using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;


namespace Database.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            #region Configure fields
            //  Id
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  FirstName
            builder.Property(t => t.FirstName).HasColumnName("FirstName").HasColumnType("nvarchar(50)").IsRequired();

            //  LastName
            builder.Property(t => t.LastName).HasColumnName("LastName").HasColumnType("nvarchar(50)").IsRequired();
            #endregion

            #region Relations with other tables
            builder.HasOne<Department>().WithMany(department => department.Teachers).HasForeignKey(teacher => teacher.Id_Dep);
            #endregion
        }
    }
}
