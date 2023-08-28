using api.estudo.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace api.estudo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Pokemon> Pokemons { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
 
            builder.Entity<Pokemon>().HasData(itemvalue());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public List<Pokemon> itemvalue()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\Data\PokemonSeedData.json");
            string sFilePath = Path.GetFullPath(sFile);

            //string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);

            var values = new List<Pokemon>();
            using (StreamReader r = new StreamReader(sFilePath))
            {
                string json = r.ReadToEnd();
                values = JsonConvert.DeserializeObject<List<Pokemon>>(json);
            }
            return values;
        }
    }
}
