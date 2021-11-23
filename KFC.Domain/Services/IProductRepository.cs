using KFC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KFC.Domain.Services
{
    public interface IProductRepository
    {
        List<Product> GetByQuerry(string query);
    }
}
