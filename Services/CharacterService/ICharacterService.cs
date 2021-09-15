using System.Collections.Generic;
using Models;

namespace Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacter(int id);
        List<Character> AddNewCharacter(Character character);
    }
}