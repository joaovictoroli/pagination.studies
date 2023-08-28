namespace api.estudo.Helpers
{
    public class PaginationHeader
    {
        public PaginationHeader(int totalItems)
        {
            TotalItems = totalItems;
        }
        public int TotalItems { get; set; }
    }
}
