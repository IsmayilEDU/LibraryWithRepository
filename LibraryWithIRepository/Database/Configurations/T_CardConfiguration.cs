using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;

namespace Database.Configurations
{
    public class T_CardConfiguration : IEntityTypeConfiguration<T_Card>
    {
        public void Configure(EntityTypeBuilder<T_Card> builder)
        {
            #region Configure fields
            //  Id
            builder.HasKey(c =>c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1,1).IsRequired();

            //  DateIn
            builder.Property(c => c.DateIn).HasColumnName("DateIn").HasColumnType("datetime2");

            //  DateOut
            builder.Property(c => c.DateIn).HasColumnName("DateOut").HasColumnType("datetime2");

            //  Id_Teacher
            builder.Property(c => c.Id_Teacher).HasColumnName("Id_Teacher").HasColumnType("int").IsRequired();

            //  Id_Book
            builder.Property(c => c.Id_Book).HasColumnName("Id_Book").HasColumnType("int").IsRequired();

            //  Id_Lib
            builder.Property(c => c.Id_Lib).HasColumnName("Id_Lib").HasColumnType("int").IsRequired();
            #endregion

            #region Relations with other tables
            builder.HasOne<Book>().WithMany(book => book.T_Cards).HasForeignKey(t_card => t_card.Id_Book);
            builder.HasOne<Teacher>().WithMany(teacher => teacher.T_Cards).HasForeignKey(t_card => t_card.Id_Teacher);
            builder.HasOne<Lib>().WithMany(lib => lib.T_Cards).HasForeignKey(t_card => t_card.Id_Lib);
            #endregion
        }
    }
}
