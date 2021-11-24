using KFC.Domain.Services;
using KFC.UI.Extensions;
using KFC.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KFC.UI.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductRepository _repository;

        public CartController(IProductRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Add(int id)
        {
            var product = _repository.GetById(id);
            Cart cart;
            if (!HttpContext.Session.TryGetCart(out cart))
                cart = new Cart();

            if(cart.Items.ContainsKey(id))
            {
                cart.Items[id]++;
            }
            else
            {
                cart.Items[id] = 1;
            }

            cart.Amount += product.ProductPrice;

            HttpContext.Session.Set(cart);

            return RedirectToAction("Index", "Home", new { id = id});
        }
    }
}
