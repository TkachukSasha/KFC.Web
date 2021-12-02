using KFC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KFC.Domain.Services
{
    public interface IOrderRepository
    {
        Order Create();

        Order GetById(int id);

        void Update(Order order);
    }
}
