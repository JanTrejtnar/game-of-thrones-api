using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameOfThrones.Api.Models;

namespace GameOfThrones.Api.DTOs.Character
{
    public class CharacterDetailDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string? Nickname { get; set; }

        public DateOnly? BirthDate { get; set; }
        public DateOnly? DeathDate { get; set; }
        public string? DeathCause { get; set; }

        public string CurrentAllegiance { get; set; } = String.Empty;

        public string ActorName { get; set; } = String.Empty;
        public string FirstEpisodeAppearance { get; set; } = String.Empty;
        public string LastEpisodeAppearance { get; set; } = String.Empty;

        public string? ImagePath { get; set; }

        // DB References

        public int? HouseId { get; set; }

        public int? FatherId { get; set; }

        public int? MotherId { get; set; }

        // Self-references

        public int? KilledById { get; set; }

        public int? SpouseId { get; set; }

        //public List<Character> Children { get; set; } = new();

        // Enums

        public Gender Gender { get; set; }
        public CharacterStatus Status { get; set; }     
    }
}