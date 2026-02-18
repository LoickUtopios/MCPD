using Exercice4.Models;

namespace Exercice4.Interfaces
{
    public interface IProductService
    {
        public Product? GetProductByID(int id);
        public List<Product> GetProducts();
        public List<Product> GetProductWithFilter(string? category, double? price); 
    }
}
