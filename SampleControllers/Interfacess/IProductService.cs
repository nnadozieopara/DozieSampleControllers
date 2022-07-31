using SampleControllers.Models;

namespace SampleControllers.Interfacess
{
    public interface IProductService
    {
        Dictionary<Product, int> ProductDataBase { get; set; }

        void CreateProduct(string name, string description, decimal price);
        void CreateProduct(string name, string description, decimal price, int quantity);
        void DeleteProduct(string name);
        void UpdateProductPrice(decimal newPrice, string name);
        void UpdateProductQuantity(string name, int quantity);
        Dictionary<Product, int> GetAllProducts();
        List<Product> GetAllProductList();
    }
}