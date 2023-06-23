using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using IMS.UseCases.Products.ProductInterfaces;


namespace IMS.UseCases.Products
{
    public class ViewProductsByNameUseCase : IViewProductsByNameUseCase
    {
        private readonly IProductRepository productRepository;

        public ViewProductsByNameUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task<IEnumerable<Product>> ExecuteAsync(string name = "")
        {
            return await productRepository.GetProductByNameAsync(name);
        }
    }
}
