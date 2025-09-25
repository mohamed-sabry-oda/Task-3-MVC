using System.ComponentModel.DataAnnotations.Schema;

namespace Task_2_MVC.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        [ForeignKey("Departments")]
        public int? DepartmentId { get; set; }

        public Departments Departments { get; set; }
        public List<StuCrsRes> StuCrsRes { get; set; } 
    }
}
