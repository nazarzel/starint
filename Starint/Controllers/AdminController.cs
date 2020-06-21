using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starint.Controllers
{
    public class AdminController : Controller
    {
        public AdminController()
        {
           
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
