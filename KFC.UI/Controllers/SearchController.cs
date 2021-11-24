using KFC.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KFC.UI.Controllers
{
    public class SearchController : Controller
    {
        private readonly IProductRepository _repository;

        public SearchController(IProductRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index(string query)
        {
            if(query == null)
            {
                throw new ArgumentNullException();
            }
            var products = _repository.GetByQuerry(query);

            return View(products);
        }
    }
}
