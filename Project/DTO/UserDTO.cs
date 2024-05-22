using System.ComponentModel.DataAnnotations;

namespace TurfBooking.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


    }

    public class NewUserDTO
    {
        /* public string Name { get; set; }
         public string Email { get; set; }
         public string Password { get; set; }
         public string Phone { get; set; }*/
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^[6789]\d{9}$", ErrorMessage = "Invalid phone number format")]
        public string Phone { get; set; }

    }

}
