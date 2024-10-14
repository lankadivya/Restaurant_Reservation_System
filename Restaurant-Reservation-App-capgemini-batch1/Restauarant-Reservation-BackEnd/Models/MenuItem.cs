using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Restauarant_Reservation_BackEnd.Models
{
    public class MenuItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MenuItemId { get; set; }
        public virtual Menu? Menu { get; set; }
        [Required]
        [ForeignKey(nameof(Menu))]
        public int MenuId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Item name cannot be longer than 100 characters.")]
        public string ItemName { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        public string Description { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Category cannot be longer than 50 characters.")]
        public string Category { get; set; }
    }
}
