using Microsoft.EntityFrameworkCore;
using Task_2_MVC.Data.DbContexts;

namespace Task_2_MVC.Models
{
    public class StudentsBL
    {
        PlatformDbContext context = new PlatformDbContext();

        public List<Students> ShowAll()
        {
            //use include for print Department name
            return context.Students.Include(S => S.Departments).ToList();
        }

        public Students ShowDetails(int id) 
        {
            return context.Students.SingleOrDefault(S => S.Id == id);
        }
    }
}
