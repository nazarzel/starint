using Starint.Data.Offers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starint.ViewModels
{
    public class OfferListViewModel
    {
        public IEnumerable<Offer> Offers { get; set; }
        public string CurrentCategory { get; set; }
    }
}
