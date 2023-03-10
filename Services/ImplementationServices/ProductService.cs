using ORMExplained.Client.Services.InterfaceServices;
using ORMExplained.Shared.DTO;
using ORMExplained.Shared.Models;
using System.Net.Http.Json;

namespace ORMExplained.Client.Services.ImplementationServices
{
    public class ProductService : IProductServices
    {
        private readonly HttpClient httpClient;
        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<ServiceModel?> AddProduct(Product NewProduct)
        {
            var product = await httpClient.PostAsJsonAsync("api/Product/Add-Product", NewProduct);
            return await product.Content.ReadFromJsonAsync<ServiceModel>();
        }

        public async Task<ServiceModel?> GetProduct(int ProductId)
        {
            var result = await httpClient.GetAsync($"api/Product/Get-Product/{ProductId}");
            return await result.Content.ReadFromJsonAsync<ServiceModel>();
        }

        public async Task<ServiceModel?> GetProducts()
        {
            var result = await httpClient.GetAsync("api/Product");
            return await result.Content.ReadFromJsonAsync<ServiceModel>();
        }
    }
}
