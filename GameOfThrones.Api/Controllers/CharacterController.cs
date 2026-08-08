using GameOfThrones.Api.Interfaces;
using GameOfThrones.Api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace GameOfThrones.Api.Controllers
{
    [Route("api/characters")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterRepository _characterRepo;
        public CharacterController(ICharacterRepository characterRepo)
        {
            _characterRepo = characterRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync() 
        {
            var characters = await _characterRepo.GetAllAsync();
            var charactersDto = characters.Select(c => c.ToCharacterListDto());
            return Ok(charactersDto);
        }

    }
}