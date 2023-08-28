using api.estudo.Data;
using api.estudo.Extensions;
using api.estudo.Entities;
using api.estudo.Helpers;
using api.estudo.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Web;


namespace api.estudo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;

        public PokemonsController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetAllPokemon([FromQuery] PaginationParams paginationParams)
        {
            var pokemons = await _pokemonRepository.GetAllPokemonAsync(paginationParams);

            Response.Headers.Add("Pagination", "151");
            return Ok(pokemons);
        }

        [HttpGet("{pokemonId}")]
        public async Task<ActionResult<Pokemon>> GetPokemon(int pokemonId)
        {
            var pokemon = await _pokemonRepository.GetPokemonByIdAsync(pokemonId);

            return Ok(pokemon);
        }

        [HttpGet("filterByName")]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetPokemonByNameFilter([FromQuery] string nameFilter,
                                                                                     [FromQuery] PaginationParams paginationParams)
        {
            (var pokemons, var totalItems) = await _pokemonRepository.GetPokemonsByFilterName(nameFilter, paginationParams);

            //Response.Headers.Add("Pagination", totalItems.ToString());
            Response.AddPaginationHeader(new PaginationHeader(totalItems));
            return Ok(pokemons);
        }

        [HttpGet("filter")]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetPokemonByFilter([FromQuery] string nameFilter,
                                                                                [FromQuery] string typeFilter,
                                                                                [FromQuery] PaginationParams paginationParams)
        {
            (var pokemons, var totalItems) = await _pokemonRepository.GetPokemonsByFilters(nameFilter, typeFilter, paginationParams);

            Response.Headers.Add("Pagination", totalItems.ToString());
            return Ok(pokemons);
        }
    }
}
