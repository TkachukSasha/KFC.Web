using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KFC.Domain.Models
{
    public sealed class Order
    {
        public int Id { get; set; }

        private List<OrderItem> _items;

        public IReadOnlyCollection<OrderItem> Items
        {
            get { return _items; }
        }

        public int TotalCount => _items.Sum(item => item.Count);

        public decimal TotalPrice => _items.Sum(item => item.Price * item.Count);

        public Order(IEnumerable<OrderItem> items)
        {
            if(items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            _items = new List<OrderItem>(items);
        }

        public Order(int id, IEnumerable<OrderItem> items)
        {
            if (items == null)
                throw new ArgumentNullException(nameof(items));

            Id = id;
            _items = new List<OrderItem>(items);
        }

        public OrderItem GetItem(int productId)
        {
            int index = _items.FindIndex(item => item.ProductId == productId);
            if (index == -1)
                throw new Exception("Book not found.");
            return _items[index];
        }
        public void AddOrUpdateItem(Product product, int count)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            int index = _items.FindIndex(item => item.ProductId == product.Id);
            if (index == -1)
                _items.Add(new OrderItem(product.Id, count, product.ProductPrice));
            else
                _items[index].Count += count;
        }

        public void RemoveItem(int productId)
        {
            int index = _items.FindIndex(item => item.ProductId == productId);

            if (index == -1)
                throw new Exception("Order does not contain specified item.");

            _items.RemoveAt(index);
        }

        public void RemoveItem(Product product, int count)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            if (_items.Count == 0)
                throw new InvalidOperationException("Cart must contain items");

            var item = _items.SingleOrDefault(x => x.ProductId == product.Id);
            if (item == null)
                throw new InvalidOperationException("Cart does not contain item with ID: " + product.Id);

            _items.Remove(item);
            if (_items.Count - count == 0)
                return;

            _items.Add(new OrderItem(product.Id, item.Count - count, product.ProductPrice));
        }

        public void AddProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            AddOrUpdateItem(product, 1);
        }

        public void RemoveItems(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            if (_items.Count == 0)
                throw new InvalidOperationException("Cart must contain items");

            var item = _items.SingleOrDefault(x => x.ProductId == product.Id);
            if (item == null)
                throw new InvalidOperationException("Cart does not contain item with ID: " + product.Id);

            _items.RemoveAll(x => x.ProductId == product.Id);
        }
    }
}

