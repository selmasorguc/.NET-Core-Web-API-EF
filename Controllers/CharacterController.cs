using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services.CharacterService;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_characterService.GetAllCharacters());
        }

        [HttpPost("addcharacter")]
        public IActionResult AddCharacter(Character character)
        {
            return Ok(_characterService.AddNewCharacter(character));
        }
    }
}