using System.ComponentModel.DataAnnotations.Schema;

namespace Task_2_MVC.Models
{
    public class StuCrsRes
    {
        public int Grade { get; set; }
        [ForeignKey("Students")]
        public int StudentId { get; set; }
        public Students Students { get; set; }
        [ForeignKey("Courses")]
        public int CourseId { get; set; }
        public Courses Courses { get; set; }
    }
}
