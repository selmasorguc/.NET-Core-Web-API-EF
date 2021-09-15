using System.Collections.Generic;
using System.Threading.Tasks;
using Dtos.CharacterDtos;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services.CharacterService;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharactersController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        public CharactersController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> GetAllCharacters()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetCharacterById(int id)
        {
            return Ok(await _characterService.GetCharacter(id));
        }

        [HttpPost("add-character")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter(
            AddCharacterDto character)
        {
            return Ok(await _characterService.AddNewCharacter(character));
        }

        [HttpPut("update-character")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> UpdateCharacter(
            UpdateCharacterDto character)
        {
            var response = await _characterService.UpdateCharacter(character);

            if (response.Data == null) return NotFound(response);

            return Ok(response);
        }

        [HttpDelete("delete-character/{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> DeleteCharacter(
            int id)
        {
            var response = await _characterService.DeleteCharacter(id);
            
            if (response.Data == null) return NotFound(response);

            return Ok(response);
        }
    }
}