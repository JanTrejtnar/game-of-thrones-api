using GameOfThrones.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace GameOfThrones.Api.Data
{
    public class GameOfThronesDbContext : DbContext
    {
        public GameOfThronesDbContext(DbContextOptions<GameOfThronesDbContext> options) : base(options)
        {
            
        }

        public DbSet<Character> Characters => Set<Character>();
        public DbSet<House> Houses => Set<House>();
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API to set DB relationships through EF Core

            // Character self-referencing relationships
            modelBuilder.Entity<Character>()
                .HasOne(c => c.Father)
                .WithMany()
                .HasForeignKey(c => c.FatherId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Character>()
                .HasOne(c => c.Mother)
                .WithMany()
                .HasForeignKey(c => c.MotherId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Character>()
                .HasOne(c => c.Spouse)
                .WithMany()
                .HasForeignKey(c => c.SpouseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Character>()
                .HasOne(c => c.KilledBy)
                .WithMany()
                .HasForeignKey(c => c.KilledById)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}