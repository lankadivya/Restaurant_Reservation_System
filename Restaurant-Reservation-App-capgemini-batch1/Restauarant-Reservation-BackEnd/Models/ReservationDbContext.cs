using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Restauarant_Reservation_BackEnd.Models
{
    public class ReservationDbContext : DbContext
    {
        public ReservationDbContext()
        {
        }

        public ReservationDbContext(DbContextOptions<ReservationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FavoriteRestaurant> FavoriteRestaurants { get; set; }

        public virtual DbSet<Menu> Menus { get; set; }

        public virtual DbSet<MenuItem> MenuItems { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Reservation> Reservations { get; set; }

        public virtual DbSet<Restaurant> Restaurants { get; set; }

        public virtual DbSet<Review> Reviews { get; set; }

        public virtual DbSet<Table> Tables { get; set; }

        public virtual DbSet<User> Users { get; set; }
    }
}
