using System.Collections.Generic;
namespace Asp.Net_Mvc_Proj.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
