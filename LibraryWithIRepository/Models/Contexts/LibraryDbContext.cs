using ConsoleApp1.Configurations;
using ConsoleApp1.Models.Entities;
using Entities.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Contexts
{
    public class LibraryDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-0V84BDI\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Author>(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration<Book>(new BookConfiguration());
            modelBuilder.ApplyConfiguration<Category>(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration<Department>(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration<Faculty>(new FacultyConfiguration());
            modelBuilder.ApplyConfiguration<Group>(new GroupConfiguration());
            modelBuilder.ApplyConfiguration<Lib>(new LibConfiguration());
            modelBuilder.ApplyConfiguration<Press>(new PressConfiguration());
            modelBuilder.ApplyConfiguration<S_Card>(new S_CardConfiguration());
            modelBuilder.ApplyConfiguration<Student>(new StudentConfiguration());
            modelBuilder.ApplyConfiguration<T_Card>(new T_CardConfiguration());
            modelBuilder.ApplyConfiguration<Teacher>(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration<Theme>(new ThemeConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Lib> Libs { get; set; }
        public DbSet<Press> Presses { get; set; }
        public DbSet<S_Card> S_Cards { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<T_Card> T_Cards { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Theme> Themes { get; set; }
    }
}
