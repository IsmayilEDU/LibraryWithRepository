
using Database.Configurations;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Database.Contexts
{
    public class LibraryDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=DESKTOP-0V84BDI\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
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

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Lib> Libs { get; set; }
        public virtual DbSet<Press> Presses { get; set; }
        public virtual DbSet<S_Card> S_Cards { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<T_Card> T_Cards { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Theme> Themes { get; set; }
    }
}
