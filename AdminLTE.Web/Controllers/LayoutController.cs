using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminLTE.Web.Controllers
{
    public class UIxController : Controller
    {
        public IActionResult Boxed()
        {
            return View();
        }
        public IActionResult Collapsed_Sidebar()
        {
            return View("collapsed-sidebar");
        }
        public IActionResult Fixed()
        {
            return View();
        }
        public IActionResult TopNav()
        {
            return View("top-nav");
        }
    }
}