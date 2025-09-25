using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task_2_MVC.Models;

namespace Task_2_MVC.ConfigurationClasses
{
    public class DepartmentsConfigurations : IEntityTypeConfiguration<Departments>
    {
        public void Configure(EntityTypeBuilder<Departments> builder)
        {

           
        }
    }
}
