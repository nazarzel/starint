using Microsoft.AspNetCore.Mvc;
using Starint.Data.Categories;
using Starint.Data.Offers;
using Starint.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starint.Controllers
{
    public class OfferController : Controller
    {
        private readonly IOfferRepository offerRepository;
        private readonly ICategoryRepository categoryRepository;

        public OfferController(
            IOfferRepository offerRepository,
            ICategoryRepository categoryRepository
            )
        {
            this.offerRepository = offerRepository;
            this.categoryRepository = categoryRepository;
        }
        public ViewResult List(string category)
        {
            IEnumerable<Offer> offers;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                offers = offerRepository.AllOffers.OrderBy(p => p.Id);
                currentCategory = "All offers";
            }
            else
            {
                offers = offerRepository.AllOffers.Where(p => p.Category.Name == category)
                    .OrderBy(p => p.Id);
                currentCategory = categoryRepository.AllCategories.FirstOrDefault(c => c.Name == category)?.Name;
            }

            return View(new OfferListViewModel
            {
                Offers = offers,
                CurrentCategory = currentCategory
            });
        }
        public IActionResult Details(int id)
        {
            var offer = offerRepository.GetById(id);
            if (offer == null)
                return NotFound();

            return View(offer);
        }
    }
}
