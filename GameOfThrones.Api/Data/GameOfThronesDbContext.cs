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

            // Seed Houses

            modelBuilder.Entity<House>().HasData(
                new House
                {
                    Id = 1, 
                    Name = "House Stark",
                    SigilName = "Direwolf",
                    Motto = "Winter is coming",
                    Region = "The North",
                    ImagePath = "/images/houses/stark.png"
                }, 
                new House
                {
                    Id = 2,
                    Name = "House Lannister",
                    SigilName = "Lion",
                    Motto = "Hear me roar",
                    Region = "The Westerlands",
                    ImagePath = "/images/houses/lannister.png"
                }
            );

            // Seed Characters
            
            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    Id = 1,
                    FirstName = "Jon",
                    LastName = "Snow",
                    Nickname = "King in the North",
                    CurrentAllegiance = "House Stark",
                    ActorName = "Kit Harington",
                    FirstEpisodeAppearance = "Winter Is Coming",
                    LastEpisodeAppearance = "The Iron Throne",
                    HouseId = 1,
                    Gender = Gender.Male,
                    Status = CharacterStatus.Alive,
                    ImagePath = "/images/characters/jon-snow.png"
                },
                new Character
                {
                    Id = 2,
                    FirstName = "Tyrion",
                    LastName = "Lannister",
                    Nickname = "The Imp",
                    CurrentAllegiance = "House Lannister",
                    ActorName = "Peter Dinklage",
                    FirstEpisodeAppearance = "Winter Is Coming",
                    LastEpisodeAppearance = "The Iron Throne",
                    HouseId = 2,
                    Gender = Gender.Male,
                    Status = CharacterStatus.Alive,
                    ImagePath = "/images/characters/tyrion-lannister.png"
                }
            );
        }
    }
}