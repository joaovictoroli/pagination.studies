namespace api.estudo.Entities
{
    public class Pokemon
    {
        public int Id { get; set; }
        public int PokedexNumber { get; set; }
        public string Name { get; set;}
        public string Type { get; set; }
        public string Type2 { get; set; } = "";
        public string ImgUrl { get; set; }
    }
}
