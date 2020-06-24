using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starint.Data.Offers
{
    public class OfferRepository : IOfferRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public OfferRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Offer> AllOffers(string category)
        {
            return _appDbContext.Offers.Where(o => o.Category.Name == category).ToList();
        }
        public Offer GetById(int id)
        {
            return _appDbContext.Offers.Where(o => o.Id == id).FirstOrDefault();
        }
        public void Update(Offer offer)
        {
            _appDbContext.Offers.Update(offer);
            _appDbContext.SaveChanges();
        }
        public void Create(Offer offer)
        {
            _appDbContext.Offers.Add(offer);
            _appDbContext.SaveChanges();
        }
        public void Delete(Offer offer)
        {
            _appDbContext.Offers.Remove(offer);
            _appDbContext.SaveChanges();
        }
    }
}
