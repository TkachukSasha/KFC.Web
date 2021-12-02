using KFC.Domain.Models;
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
    public class OrderController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IOrderRepository _orderRepository;

        public OrderController(IProductRepository productRepository, IOrderRepository orderRepository)
        {
            _productRepository = productRepository;
            _orderRepository = orderRepository;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.TryGetCart(out Cart cart))
            {
                var order = _orderRepository.GetById(cart.OrderId);
                OrderModel model = Map(order);

                return View(model);
            }

            return View("Empty");

        }

        private OrderModel Map(Order order)
        {
            var productIds = order.Items.Select(item => item.ProductId);
            var products = _productRepository.GetAllByIds(productIds);
            var itemModels = from item in order.Items
                             join product in products on item.ProductId equals product.Id
                             select new OrderItemModel
                             {
                                 ProductId = product.Id,
                                 ProductName = product.ProductName,
                                 ProductDescription = product.ProductDescription,
                                 Price = item.Price,
                                 Count = item.Count,
                             };

            return new OrderModel
            {
                Id = order.Id,
                Items = itemModels.ToArray(),
                TotalCount = order.TotalCount,
                TotalPrice = order.TotalPrice,
            };
        }

        public IActionResult AddProduct(int productId, int count = 1)
        {
            (Order order, Cart cart) = GetOrCreateOrderAndCart();
            var product = _productRepository.GetById(productId);
            order.AddOrUpdateItem(product, count);
            SaveOrderAndCart(order, cart);
            return RedirectToAction("Index", "Home", new { id = productId });
        }

        public IActionResult RemoveItem(int productId)
        {
            (Order order, Cart cart) = GetOrCreateOrderAndCart();

            order.RemoveItem(productId);

            SaveOrderAndCart(order, cart);


            return RedirectToAction("Index", "Order");
        }

        [HttpPost]
        public IActionResult UpdateItem(int bookId, int count)
        {
            (Order order, Cart cart) = GetOrCreateOrderAndCart();
            order.GetItem(bookId).Count = count;

            SaveOrderAndCart(order, cart);

            return RedirectToAction("Index", "Order");
        }

        private (Order order, Cart cart) GetOrCreateOrderAndCart()
        {
            Order order;
            if (HttpContext.Session.TryGetCart(out Cart cart))
            {
                order = _orderRepository.GetById(cart.OrderId);
            }
            else
            {
                order = _orderRepository.Create();
                cart = new Cart(order.Id);
            }
            return (order, cart);
        }
        private void SaveOrderAndCart(Order order, Cart cart)
        {
            _orderRepository.Update(order);
            cart.TotalCount = order.TotalCount;
            cart.TotalPrice = order.TotalPrice;
            HttpContext.Session.Set(cart);
        }
    }
}
