using SampleControllers.Interfacess;
using SampleControllers.Models;

namespace SampleControllers.Services
{
    public class ProductService : IProductService
    {
        public Dictionary<Product, int> ProductDataBase { get; set; } = new Dictionary<Product, int>();

        public void CreateProduct(string name, string description, decimal price)
        {
            var productCheck = ProductDataBase.FirstOrDefault(x => x.Key.Name == name);
            if (productCheck.Key == null)
            {
                Product product = new()
                {
                    Name = name,
                    Description = description,
                    Price = price
                };
                ProductDataBase.Add(product, 1);

            }
        }

        public void CreateProduct(string name, string description, decimal price, int quantity)
        {
            var productCheck = ProductDataBase.FirstOrDefault(x => x.Key.Name == name);
            if (productCheck.Key == null)
            {
                Product product = new()
                {
                    Name = name,
                    Description = description,
                    Price = price
                };
                ProductDataBase.Add(product, quantity);

            }
        }

        public void UpdateProductQuantity(string name, int quantity)
        {
            var product = ProductDataBase.FirstOrDefault(x => x.Key.Name == name);
            if (product.Key != null)
            {
                ProductDataBase[product.Key] += quantity;
            }
        }

        public void UpdateProductPrice(decimal newPrice, string name)
        {
            var product = ProductDataBase.FirstOrDefault(x => x.Key.Name == name);
            if (product.Key != null)
            {
                product.Key.Price = newPrice;
            }
        }

        public void DeleteProduct(string name)
        {
            var product = ProductDataBase.FirstOrDefault(x => x.Key.Name == name);
            if (product.Key != null)
            {
                ProductDataBase.Remove(product.Key);
            }
        }

        public Dictionary<Product, int> GetAllProducts()
        {
            return ProductDataBase;
        }

        public List<Product> GetAllProductList()
        {
            return ProductDataBase.Keys.ToList();
        }
    }
}
