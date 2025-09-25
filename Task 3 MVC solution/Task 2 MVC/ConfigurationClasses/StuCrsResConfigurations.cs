using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task_2_MVC.Models;

namespace Task_2_MVC.ConfigurationClasses
{
    public class StuCrsResConfigurations : IEntityTypeConfiguration<StuCrsRes>
    {
        public void Configure(EntityTypeBuilder<StuCrsRes> builder)
        {
            builder.HasKey(SC => new { SC.StudentId, SC.CourseId });
        }
    }
}
