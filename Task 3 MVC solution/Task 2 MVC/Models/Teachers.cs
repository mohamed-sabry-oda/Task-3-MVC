using System.ComponentModel.DataAnnotations.Schema;

namespace Task_2_MVC.Models
{
    public class Teachers
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Salary { get; set; }

        public string Address { get; set; }
        [ForeignKey("Departments")]

        public int? DepartmentId { get; set; }
        public Departments Departments { get; set; }
        [ForeignKey("Courses")]
        public int? CourseId { get; set; }
        public Courses Courses { get; set; }
    }
}
