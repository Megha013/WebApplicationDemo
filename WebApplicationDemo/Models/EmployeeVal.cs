using System.ComponentModel.DataAnnotations;

namespace WebApplicationDemo.Models
{
    public class EmployeeVal
    {
        [Required(ErrorMessage = "id is required")]
        [MaxLength(20)]
        [MinLength(5)]
        public string? EmpId { get; set; }

        [Required(ErrorMessage = "name is required")]
        [MaxLength(40)]
        [MinLength(3)]
        public string? EmpName { get; set; }

        [Required(ErrorMessage = "email is required")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        //[Required(ErrorMessage = "department is required")]
        //[DataType(DataType.Department)]
        //public string? Dept { get; set; }

        [Required(ErrorMessage = "age is required")]
        [Range(minimum: 18, maximum: 58)]
        public int Age { get; set; }

        [Required(ErrorMessage = "password is required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }


        [Required(ErrorMessage = "confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "password does not match")]
        public string? ConfirmPassword { get; set; }


        [Required(ErrorMessage = "salary is required")]
        public int Salary { get; set; }
    }
}
