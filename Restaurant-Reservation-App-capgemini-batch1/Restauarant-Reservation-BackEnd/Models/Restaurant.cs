using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Restauarant_Reservation_BackEnd.Models
{
    public class Restaurant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RestaurantId { get; set; }
        [Required(ErrorMessage = "Enter your Name")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "name should contains 3 to 15 chars")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "only letters are allowed")]
        public string RestaurantName { get; set; }
        [Required(ErrorMessage = "enter description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "enter your location")]
        public string Location { get; set; }
        [Required(ErrorMessage = "enter your PhoneNumber")]
        [Phone(ErrorMessage = "Invaid phone number")]
        public string ContactNumber { get; set; }

        public double? Rating { get; set; }

       /* public virtual ICollection<FavoriteRestaurant> FavoriteRestaurants { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }*/

        public virtual ICollection<Review> Reviews { get; set; }

        //public virtual ICollection<Table> Tables { get; set; }
    }
}
