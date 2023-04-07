using System.ComponentModel.DataAnnotations;

namespace PermissionManagement.MVC.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        public int EGN { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string Role { get; set; }
    }
}
