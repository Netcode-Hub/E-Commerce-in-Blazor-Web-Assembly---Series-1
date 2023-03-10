using ORMExplained.Shared.Models;
namespace ORMExplained.Shared.DTO
{
    public class ServiceModel
    {
        public List<Product>? ProductList { get; set; } = null;
        public Product? SingleProduct { get; set; } = null;
        public bool Success { get; set; } = true;
        public string? CssClass { get; set; } = "success";
        public string? Message { get; set; } = null;
    }
}
