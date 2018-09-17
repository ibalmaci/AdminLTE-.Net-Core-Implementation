using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminLTE.Web.Controllers
{
    public class ExamplesController : Controller
    {
        public IActionResult Page404()
        {
            return View("404");
        }
        public IActionResult Page500()
        {
            return View("505");
        }
        public IActionResult Blank()
        {
            return View();
        }
        public IActionResult Invoice()
        {
            return View();
        }
        public IActionResult InvoicePrint()
        {
            return View("invoice-print");
        }
        public IActionResult LockScreen()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Pace()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}