using KFC.Domain.Services;
using KFC.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KFC.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _repository;

        public HomeController(IProductRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var products = _repository.GetAllProducts();

            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
