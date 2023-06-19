using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Plugins.InMemory
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;
        public ProductRepository()
        {
            _products = new List<Product>()
                {
                    new Product { ProductId = 1, ProductName = "Bike Seat", Quantity = 10, Price = 2 },
                    new Product { ProductId = 2, ProductName = "Bike Body", Quantity = 10, Price = 15 },
                    new Product { ProductId = 3, ProductName = "Bike Wheels", Quantity = 20, Price = 8 },
                    new Product { ProductId = 4, ProductName = "Bike Pedals", Quantity = 20, Price = 1 },
                };
            
        }


        public Task<IEnumerable<Product>> GetProductByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

   }
   
}
