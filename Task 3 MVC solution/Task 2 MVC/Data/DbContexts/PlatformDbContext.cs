using Microsoft.EntityFrameworkCore;
using Task_2_MVC.ConfigurationClasses;
using Task_2_MVC.Models;

namespace Task_2_MVC.Data.DbContexts
{
    public class PlatformDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Platform;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CoursesConfigurations());
            modelBuilder.ApplyConfiguration(new StuCrsResConfigurations());
            modelBuilder.ApplyConfiguration(new StudentsConfigurations());
            modelBuilder.ApplyConfiguration(new TeachersConfigurations());
            modelBuilder.ApplyConfiguration(new DepartmentsConfigurations());


        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<StuCrsRes> StuCrsRes { get; set; }
    }
}
