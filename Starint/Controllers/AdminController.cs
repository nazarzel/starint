using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Starint.Data.Categories;
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

        public AdminController(
            ICategoryRepository categoryRepository
            )
        {
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Products(string category)
        {
            return View();
        }
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
    }
}
