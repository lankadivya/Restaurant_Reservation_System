using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Restauarant_Reservation_BackEnd.Models
{
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MenuId { get; set; }
        public virtual Restaurant? Restaurant { get; set; }
        [Required]
        [ForeignKey(nameof(Restaurant))]
        public int RestaurantId { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
