using System.Collections.Generic;
using System.Linq;
using Models;

namespace Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static Character knight = new Character();
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character{ Name="Sam"}
        };
        public List<Character> AddNewCharacter(Character character)
        {
            characters.Add(character);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacter(int id)
        {
            return characters.FirstOrDefault(m => m.Id == id);
        }
    }
}