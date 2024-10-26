using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using web.data.models;

namespace web.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<category>().HasData(
         new category { Id = 1, Name = "Impressionism", Description = "19th-century art movement characterized by small, thin brush strokes and emphasis on light and movement." },
         new category { Id = 2, Name = "Renaissance", Description = "A period in European history marking the revival of classical learning and wisdom." },
         new category { Id = 3, Name = "Abstract", Description = "Art that uses shapes, colors, forms, and gestural marks to achieve its effect rather than depicting objects." },
         new category { Id = 4, Name = "Modern", Description = "A broad category that reflects artistic work produced during the late 19th to mid-20th century." },
         new category { Id = 5, Name = "Ancient", Description = "Art from ancient civilizations, including Egyptian, Mesopotamian, and classical Greek." }
     );
            modelBuilder.Entity<loyaltyCard>().HasData(
            new loyaltyCard { Id = 1, Name = "Bronze", Description = "10% Off" },
            new loyaltyCard { Id = 2, Name = "Silver", Description = "20% Off" },
            new loyaltyCard { Id = 3, Name = "Gold", Description = "30% Off" },
            new loyaltyCard { Id = 4, Name = "Platinum", Description = "40% Off" },
            new loyaltyCard { Id = 5, Name = "Crystal", Description = "50% Off" }
        );
            modelBuilder.Entity<pieceOfArt>().HasData(
            new pieceOfArt { Id = 1, Title = "Starry Night", Price = "100000", Publication_date = new DateTime(1889, 6, 1), CategoryId = 1 },
            new pieceOfArt { Id = 2, Title = "The Mona Lisa", Price = "500000", Publication_date = new DateTime(1503, 8, 1), CategoryId = 2 },
            new pieceOfArt { Id = 3, Title = "Composition VIII", Price = "120000", Publication_date = new DateTime(1923, 7, 1), CategoryId = 3 },
            new pieceOfArt { Id = 4, Title = "The Persistence of Memory", Price = "200000", Publication_date = new DateTime(1931, 4, 1), CategoryId = 4 },
            new pieceOfArt { Id = 5, Title = "Small Pyramid", Price = "150000", Publication_date = new DateTime(2500, 1, 1), CategoryId = 5 }
        );
            modelBuilder.Entity<user>().HasData(
           new user { Id = 1, Name = "John Doe", Email = "johndoe@example.com", age = 30, LoyaltyId = 1 },
           new user { Id = 2, Name = "Jane Smith", Email = "janesmith@example.com", age = 25, LoyaltyId = 2 },
           new user { Id = 3, Name = "Michael Johnson", Email = "michaelj@example.com", age = 35, LoyaltyId = 3 },
           new user { Id = 4, Name = "Sarah Connor", Email = "sarahc@example.com", age = 28, LoyaltyId = 4 },
           new user { Id = 5, Name = "Tony Stark", Email = "tonystark@example.com", age = 45, LoyaltyId = 5 }
        );
        }
        public DbSet<user> Users { get; set; }
        public DbSet<loyaltyCard> Cards { get; set; }
        public DbSet<pieceOfArt> Arts { get; set; }
        public DbSet<category> Categories { get; set; }
    }
}
