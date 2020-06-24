using System.Collections.Generic;

namespace Starint.Data.Offers
{
    public interface IOfferRepository
    {
        IEnumerable<Offer> AllOffers { get; }
        void Create(Offer offer);
        void Delete(Offer offer);
        Offer GetById(int id);
        void Update(Offer offer);
    }
}