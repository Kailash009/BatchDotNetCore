using System.ComponentModel.DataAnnotations;

namespace BatchMithilesh11AMWE.Models
{
    public class Customer
    {
        [Required(ErrorMessage ="Enter Name!!")]
        [MaxLength(50)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use Character only please!")]
        public string ?Cname { get; set; }
        
        [Required(ErrorMessage = "Enter Age!!")]
        [StringLength(2, ErrorMessage = "Max 2 digits")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Use Number only please!")]
        public string ?Age { get; set; }
        
        [Required(ErrorMessage = "Enter MobileNo!!")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Enter 10 Digit Only!!")]
        public string ?MobileNo { get; set; }

        [Required(ErrorMessage = "Enter Email!!")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string ?Email { get; set; }

        [Required(ErrorMessage = "Select Gender!!")]
        public string ?Gender { get; set; }

        [Required(ErrorMessage = "Enter Password!!")]
        [RegularExpression("^(?=.*[A-Za-z])(?=.*\\d)(?=.*[@$!%*#?&])[A-Za-z\\d@$!%*#?&]{8,}$", ErrorMessage = "Minimum eight characters, at least one letter, one number and one special character")]
        public string ?password { get; set; }

        [Required(ErrorMessage = "Enter Confirm Password!!")]
        [Compare("password")]
        public string? ConfirmPassword { get; set; }
    }
}
