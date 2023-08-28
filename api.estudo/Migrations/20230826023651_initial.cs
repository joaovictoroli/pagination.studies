using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.estudo.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokedexNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "ImgUrl", "Name", "PokedexNumber", "Type", "Type2" },
                values: new object[,]
                {
                    { 1, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png", "bulbasaur", 1, "grass", "poison" },
                    { 2, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/2.png", "ivysaur", 2, "grass", "poison" },
                    { 3, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/3.png", "venusaur", 3, "grass", "poison" },
                    { 4, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/4.png", "charmander", 4, "fire", "" },
                    { 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/5.png", "charmeleon", 5, "fire", "" },
                    { 6, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/6.png", "charizard", 6, "fire", "flying" },
                    { 7, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/7.png", "squirtle", 7, "water", "" },
                    { 8, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/8.png", "wartortle", 8, "water", "" },
                    { 9, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/9.png", "blastoise", 9, "water", "" },
                    { 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/10.png", "caterpie", 10, "bug", "" },
                    { 11, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/11.png", "metapod", 11, "bug", "" },
                    { 12, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/12.png", "butterfree", 12, "bug", "flying" },
                    { 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/13.png", "weedle", 13, "bug", "poison" },
                    { 14, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/14.png", "kakuna", 14, "bug", "poison" },
                    { 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/15.png", "beedrill", 15, "bug", "poison" },
                    { 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/16.png", "pidgey", 16, "normal", "flying" },
                    { 17, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/17.png", "pidgeotto", 17, "normal", "flying" },
                    { 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/18.png", "pidgeot", 18, "normal", "flying" },
                    { 19, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/19.png", "rattata", 19, "normal", "" },
                    { 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/20.png", "raticate", 20, "normal", "" },
                    { 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/21.png", "spearow", 21, "normal", "flying" },
                    { 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/22.png", "fearow", 22, "normal", "flying" },
                    { 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/23.png", "ekans", 23, "poison", "" },
                    { 24, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/24.png", "arbok", 24, "poison", "" },
                    { 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/25.png", "pikachu", 25, "electric", "" },
                    { 26, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/26.png", "raichu", 26, "electric", "" },
                    { 27, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/27.png", "sandshrew", 27, "ground", "" },
                    { 28, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/28.png", "sandslash", 28, "ground", "" },
                    { 29, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/29.png", "nidoran-f", 29, "poison", "" },
                    { 30, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/30.png", "nidorina", 30, "poison", "" },
                    { 31, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/31.png", "nidoqueen", 31, "poison", "ground" },
                    { 32, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/32.png", "nidoran-m", 32, "poison", "" },
                    { 33, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/33.png", "nidorino", 33, "poison", "" },
                    { 34, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/34.png", "nidoking", 34, "poison", "ground" },
                    { 35, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/35.png", "clefairy", 35, "fairy", "" },
                    { 36, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/36.png", "clefable", 36, "fairy", "" },
                    { 37, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/37.png", "vulpix", 37, "fire", "" },
                    { 38, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/38.png", "ninetales", 38, "fire", "" },
                    { 39, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/39.png", "jigglypuff", 39, "normal", "fairy" },
                    { 40, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/40.png", "wigglytuff", 40, "normal", "fairy" },
                    { 41, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/41.png", "zubat", 41, "poison", "flying" },
                    { 42, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/42.png", "golbat", 42, "poison", "flying" },
                    { 43, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/43.png", "oddish", 43, "grass", "poison" },
                    { 44, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/44.png", "gloom", 44, "grass", "poison" },
                    { 45, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/45.png", "vileplume", 45, "grass", "poison" },
                    { 46, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/46.png", "paras", 46, "bug", "grass" },
                    { 47, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/47.png", "parasect", 47, "bug", "grass" },
                    { 48, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/48.png", "venonat", 48, "bug", "poison" },
                    { 49, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/49.png", "venomoth", 49, "bug", "poison" },
                    { 50, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/50.png", "diglett", 50, "ground", "" },
                    { 51, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/51.png", "dugtrio", 51, "ground", "" },
                    { 52, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/52.png", "meowth", 52, "normal", "" },
                    { 53, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/53.png", "persian", 53, "normal", "" },
                    { 54, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/54.png", "psyduck", 54, "water", "" },
                    { 55, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/55.png", "golduck", 55, "water", "" },
                    { 56, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/56.png", "mankey", 56, "fighting", "" },
                    { 57, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/57.png", "primeape", 57, "fighting", "" },
                    { 58, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/58.png", "growlithe", 58, "fire", "" },
                    { 59, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/59.png", "arcanine", 59, "fire", "" },
                    { 60, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/60.png", "poliwag", 60, "water", "" },
                    { 61, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/61.png", "poliwhirl", 61, "water", "" },
                    { 62, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/62.png", "poliwrath", 62, "water", "fighting" },
                    { 63, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/63.png", "abra", 63, "psychic", "" },
                    { 64, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/64.png", "kadabra", 64, "psychic", "" },
                    { 65, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/65.png", "alakazam", 65, "psychic", "" },
                    { 66, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/66.png", "machop", 66, "fighting", "" },
                    { 67, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/67.png", "machoke", 67, "fighting", "" },
                    { 68, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/68.png", "machamp", 68, "fighting", "" },
                    { 69, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/69.png", "bellsprout", 69, "grass", "poison" },
                    { 70, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/70.png", "weepinbell", 70, "grass", "poison" },
                    { 71, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/71.png", "victreebel", 71, "grass", "poison" },
                    { 72, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/72.png", "tentacool", 72, "water", "poison" },
                    { 73, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/73.png", "tentacruel", 73, "water", "poison" },
                    { 74, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/74.png", "geodude", 74, "rock", "ground" },
                    { 75, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/75.png", "graveler", 75, "rock", "ground" },
                    { 76, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/76.png", "golem", 76, "rock", "ground" },
                    { 77, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/77.png", "ponyta", 77, "fire", "" },
                    { 78, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/78.png", "rapidash", 78, "fire", "" },
                    { 79, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/79.png", "slowpoke", 79, "water", "psychic" },
                    { 80, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/80.png", "slowbro", 80, "water", "psychic" },
                    { 81, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/81.png", "magnemite", 81, "electric", "steel" },
                    { 82, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/82.png", "magneton", 82, "electric", "steel" },
                    { 83, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/83.png", "farfetchd", 83, "normal", "flying" },
                    { 84, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/84.png", "doduo", 84, "normal", "flying" },
                    { 85, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/85.png", "dodrio", 85, "normal", "flying" },
                    { 86, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/86.png", "seel", 86, "water", "" },
                    { 87, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/87.png", "dewgong", 87, "water", "ice" },
                    { 88, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/88.png", "grimer", 88, "poison", "" },
                    { 89, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/89.png", "muk", 89, "poison", "" },
                    { 90, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/90.png", "shellder", 90, "water", "" },
                    { 91, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/91.png", "cloyster", 91, "water", "ice" },
                    { 92, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/92.png", "gastly", 92, "ghost", "poison" },
                    { 93, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/93.png", "haunter", 93, "ghost", "poison" },
                    { 94, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/94.png", "gengar", 94, "ghost", "poison" },
                    { 95, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/95.png", "onix", 95, "rock", "ground" },
                    { 96, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/96.png", "drowzee", 96, "psychic", "" },
                    { 97, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/97.png", "hypno", 97, "psychic", "" },
                    { 98, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/98.png", "krabby", 98, "water", "" },
                    { 99, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/99.png", "kingler", 99, "water", "" },
                    { 100, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/100.png", "voltorb", 100, "electric", "" },
                    { 101, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/101.png", "electrode", 101, "electric", "" },
                    { 102, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/102.png", "exeggcute", 102, "grass", "psychic" },
                    { 103, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/103.png", "exeggutor", 103, "grass", "psychic" },
                    { 104, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/104.png", "cubone", 104, "ground", "" },
                    { 105, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/105.png", "marowak", 105, "ground", "" },
                    { 106, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/106.png", "hitmonlee", 106, "fighting", "" },
                    { 107, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/107.png", "hitmonchan", 107, "fighting", "" },
                    { 108, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/108.png", "lickitung", 108, "normal", "" },
                    { 109, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/109.png", "koffing", 109, "poison", "" },
                    { 110, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/110.png", "weezing", 110, "poison", "" },
                    { 111, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/111.png", "rhyhorn", 111, "ground", "rock" },
                    { 112, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/112.png", "rhydon", 112, "ground", "rock" },
                    { 113, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/113.png", "chansey", 113, "normal", "" },
                    { 114, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/114.png", "tangela", 114, "grass", "" },
                    { 115, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/115.png", "kangaskhan", 115, "normal", "" },
                    { 116, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/116.png", "horsea", 116, "water", "" },
                    { 117, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/117.png", "seadra", 117, "water", "" },
                    { 118, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/118.png", "goldeen", 118, "water", "" },
                    { 119, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/119.png", "seaking", 119, "water", "" },
                    { 120, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/120.png", "staryu", 120, "water", "" },
                    { 121, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/121.png", "starmie", 121, "water", "psychic" },
                    { 122, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/122.png", "mr-mime", 122, "psychic", "fairy" },
                    { 123, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/123.png", "scyther", 123, "bug", "flying" },
                    { 124, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/124.png", "jynx", 124, "ice", "psychic" },
                    { 125, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/125.png", "electabuzz", 125, "electric", "" },
                    { 126, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/126.png", "magmar", 126, "fire", "" },
                    { 127, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/127.png", "pinsir", 127, "bug", "" },
                    { 128, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/128.png", "tauros", 128, "normal", "" },
                    { 129, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/129.png", "magikarp", 129, "water", "" },
                    { 130, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/130.png", "gyarados", 130, "water", "flying" },
                    { 131, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/131.png", "lapras", 131, "water", "ice" },
                    { 132, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/132.png", "ditto", 132, "normal", "" },
                    { 133, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/133.png", "eevee", 133, "normal", "" },
                    { 134, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/134.png", "vaporeon", 134, "water", "" },
                    { 135, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/135.png", "jolteon", 135, "electric", "" },
                    { 136, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/136.png", "flareon", 136, "fire", "" },
                    { 137, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/137.png", "porygon", 137, "normal", "" },
                    { 138, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/138.png", "omanyte", 138, "rock", "water" },
                    { 139, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/139.png", "omastar", 139, "rock", "water" },
                    { 140, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/140.png", "kabuto", 140, "rock", "water" },
                    { 141, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/141.png", "kabutops", 141, "rock", "water" },
                    { 142, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/142.png", "aerodactyl", 142, "rock", "flying" },
                    { 143, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/143.png", "snorlax", 143, "normal", "" },
                    { 144, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/144.png", "articuno", 144, "ice", "flying" },
                    { 145, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/145.png", "zapdos", 145, "electric", "flying" },
                    { 146, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/146.png", "moltres", 146, "fire", "flying" },
                    { 147, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/147.png", "dratini", 147, "dragon", "" },
                    { 148, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/148.png", "dragonair", 148, "dragon", "" },
                    { 149, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/149.png", "dragonite", 149, "dragon", "flying" },
                    { 150, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/150.png", "mewtwo", 150, "psychic", "" },
                    { 151, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/151.png", "mew", 151, "psychic", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
