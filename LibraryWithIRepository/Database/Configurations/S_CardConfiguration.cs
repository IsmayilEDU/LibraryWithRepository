using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;


namespace Database.Configurations
{
    public class S_CardConfiguration : IEntityTypeConfiguration<S_Card>
    {
        public void Configure(EntityTypeBuilder<S_Card> builder)
        {
            #region Configure fields
            //  Id
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").HasColumnType("int");

            //  DateIn
            builder.Property(c => c.DateIn).HasColumnName("DateIn").HasColumnType("datetime2");

            //  DateOut
            builder.Property(c => c.DateOut).HasColumnName("DateOut").HasColumnType("datetime2");

            //  Id_Student
            builder.Property(c => c.Id_Student).HasColumnName("Id_Student").HasColumnType("int").IsRequired();

            //  Id_Book
            builder.Property(c => c.Id_Book).HasColumnName("Id_Book").HasColumnType("int").IsRequired();

            //  Id_Lib
            builder.Property(c => c.Id_Lib).HasColumnName("Id_Lib").HasColumnType("int").IsRequired();

            #endregion

            #region Relations with other tables
            builder.HasOne<Lib>().WithMany(lib => lib.S_Cards).HasForeignKey(s_card => s_card.Id_Lib);
            builder.HasOne<Student>().WithMany(student => student.S_Cards).HasForeignKey(s_card => s_card.Id_Student);
            builder.HasOne<Book>().WithMany(book => book.S_Cards).HasForeignKey(s_card => s_card.Id_Book);
            #endregion
        }
    }
}
