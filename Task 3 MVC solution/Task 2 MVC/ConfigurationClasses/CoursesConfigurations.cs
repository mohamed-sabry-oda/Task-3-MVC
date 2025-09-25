using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task_2_MVC.Models;

namespace Task_2_MVC.ConfigurationClasses
{
    public class CoursesConfigurations : IEntityTypeConfiguration<Courses>
    {
        public void Configure(EntityTypeBuilder<Courses> builder)
        {
            //Relations One to Many
            builder.HasOne(S => S.Departments)
                .WithMany(S => S.Courses)
                .HasForeignKey(S => S.DepartmentId)
                .OnDelete(DeleteBehavior.SetNull);


            //Relations Many to Many with students
            builder.HasMany(S => S.StuCrsRes)
                .WithOne(S => S.Courses)
                .HasForeignKey(S => S.CourseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
