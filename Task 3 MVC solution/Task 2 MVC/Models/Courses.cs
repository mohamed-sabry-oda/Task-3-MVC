using System.ComponentModel.DataAnnotations.Schema;

namespace Task_2_MVC.Models
{
    public class Courses
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }
        [ForeignKey("Departments")]
        public int? DepartmentId { get; set; }
        public Departments Departments { get; set; }
        public List<Teachers> Teachers { get; set; }
        public List<StuCrsRes> StuCrsRes { get; set; }

    }
}
