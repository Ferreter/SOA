using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VillaMon_API.Models
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingId { get; set; }

        [ForeignKey("Villa")]
        public int VillaId { get; set; }  // Foreign key to relate with Villa table

        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int GuestCount { get; set; }
        public string GuestName { get; set; }
        public string GuestEmail { get; set; }
        public string PaymentStatus { get; set; }  // Example: "Paid", "Pending", "Cancelled"

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        // Navigation property
        public Villa Villa { get; set; }
    }
}
