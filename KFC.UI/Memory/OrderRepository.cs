using KFC.Domain.Models;
using KFC.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KFC.UI.Memory
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new List<Order>();

        public Order Create()
        {
            var id = _orders.Count + 1;
            var order = new Order(id, new OrderItem[0]);

            _orders.Add(order);

            return order;
        }

        public Order GetById(int id)
        {
            return _orders.Single(order => order.Id == id);
        }

        public void Update(Order order)
        {
            ;
        }
    }
}
