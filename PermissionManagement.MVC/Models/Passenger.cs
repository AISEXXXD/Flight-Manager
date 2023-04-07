using System.ComponentModel.DataAnnotations;

namespace PermissionManagement.MVC.Models
{
    public class Passenger
    {
        [Key]
        public int PassengerId { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string SirName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        public int EGN { get; set; }

        [Required]
        public int TelephoneNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string Nationallity { get; set; }

        [Required]
        [StringLength(100)]
        public string TicketType { get; set; }
    }
}
