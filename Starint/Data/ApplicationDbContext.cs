using Microsoft.EntityFrameworkCore;
using Starint.Data.Categories;
using Starint.Data.Colors;
using Starint.Data.Deliveries;
using Starint.Data.OfferColors;
using Starint.Data.Offers;
using Starint.Data.Orders;
using Starint.Data.ShoppingCartItems;
using Starint.Data.Users;

namespace Starint.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OfferColor> OfferColors { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
