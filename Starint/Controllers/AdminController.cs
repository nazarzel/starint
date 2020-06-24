using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starint.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        public AdminController()
        {
           
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
            return View();
        }
    }
}
