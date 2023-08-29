using api.estudo.Entities;
using api.estudo.Helpers;
using api.estudo.Interface;
using Microsoft.EntityFrameworkCore;

namespace api.estudo.Data
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly AppDbContext _dbContext;

        public PokemonRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AnyAsync()
        {
            var list =  await _dbContext.Pokemons.ToListAsync();

            return list.Any(); 
        }

        public async Task<List<Pokemon>> GetAllPokemonAsync(PaginationParams paginationParams)
        {
            var query =  _dbContext.Pokemons.AsQueryable();

            var list = await query.AsNoTracking()
                       .Skip((paginationParams.PageNumber - 1) * paginationParams.ItemsInPage)
                       .Take(paginationParams.ItemsInPage).ToListAsync();

            return list;
        }

        public async Task<Pokemon> GetPokemonByIdAsync(int id)
        {
            return await _dbContext.Pokemons.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<(List<Pokemon>, int)> GetPokemonsByFilterName(string nameFilter, PaginationParams paginationParams)
        {
            var query = _dbContext.Pokemons.Where(x => x.Name.Contains(nameFilter)).AsQueryable();


            var totalItems = query.Count();
            var list = await query.AsNoTracking()
                       .Skip((paginationParams.PageNumber - 1) * paginationParams.ItemsInPage)
                       .Take(paginationParams.ItemsInPage).ToListAsync();
            return (list, totalItems);
        }

        public async Task<(List<Pokemon>, int)> GetPokemonsByFilters(string nameFilter, string typeFilter, PaginationParams paginationParams)
        {
            var query = _dbContext.Pokemons.Where(x => x.Name.Contains(nameFilter))
                            .Where(x => x.Type == typeFilter || x.Type2 == typeFilter)
                            .AsQueryable();       
                        
            var totalItems = await query.CountAsync();
            var list = await query.AsNoTracking()
                       .Skip((paginationParams.PageNumber - 1) * paginationParams.ItemsInPage)
                       .Take(paginationParams.ItemsInPage).ToListAsync();

            return (list, totalItems);
        }

        public async Task<(List<Pokemon>, int)> GetPokemonsAllInOne(string nameFilter, string typeFilter, PaginationParams paginationParams)
        {
            var query = _dbContext.Pokemons.Where(x => x.Name.Contains(nameFilter))
                            .Where(x => x.Type == typeFilter || x.Type2 == typeFilter)
                            .AsQueryable();

            var totalItems = await query.CountAsync();
            var list = await query.AsNoTracking()
                       .Skip((paginationParams.PageNumber - 1) * paginationParams.ItemsInPage)
                       .Take(paginationParams.ItemsInPage).ToListAsync();

            return (list, totalItems);
        }

        public async Task<(List<Pokemon>, int)> GetPokemonsAllInOne(string typeFilter, PaginationParams paginationParams)
        {
            var query = _dbContext.Pokemons
                            .Where(x => x.Type == typeFilter || x.Type2 == typeFilter)
                            .AsQueryable();

            var totalItems = await query.CountAsync();
            var list = await query.AsNoTracking()
                       .Skip((paginationParams.PageNumber - 1) * paginationParams.ItemsInPage)
                       .Take(paginationParams.ItemsInPage).ToListAsync();

            return (list, totalItems);
        }

        public async Task<(List<Pokemon>, int)> GetPokemonsAllInOne(PaginationParams paginationParams)
        {
            var query = _dbContext.Pokemons.AsQueryable();

            var list = await query.AsNoTracking()
                       .Skip((paginationParams.PageNumber - 1) * paginationParams.ItemsInPage)
                       .Take(paginationParams.ItemsInPage).ToListAsync();

            return (list, 151);
        }
    }
}
