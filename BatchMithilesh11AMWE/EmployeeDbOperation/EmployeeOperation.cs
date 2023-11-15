using BatchMithilesh11AMWE.Models;

namespace BatchMithilesh11AMWE.EmployeeDbOperation
{
    public class EmployeeOperation
    {
       public static List<Employee> getEmployees()
       {
            List<Employee> empList = new List<Employee>();
            Employee emp = new Employee();
            emp.EID = 101;
            emp.Name = "Rajesh";
            emp.Age = 19;
            emp.City = "Noida";
            emp.Salary = 3445.34;
            empList.Add(emp); // First Employee Added

            emp = new Employee();
            emp.EID = 102;
            emp.Name = "Mohit";
            emp.Age = 29;
            emp.City = "Delhi";
            emp.Salary = 4445.34;
            empList.Add(emp);

            Employee emp1 = new();
            emp1.EID = 103;
            emp1.Name = "Shivam";
            emp1.Age = 32;
            emp1.City = "Rajasthan";
            emp1.Salary = 54445.34;
            empList.Add(emp1);

            emp = new Employee();
            emp.EID = 104;
            emp.Name = "Tikam";
            emp.Age = 14;
            emp.City = "Banglore";
            emp.Salary = 50445.34;
            empList.Add(emp);


            emp = new Employee();
            emp.EID = 105;
            emp.Name = "Salman";
            emp.Age = 54;
            emp.City = "Mumbai";
            emp.Salary = 30943.34;
            empList.Add(emp);

            return empList;
        }
    }
}
