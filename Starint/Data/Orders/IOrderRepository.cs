using System.Collections.Generic;

namespace Starint.Data.Orders
{
    public interface IOrderRepository
    {
        IEnumerable<Order> AllOrders { get; }

        void Create(Order order);
        void Delete(Order order);
        Order GetById(int id);
        void Update(Order order);
    }
}