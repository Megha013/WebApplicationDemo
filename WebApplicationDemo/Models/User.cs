using System.ComponentModel.DataAnnotations;

namespace WebApplicationDemo.Models
{
    public class User
    {
        [Required(ErrorMessage ="name is required")]
        [MaxLength(40)]
        [MinLength(3)]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "email is required")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "age is required")]
        [Range(minimum: 18, maximum: 58)]
        public int Age { get; set; }

        [Required(ErrorMessage = "password is required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }


        [Required(ErrorMessage = "confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "password does not match")]
        public string? ConfirmPassword { get; set; } // ? is to allow null

    }
}
