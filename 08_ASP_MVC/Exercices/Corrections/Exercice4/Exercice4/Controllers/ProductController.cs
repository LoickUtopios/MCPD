using Exercice4.Interfaces;
using Exercice4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercice4.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult AfficherProduits()
        {
            List<Product> products = _productService.GetProducts();
            return View(products);
        }

        public IActionResult AfficherProduitParId(int Id)
        {
            Product? product = _productService.GetProductByID(Id);
            return View(product);
        }

        public IActionResult AfficherProduitFiltre(string? category, double? price)
        {
            List<Product> products = _productService.GetProductWithFilter(category, price);
            return View(products);
        }

    }
}
