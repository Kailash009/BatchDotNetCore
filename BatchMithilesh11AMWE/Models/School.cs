namespace BatchMithilesh11AMWE.Models
{
    public class School
    {
        public int School_Id { get; set; }
        public string ?School_Name { get; set; }
        public string ?School_City { get; set; }

        public List<Teacher> ?ListofTeachers { get; set; } // List of Teacher
    }
}



