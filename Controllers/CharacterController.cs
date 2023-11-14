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
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get()
        {
            return Ok(_CharacterService.GetAllCharacters());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> GetSingle(int id)
        {
            return Ok(await_CharacterService.GetAllCharacters(id));
        }
        [HttpPost]
         public async Task<ActionResult<ServiceResponse<List<GetCharacterDtor>>>> AddCharacter(AddCharacterGto newCharacter)
        {
            return Ok(await_CharacterService.AddCharacters(newCharacter));
        }
        [HttpPut]
         public async Task<ActionResult<ServiceResponse<List<GetCharacterDtor>>>> UpdateCharacter(UpdateCharacterGto updateCharacter)
        {
            return Ok(await_CharacterService.UpdateCharacters(updateCharacter));
        }
    }
}