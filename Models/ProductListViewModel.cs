namespace Asp.Net_Mvc_Proj.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
    }
}
