using ORMExplained.Shared.DTO;
using ORMExplained.Shared.Models;
namespace ORMExplained.Client.Services.InterfaceServices
{
    public interface IProductServices
    {
        public Task<ServiceModel?> AddProduct(Product NewProduct);
        public Task<ServiceModel?> GetProducts();
        public Task<ServiceModel?> GetProduct(int ProductId);
    }
}
