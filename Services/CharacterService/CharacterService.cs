using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public interface CharacterService:ICharacterService
    {
        public List<Character> AddCharacter(Character newCharacter)
        {
            throw new NotImplementedException();
        }
        public List<Character> GetAllCharacter()
        {
            throw new NotImplementedException();
        }
        public Character GetCharacterById (int id)
        {
            throw new NotImplementedException();
        }

    }
}