using ConsoleApp1.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            #region Configure fields
            //  Id
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1,1).IsRequired();

            //  Name
            builder.Property(b => b.Name).HasColumnName("Name").HasColumnType("nvarchar(50)").IsRequired();

            //  Pages
            builder.Property(b => b.Pages).HasColumnName("Pages").HasColumnType("int").IsRequired();

            //  YearPress
            builder.Property(b => b.YearPress).HasColumnName("YearPress").HasColumnType("int").IsRequired();

            //  Id_Themes
            builder.Property(b => b.Id_Themes).HasColumnName("Id_Themes").HasColumnType("int").IsRequired();

            //  Id_Category
            builder.Property(b => b.Id_Category).HasColumnName("Id_Category").HasColumnType("int").IsRequired();

            //  Id_Author
            builder.Property(b => b.Id_Author).HasColumnName("Id_Author").HasColumnType("int").IsRequired();

            //  Id_Press
            builder.Property(b => b.Id_Press).HasColumnName("Id_Press").HasColumnType("int").IsRequired();

            //  Comment
            builder.Property(b => b.Comment).HasColumnName("Comment").HasColumnType("text");

            //  Quantity
            builder.Property(b => b.Quantity).HasColumnName("Quantity").HasColumnType("int").IsRequired();
            #endregion

            #region Relations with other tables

            builder.HasOne<Author>().WithMany(author=> author.Books).HasForeignKey(book => book.Id_Author);
            builder.HasOne<Category>().WithMany(category => category.Books).HasForeignKey(book => book.Id_Category);
            builder.HasOne<Press>().WithMany(press =>  press.Books).HasForeignKey(book => book.Id_Press);
            builder.HasOne<Theme>().WithMany(theme => theme.Books).HasForeignKey(book => book.Id_Themes);

            #endregion
        }
    }
}
