using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starint.Data.Orders
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public OrderRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Order> AllOrders
        {
            get
            {
                return _appDbContext.Orders.OrderBy(o => o.OrderPlaced).ToList();
            }
        }
        public Order GetById(int id)
        {
            return _appDbContext.Orders.Where(o => o.Id == id).FirstOrDefault();
        }
        public void Update(Order order)
        {
            _appDbContext.Orders.Update(order);
            _appDbContext.SaveChanges();
        }
        public void Create(Order order)
        {
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
        }
        public void Delete(Order order)
        {
            _appDbContext.Orders.Remove(order);
            _appDbContext.SaveChanges();
        }
    }
}
