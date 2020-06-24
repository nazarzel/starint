using System.Collections.Generic;

namespace Starint.Data.Offers
{
    public interface IOfferRepository
    {
        IEnumerable<Offer> AllOffers(string category);
        void Create(Offer offer);
        void Delete(Offer offer);
        Offer GetById(int id);
        void Update(Offer offer);
    }
}