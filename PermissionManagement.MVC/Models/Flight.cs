using System.ComponentModel.DataAnnotations;
using System;

namespace PermissionManagement.MVC.Models
{
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }

        [Required]
        [StringLength(100)]
        public string LocationFrom { get; set; }

        [Required]
        [StringLength(100)]
        public string LocationTo { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateTimeTakeOff { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DateTimeLanding { get; set; }

        [StringLength(100)]
        public string PlaneType { get; set; }

        [Required]
        public int? PlaneId { get; set; }

        [StringLength(100)]
        public string PilotName { get; set; }

        [Required]
        public int PassengerCapacity { get; set; }

        [Required]
        public int BusinessClassCapacity { get; set; }
    }
}
