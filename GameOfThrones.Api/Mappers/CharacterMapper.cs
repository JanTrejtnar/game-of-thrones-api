using GameOfThrones.Api.DTOs.Character;
using GameOfThrones.Api.Models;

namespace GameOfThrones.Api.Mappers
{
    public static class CharacterMapper
    {
        public static CharacterDetailDto ToCharacterDetailDto(this Character characterModel)
        {
            return new CharacterDetailDto 
            {
                Id = characterModel.Id,
                FirstName  = characterModel.FirstName,
                LastName  = characterModel.LastName,
                Nickname = characterModel.Nickname,
                BirthDate = characterModel.BirthDate,
                DeathDate = characterModel.DeathDate,
                DeathCause = characterModel.DeathCause,

                CurrentAllegiance  = characterModel.CurrentAllegiance,
                ActorName  = characterModel.ActorName,
                FirstEpisodeAppearance  = characterModel.FirstEpisodeAppearance,
                LastEpisodeAppearance  = characterModel.LastEpisodeAppearance,
                ImagePath = characterModel.ImagePath,

                // DB References

                HouseId = characterModel.HouseId,
                FatherId = characterModel.FatherId,
                MotherId = characterModel.MotherId,

                // Self-references

                KilledById = characterModel.KilledById,
                SpouseId = characterModel.SpouseId,

                //Character> Children

                // Enums
                Gender = characterModel.Gender,
                Status = characterModel.Status
            };
        }

        public static CharacterListDto ToCharacterListDto(this Character characterModel)
        {
            return new CharacterListDto
            {
                Id = characterModel.Id, 
                Name = $"{characterModel.FirstName} {characterModel.LastName}",
                House = characterModel?.House?.Name
            };
        }
    }
}