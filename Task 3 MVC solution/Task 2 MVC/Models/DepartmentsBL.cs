using Microsoft.EntityFrameworkCore;
using Task_2_MVC.Data.DbContexts;

namespace Task_2_MVC.Models
{
    public class DepartmentsBL
    {
        PlatformDbContext context = new PlatformDbContext();
        public List<Departments> ShowAll()
        {
            return context.Departments.ToList();
        }

        public Departments ShowDetails(int id)
        {
            return context.Departments.Include(D => D.Students).FirstOrDefault(D => D.Id == id);
        }

        public void DeptAdd(Departments DeptSent)
        {
            //save to local
            context.Departments.Add(DeptSent);
            //save to DB
            context.SaveChanges();
        }
    }
}
