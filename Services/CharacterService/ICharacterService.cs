﻿using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService;

public interface ICharacterService
{
    Task<List<Character>> GetAllCharacters();
    Task<Character> GetCharacterById(int id);
    Task<List<Character>> AddNewCharacter(Character character);


}