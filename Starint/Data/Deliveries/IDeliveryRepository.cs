using System.Collections.Generic;

namespace Starint.Data.Deliveries
{
    public interface IDeliveryRepository
    {
        IEnumerable<Delivery> AllDeliveries { get; }

        void Create(Delivery delivery);
        void Delete(Delivery delivery);
        Delivery GetById(int id);
        void Update(Delivery delivery);
    }
}