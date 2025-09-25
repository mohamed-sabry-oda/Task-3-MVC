namespace Task_2_MVC.Models
{
    public class Departments
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string MgrName { get; set; }

        public List<Students> Students { get; set; }
        public List<Teachers> Teachers { get; set; }  
        public List<Courses> Courses { get; set; }
    }
}
