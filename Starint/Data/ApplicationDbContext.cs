using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Starint.Data.Categories;
using Starint.Data.Colors;
using Starint.Data.Deliveries;
using Starint.Data.OfferColors;
using Starint.Data.Offers;
using Starint.Data.Orders;
using Starint.Data.ShoppingCartItems;
using Starint.Data.EmailLists;
using Starint.Data.Communications;

namespace Starint.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<EmailList> EmailLists { get; set; }
        public DbSet<OfferColor> OfferColors { get; set; }
        public DbSet<Communication> Communications { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Ekran RGB", Description="" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, Name = "Jednokolorowe", Description = "" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, Name = "Dwukolorowe", Description = "" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 4, Name = "Krzyże apteczne", Description = "" });

            modelBuilder.Entity<Communication>().HasData(new Communication { Id = 1, Name = "USB"});
            modelBuilder.Entity<Communication>().HasData(new Communication { Id = 2, Name = "LAN" });
            modelBuilder.Entity<Communication>().HasData(new Communication { Id = 3, Name = "Wifi" });

            modelBuilder.Entity<Delivery>().HasData(new Delivery { Id = 1, Name = "Kurier DPD", Description = "", Price = 30 });
            modelBuilder.Entity<Delivery>().HasData(new Delivery { Id = 2, Name = "Pałeta", Description = "", Price = 100 });
            modelBuilder.Entity<Delivery>().HasData(new Delivery { Id = 3, Name = "Odbiór osobisty", Description = "", Price = 0 });

        }
    }
}
