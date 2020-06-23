using Starint.Data.Colors;
using Starint.Data.Offers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starint.Data.OfferColors
{
    public class OfferColor
    {
        public int Id { get; set; }
        public Color Color { get; set; }
        public Offer Offer { get; set; }

    }
}
