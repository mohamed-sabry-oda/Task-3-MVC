using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task_2_MVC.Models;

namespace Task_2_MVC.ConfigurationClasses
{
    public class TeachersConfigurations : IEntityTypeConfiguration<Teachers>
    {
        public void Configure(EntityTypeBuilder<Teachers> builder)
        {
            //Relations One to Many
            builder.HasOne(S => S.Departments)
                .WithMany(S => S.Teachers)
                .HasForeignKey(S => S.DepartmentId)
                .OnDelete(DeleteBehavior.SetNull);

            //Relations One to Many
            builder.HasOne(S => S.Courses)
                .WithMany(S => S.Teachers)
                .HasForeignKey(S => S.CourseId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
