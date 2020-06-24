using Microsoft.AspNetCore.Mvc;
using Starint.Data.Offers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starint.Controllers
{
    public class OfferController : Controller
    {
        public OfferController(
            
            )
        {

        }
        public ViewResult List(string category)
        {
            IEnumerable<Offer> offers;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                offers = _pieRepository.AllPies.OrderBy(p => p.PieId);
                currentCategory = "All pies";
            }
            else
            {
                pies = _pieRepository.AllPies.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.PieId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new PiesListViewModel
            {
                Pies = pies,
                CurrentCategory = currentCategory
            });
        }
    }
}
