using dotnet_rpg.Models;
using dotnet_rpg.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController:ControllerBase
{
    private readonly ICharacterService _characterService;
    public CharacterController(ICharacterService characterService)
    {
        _characterService = characterService;
    }

    [HttpGet("GetAall")]
    public async Task<ActionResult<List<Character>>> Get()
    {
        return Ok(await _characterService.GetAllCharacters());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Character>> GetCharacterById(int id)
    {
        return Ok(await _characterService.GetCharacterById(id));
    }

    [HttpPost("add-character")]
    public async Task<ActionResult<List<Character>>> AddNewCharacter(Character newCharacter)
    {
        
        return Ok(await _characterService.AddNewCharacter(newCharacter));
    }

}