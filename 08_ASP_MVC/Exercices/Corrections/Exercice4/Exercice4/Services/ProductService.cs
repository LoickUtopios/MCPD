using Exercice4.Interfaces;
using Exercice4.Models;

namespace Exercice4.Services
{
    public class ProductService : IProductService
    {
        private List<Product> _products;

        public ProductService() 
        {
            _products = new List<Product>();
            _products.Add(new Product(1, "Clavier", "Informatique", 30.0));
            _products.Add(new Product(2, "Souris", "Informatique", 15.0));
            _products.Add(new Product(3, "Ecran", "Informatique", 300.0));
            _products.Add(new Product(4, "Mouchoir", "Hygiene", 4.0));
            _products.Add(new Product(5, "T-shirt", "Vetement", 30.0));
            _products.Add(new Product(6, "Bilboquet", "Jouet", 3000.0));
        }

        public Product? GetProductByID(int id)
        {
            return _products.SingleOrDefault(p => p.Id == id); 
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public List<Product> GetProductWithFilter(string? category, double? price)
        {
            List<Product> productsFiltered;

            if (category == null && price == null) 
                productsFiltered = _products; 
            else if (category == null)
                productsFiltered = _products.Where(p => p.Price == price).ToList();
            else if (price == null)
                productsFiltered = _products.Where(p => p.Category == category).ToList();
            else
                productsFiltered = _products.Where(p => p.Price == price && p.Category == category).ToList();

            productsFiltered.ForEach(Console.WriteLine);

            return productsFiltered;
        }

    }
}
