using api.estudo.Entities;
using api.estudo.Helpers;

namespace api.estudo.Interface
{
    public interface IPokemonRepository
    {
        Task<bool> AnyAsync();
        Task<List<Pokemon>> GetAllPokemonAsync(PaginationParams paginationParams);
        Task<Pokemon> GetPokemonByIdAsync(int id);

        Task<(List<Pokemon>, int)> GetPokemonsByFilterName(string nameFilter, PaginationParams paginationParams);

        Task<(List<Pokemon>, int)> GetPokemonsByFilters(string nameFilter, string typeFilter, PaginationParams paginationParams);



        Task<(List<Pokemon>, int)> GetPokemonsAllInOne(string nameFilter, string typeFilter, PaginationParams paginationParams);

        Task<(List<Pokemon>, int)> GetPokemonsAllInOne(string typeFilter, PaginationParams paginationParams);

        Task<(List<Pokemon>, int)> GetPokemonsAllInOne(PaginationParams paginationParams);
    }
}
