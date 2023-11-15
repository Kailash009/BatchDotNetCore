using BatchMithilesh11AMWE.Models;

namespace BatchMithilesh11AMWE.SchoolDbOperation
{
    public class SchoolOperations
    {
        public static List<Student> ListofStudentforTeacherA()
        {
            List<Student> stuList = new List<Student>();
            Student st = new Student();
            st.Sid = 1;
            st.sName = "Raj";
            st.sAge = 18;
            st.Mobileno = "87780733";
            st.sCity = "Noida";
            stuList.Add(st);

            st = new Student();
            st.Sid = 2;
            st.sName = "Kavita";
            st.sAge = 23;
            st.Mobileno = "37780733";
            st.sCity = "Hyderabad";
            stuList.Add(st);

            st = new Student();
            st.Sid = 3;
            st.sName = "Pankaj";
            st.sAge = 13;
            st.Mobileno = "47780733";
            st.sCity = "Delhi";
            stuList.Add(st);

            return stuList;
        }
        public static List<Student> ListofStudentforTeacherB()
        {
            List<Student> stuList = new List<Student>();
            Student st = new Student();
            st.Sid = 4;
            st.sName = "Saurabh";
            st.sAge = 28;
            st.Mobileno = "84780733";
            st.sCity = "Kanpur";
            stuList.Add(st);

            st = new Student();
            st.Sid = 5;
            st.sName = "Aditiya";
            st.sAge = 24;
            st.Mobileno = "57780733";
            st.sCity = "Mumbai";
            stuList.Add(st);

            return stuList;
        }
        public static List<Student> ListofStudentforTeacherC()
        {
            List<Student> stuList = new List<Student>();
            Student st = new Student();
            st.Sid = 6;
            st.sName = "Mandy";
            st.sAge = 28;
            st.Mobileno = "57780733";
            st.sCity = "Shimla";
            stuList.Add(st);

            st = new Student();
            st.Sid = 7;
            st.sName = "Rohan";
            st.sAge = 15;
            st.Mobileno = "64780733";
            st.sCity = "Lucknow";
            stuList.Add(st);

            st = new Student();
            st.Sid = 8;
            st.sName = "Pintu";
            st.sAge = 23;
            st.Mobileno = "87780733";
            st.sCity = "Rajasthan";
            stuList.Add(st);

            st = new Student();
            st.Sid = 9;
            st.sName = "Tikam";
            st.sAge = 19;
            st.Mobileno = "45780733";
            st.sCity = "Goa";
            stuList.Add(st);

            return stuList;
        }
        public static  List<Teacher> GetTeachers()
        {
            List<Teacher> tchList = new List<Teacher>();
            Teacher tch = new Teacher();
            tch.tid = 101;
            tch.tName = "John";
            tch.tAge = 45;
            tch.tCity = "London";
            tch.tRole = "Computer Science";
            tch.tImage = "images/team-1.jpg";
            tch.ListofStudents = ListofStudentforTeacherA();
            tchList.Add(tch); // First Teacher Added

            tch = new Teacher();
            tch.tid = 102;
            tch.tName = "Marry";
            tch.tAge = 35;
            tch.tCity = "Newzealand";
            tch.tRole = "Math";
            tch.tImage = "images/team-4.jpg";
            tch.ListofStudents = ListofStudentforTeacherB();
            tchList.Add(tch); // Second Teacher Added

            tch = new Teacher();
            tch.tid = 103;
            tch.tName = "Kelvin";
            tch.tAge = 46;
            tch.tCity = "America";
            tch.tRole = "Physics";
            tch.tImage = "images/testimonial-2.jpg";
            tch.ListofStudents = ListofStudentforTeacherC();
            tchList.Add(tch); // Third Teacher Added

            return tchList;
        }
        public static School getSchool()
        {
            School sc = new School();
            sc.School_Id = 899083;
            sc.School_Name = "Delhi Public School";
            sc.School_City = "Delhi";
            sc.ListofTeachers = GetTeachers();
            return sc;
        }
    }
}
