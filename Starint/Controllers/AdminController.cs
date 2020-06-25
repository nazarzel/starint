using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Starint.Data;
using Starint.Data.Categories;
using Starint.Data.Communications;
using Starint.Data.Deliveries;
using Starint.Data.Offers;
using Starint.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starint.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IOfferRepository offerRepository;
        private readonly IDeliveryRepository deliveryRepository;
        private readonly IHtmlHelper htmlHelper;
        private readonly ICommunicationRepository communicationRepository;

        public AdminController(
            ICategoryRepository categoryRepository,
            IOfferRepository offerRepository,
            IDeliveryRepository deliveryRepository,
            IHtmlHelper htmlHelper,
            ICommunicationRepository communicationRepository
            )
        {
            this.categoryRepository = categoryRepository;
            this.offerRepository = offerRepository;
            this.deliveryRepository = deliveryRepository;
            this.htmlHelper = htmlHelper;
            this.communicationRepository = communicationRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region Category
        public IActionResult Category()
        {
            return View(new CategoryListViewModel { 
                Categories = categoryRepository.AllCategories
            });
        }
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(CategoryListViewModel model)
        {

            if (ModelState.IsValid)
            {
                categoryRepository.Create(model.Category);
                return RedirectToAction("Category");
            }
            return RedirectToAction("Category");
        }

        [HttpPost]
        public IActionResult UpdateCategory(CategoryListViewModel model)
        {
            if (ModelState.IsValid)
            {
                categoryRepository.Update(model.Category);
                return RedirectToAction("Category");
            }
            ModelState.AddModelError("", "Error");
            return RedirectToAction("Category");
        }
        [HttpPost]
        public IActionResult DeleteCategory(CategoryListViewModel model)
        {
            if (ModelState.IsValid)
            {
                categoryRepository.Delete(model.Category);
                return RedirectToAction("Category");
            }
            ModelState.AddModelError("", "Error");
            return RedirectToAction("Category");
        }
        #endregion
        #region Offer
        public IActionResult Offer()
        {
            return View(new OfferListViewModel
            {
                Categories = categoryRepository.AllCategories,
                Offers = offerRepository.AllOffers.OrderBy(o=>o.Category),
               // Deliveries = deliveryRepository.AllDeliveries,
                TypesSelectList = htmlHelper.GetEnumSelectList<ScreenType>(),
                PitchesSelectList = htmlHelper.GetEnumSelectList<Pitch>(),
                CommunicationsSelectList = GetCommunicationsSelectList(),
                DeliveriesSelectList = GetDeliveriesSelectList()
            });
        }
        private IEnumerable<SelectListItem> GetCommunicationsSelectList()
        {
            var communications = communicationRepository.AllCommunications.Select(x =>
                                new SelectListItem
                                {
                                    Value = x.Id.ToString(),
                                    Text = x.Name
                                });

            return new SelectList(communications, "Value", "Text");
        }
        private IEnumerable<SelectListItem> GetDeliveriesSelectList()
        {
            var deliveries = deliveryRepository.AllDeliveries.Select(x =>
                                new SelectListItem
                                {
                                    Value = x.Id.ToString(),
                                    Text = x.Price + " " + x.Name
                                });

            return new SelectList(deliveries, "Value", "Text");
        }
        #endregion
    }
}
