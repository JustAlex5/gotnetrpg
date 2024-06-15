using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService;

public class CharacterService:ICharacterService


{
    private static List<Character> knights = new List<Character>
    {
        new Character(1, "Alex", 25, 25, 25, 25, RpgClass.Cleric),
        new Character(2, "Alex", 25, 25, 25, 25, RpgClass.Cleric),


    };
    
    public  async Task<List<Character>> GetAllCharacters()
    {
        return knights;
    }

    public async Task<Character> GetCharacterById(int id)
    {
        var character = knights.FirstOrDefault(c => c.Id == id);
        if (character != null) return character;
        throw new Exception("Character doesnt exists");
    }

    public async Task<List<Character>> AddNewCharacter(Character character)
    {
        knights.Add(character);
        return knights;
    }
}