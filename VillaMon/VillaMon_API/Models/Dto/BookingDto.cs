using System;
using System.ComponentModel.DataAnnotations;

namespace VillaMon_API.Models.Dto
{
    public class BookingDTO
    {
        public int BookingId { get; set; }

        [Required]
        public int VillaId { get; set; }  // Foreign key to relate with VillaDTO

        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Guest count must be greater than 0")]
        public int GuestCount { get; set; }

        [Required]
        [MaxLength(100)]
        public string GuestName { get; set; }

        [Required]
        [EmailAddress]
        public string GuestEmail { get; set; }

        [Required]
        [MaxLength(20)]
        public string PaymentStatus { get; set; }  // Example: "Paid", "Pending", "Cancelled"

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
