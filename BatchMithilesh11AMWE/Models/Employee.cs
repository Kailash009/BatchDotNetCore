using System.ComponentModel.DataAnnotations;

namespace BatchMithilesh11AMWE.Models
{
    public class Employee
    {
        public int EID { get; set; }   // Properties.

        [Display(Name ="Employee Name")]
        public string ?Name { get; set; }

        [Display(Name = "Employee Age")]

        public int Age { get; set; }

        [Display(Name = "Employee City")]

        public string ?City { get; set; }

        [Display(Name = "Employee Salary")]

        public double Salary { get; set; }

        [Required]
        public string ?Gender { get; set; }


        //int ?a = null;
        //Nullable<int> b = null;


        //int a;
        //public void setData()
        //{
        //    EID = 34;  // SET
        //}
        //public int getData()
        //{
        //    return EID;  // GET
        //}

    }
}
