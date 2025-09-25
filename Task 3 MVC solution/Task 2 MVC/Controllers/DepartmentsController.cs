using Microsoft.AspNetCore.Mvc;
using Task_2_MVC.Models;
using Task_2_MVC.ViewModel;

namespace Task_2_MVC.Controllers
{
    public class DepartmentsController : Controller
    {
            DepartmentsBL departmentsBL = new DepartmentsBL();
        public IActionResult ShowAll()
        {
            List<Departments> DeptList = departmentsBL.ShowAll();
            return View("ShowAll",DeptList);
        }

        public IActionResult ShowDetails(int id)
        {
            Departments Dept = departmentsBL.ShowDetails(id);
            return View("ShowDetails",Dept);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }
        [HttpPost]
        public IActionResult SaveAdd(Departments DeptSent)
        {
            if(DeptSent is not null)
            {
                departmentsBL.DeptAdd(DeptSent);
                return RedirectToAction("ShowAll");
            }
            else
            {
                return View("Add",DeptSent);
            }
        }

        public IActionResult DetailsVM(int id)
        {
            Departments DeptModel = departmentsBL.ShowDetails(id);

            DeptWithExtraInfoViewModel viewModel = new DeptWithExtraInfoViewModel()
            {
                DeptName = DeptModel.Name,
                StudentsExceed25 = DeptModel.Students
                                            .Where(S => S.Age > 25)
                                            .Select(S => S.Name).ToList(),
                DeptState = DeptModel.Students.Count() > 50 ? "Main" : "Branch"
            };

            return View("DetailsVM",viewModel);
        }
    }
}
