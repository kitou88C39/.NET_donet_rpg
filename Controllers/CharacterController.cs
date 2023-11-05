using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        
        private readonly ICharacterService_characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
           
        };

        [HttpGet("GetAll")]
        public IActionResult<List<Character>> Get()
        {
            return Ok(_CharacterService.GetAllCharacters());
        }
        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(_CharacterService.GetAllCharacters(id));
        }
        [HttpPost]
         public ActionResult<Character> AddCharacter(Character newCharacter)
        {
            return Ok(_CharacterService.AddCharacters(newCharacter));
        }

    }
}