using IMS.CoreBusiness;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductByNameAsync(string name);
        Task AddProductAsync(Product product);
    }
}
