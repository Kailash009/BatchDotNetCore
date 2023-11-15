namespace BatchMithilesh11AMWE.Models
{
    public class Teacher
    {
        public int tid { get; set; }
        public string ?tName { get; set; }
        public int tAge { get; set; }
        public string ?tCity { get; set; }
        public string ?tRole { get; set; }
        public string ?tImage { get; set; }
        public List<Student> ?ListofStudents { get; set; }
    }
}



