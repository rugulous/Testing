using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestingAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly List<Pokemon> pokemonList =
        [
            new(1, "Bulbasaur", "Grass/Poison"),
            new(2, "Ivysaur", "Grass/Poison"),
            new(3, "Venusaur", "Grass/Poison"),
            new(4, "Charmander", "Fire"),
            new(5, "Charmeleon", "Fire"),
            new(6, "Charizard", "Fire/Flying"),
            new(7, "Squirtle", "Water"),
            new(8, "Wartortle", "Water"),
            new(9, "Blastoise", "Water"),
            new(10, "Caterpie", "Bug"),
            new(11, "Metapod", "Bug"),
            new(12, "Butterfree", "Bug/Flying"),
            new(13, "Weedle", "Bug/Poison"),
            new(14, "Kakuna", "Bug/Poison"),
            new(15, "Beedrill", "Bug/Poison"),
            new(16, "Pidgey", "Normal/Flying"),
            new(17, "Pidgeotto", "Normal/Flying"),
            new(18, "Pidgeot", "Normal/Flying"),
            new(19, "Rattata", "Normal"),
            new(20, "Raticate", "Normal"),
            new(21, "Spearow", "Normal/Flying"),
            new(1, "Missingno", null)
        ];

        [HttpGet("list")]
        public List<Pokemon> List(int? start, int? length)
        {
            var list = pokemonList;

            if(start != null)
            {
                list = list.Slice(start.Value, length ?? list.Count);
            }

            return list;
        }

        [HttpGet("{id}")]
        public Pokemon Get(int id)
        {
            return pokemonList.First(p => p.Id == id);
        }
    }

    public sealed record Pokemon(int Id, string Name, string? Type);
}
