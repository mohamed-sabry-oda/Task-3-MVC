using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task_2_MVC.Models;

namespace Task_2_MVC.ConfigurationClasses
{
    public class StudentsConfigurations : IEntityTypeConfiguration<Students>
    {
        public void Configure(EntityTypeBuilder<Students> builder)
        {
            //Relations One to Many
            builder.HasOne(S => S.Departments)
                .WithMany(S => S.Students)
                .HasForeignKey(S => S.DepartmentId)
                .OnDelete(DeleteBehavior.SetNull);

            //Relations Many to Many with courses
            builder.HasMany(S => S.StuCrsRes)
                .WithOne(S => S.Students)
                .HasForeignKey(S => S.StudentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
