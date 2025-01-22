using LSC.ResturantTableBookingApp.Core;
using Microsoft.EntityFrameworkCore;

namespace LSC.ResturantTableBookingApp.Data
{
    public class ResturantTableBookingDbContext : DbContext
    {
        public ResturantTableBookingDbContext(DbContextOptions<ResturantTableBookingDbContext> options) : base(options)
        {

        }

        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<DiningTables> DiningTables { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<RestaurantBranch> RestaurantBranches { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<User> User { get; set; }
        

    }
}