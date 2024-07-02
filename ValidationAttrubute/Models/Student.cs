using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ValidationAttrubute.Models
{
    public class Student
    {
        [DisplayName("Student Name")]
        [Required(ErrorMessage = "Name is Required.")]
        //[StringLength(15,MinimumLength =3,ErrorMessage ="Name must be within 3 to 15 characters only")]
        //[MaxLength(15)]
        [MinLength(3,ErrorMessage = "Minimum length must be 3 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is Required.")]
        //[EmailAddress]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Age is Required.")]
        [Range(10,50)]
        public int? Age { get; set; }

        //[Required(ErrorMessage = "Password is Required.")]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", ErrorMessage = "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one number, and one special character.")]
        //public string Password { get; set; }
        //[Required(ErrorMessage = "Confirm Password is Required.")]
        //[Compare("Password",ErrorMessage ="Both password must be identical.")]
        //[DisplayName("Enter Confirm Password")]
        //public string ConfirmPassword { get; set; }
        //[Required(ErrorMessage = "Phone is Required.")]
        //[RegularExpression(@"^\(?\d{3}\)?[-. ]?\d{3}[-. ]?\d{4}$", ErrorMessage = "Invalid phone number.")]
        //public string Phone { get; set; }
        //[Required(ErrorMessage = "Website URL is Required.")]
        //[Url(ErrorMessage = "Invalid URL")]
        //public string WebsiteURL { get; set; }
    }
}
