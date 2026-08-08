using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOfThrones.Api.Models
{
    public class Character
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

    // DB References

    public int? HouseId { get; set; }
    public House? House { get; set; }

    public int? FatherId { get; set; }
    public Character? Father { get; set; }

    public int? MotherId { get; set; }
    public Character? Mother { get; set; }

    // Self-references

    public int? KilledById { get; set; }
    public Character? KilledBy { get; set; }

    public int? SpouseId { get; set; }
    public Character? Spouse { get; set; }

    //public List<Character> Children { get; set; } = new();

    // Enums

    public Gender Gender { get; set; }
    public CharacterStatus Status { get; set; }
}
}