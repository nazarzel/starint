using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starint.Data.Deliveries
{
    public class DeliveryRepository : IDeliveryRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public DeliveryRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Delivery> AllDeliveries
        {
            get
            {
                return _appDbContext.Deliveries.ToList();
            }
        }
        public Delivery GetById(int id)
        {
            return _appDbContext.Deliveries.Where(o => o.Id == id).FirstOrDefault();
        }
        public void Update(Delivery delivery)
        {
            _appDbContext.Deliveries.Update(delivery);
            _appDbContext.SaveChanges();
        }
        public void Create(Delivery delivery)
        {
            _appDbContext.Deliveries.Add(delivery);
            _appDbContext.SaveChanges();
        }
        public void Delete(Delivery delivery)
        {
            _appDbContext.Deliveries.Remove(delivery);
            _appDbContext.SaveChanges();
        }
    }
}
