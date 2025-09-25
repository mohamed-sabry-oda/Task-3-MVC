using Microsoft.AspNetCore.Mvc;
using Task_2_MVC.Models;

namespace Task_2_MVC.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult ShowAll()
        {
            StudentsBL studentsBL = new StudentsBL();
            List<Students> StudentsList = studentsBL.ShowAll();
            return View("ShowAll",StudentsList);
        }

        public IActionResult ShowDetails(int id)
        {
            StudentsBL studentsBL=new StudentsBL();
            Students Student = studentsBL.ShowDetails(id);
            return View("ShowDetails",Student);
        }
    }
}
