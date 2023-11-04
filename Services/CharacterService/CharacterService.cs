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
            characters.Add(newCharacter);
            return characters;
        }
        public List<Character> GetAllCharacter()
        {
            return characters;
        }
        public Character GetCharacterById (int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }

    }
}