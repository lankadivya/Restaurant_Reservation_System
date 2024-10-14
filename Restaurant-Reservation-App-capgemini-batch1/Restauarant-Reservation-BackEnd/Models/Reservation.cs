using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Restauarant_Reservation_BackEnd.Models
{
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReservationId { get; set; }
        public virtual User? User { get; set; }
        [Required]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual Restaurant? Restaurant { get; set; }
        [Required]
        [ForeignKey(nameof(Restaurant))]
        public int RestaurantId { get; set; }
        [Required]
        public DateTime ReservationDate { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "status cannot be longer than 50 characters.")]
        public string? Status { get; set; }
    }
}
