using System.Collections.Generic;
using Solid_Principles.Models;

namespace Solid_Principles.Repositories
{
    public class FakeOrderRepository : IOrderRepository
    {
        public List<Order> Orders { get; } =
            new List<Order>();

        public void Save(Order order)
        {
            Orders.Add(order);
        }
    }
}