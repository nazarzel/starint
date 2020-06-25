using Microsoft.AspNetCore.Mvc.Rendering;
using Starint.Data.Categories;
using Starint.Data.Communications;
using Starint.Data.Deliveries;
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
        public Offer Offer { get; set; }
        public IEnumerable<SelectListItem> PitchesSelectList { get; set; }
        public IEnumerable<SelectListItem> TypesSelectList { get; set; }
        public IEnumerable<SelectListItem> CommunicationsSelectList { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<SelectListItem> DeliveriesSelectList { get; set; }
        public string CurrentCategory { get; set; }
    }
}
