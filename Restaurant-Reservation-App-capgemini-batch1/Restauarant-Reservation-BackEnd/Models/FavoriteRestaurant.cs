using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Restauarant_Reservation_BackEnd.Models
{
    public class FavoriteRestaurant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FavoriteId { get; set; }
        public virtual User? User { get; set; }
        [Required]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual Restaurant? Restaurant { get; set; }
        [Required]
        [ForeignKey(nameof(Restaurant))]
        public int RestaurantId { get; set; }
    }
}
