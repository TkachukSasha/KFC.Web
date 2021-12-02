using KFC.Domain.Models;
using KFC.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KFC.UI.Memory
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products = new List<Product>
        {
            new Product(1,"Дабл шеф бургер острый","Уникальный острый бургер от шефа",1,SizeOfProduct.big,105m, "/img/DoubleShefBurgerSpicy.png"),
            new Product(2,"Дабл шеф бургер","Уникальний шеф бургер с двойной курицей",1,SizeOfProduct.big,105m,"/img/DoubleShefBurger.png"),
            new Product(3,"Шеф бургер де люкс острый","Острый бургер от шефа",1,SizeOfProduct.big,69m ,"/img/ShefBurgerDeLuxeSpicy.png")
        };

        public List<Product> GetAllByIds(IEnumerable<int> bookIds)
        {
            var foundProduct = from product in products
                               join productId in bookIds on product.Id equals productId
                               select product;
            return foundProduct.ToList();
        }

        public List<Product> GetAllProducts()
        {
            return products.ToList();
        }

        public Product GetById(int id)
        {
            return products.FirstOrDefault(productId => productId.Id == id);
        }

        public List<Product> GetByQuerry(string query)
        {
            return products.Where(product => product.ProductName.Contains(query))
                           .ToList();
        }
    }
}
