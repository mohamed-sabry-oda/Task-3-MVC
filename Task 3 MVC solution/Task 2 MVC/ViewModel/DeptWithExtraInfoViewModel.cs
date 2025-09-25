using Task_2_MVC.Models;

namespace Task_2_MVC.ViewModel
{
    public class DeptWithExtraInfoViewModel
    {
        public string DeptName { get; set; }

        public List<string> StudentsExceed25 { get; set; }

        public string DeptState { get; set; }
    }
}
