using ORMExplained.Shared.DTO;
using ORMExplained.Shared.Models;

namespace ORMExplained.Server.Repositories.Interfaces
{
    public interface IProductRepo
    {
        public Task<ServiceModel> AddProduct(Product NewProduct);
        public Task<ServiceModel> GetProducts();
        public Task<ServiceModel> GetProduct(int ProductId);
    }
}
