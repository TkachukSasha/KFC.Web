using KFC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KFC.Domain.Services
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        List<Product> GetByQuerry(string query);
        Product GetById(int id);
    }
}
