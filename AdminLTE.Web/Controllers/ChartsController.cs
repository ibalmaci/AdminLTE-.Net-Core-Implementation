using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminLTE.Web.Controllers
{
    public class ChartsController : Controller
    {
        public IActionResult ChartJS()
        {
            return View();
        }
        public IActionResult Flot()
        {
            return View();
        }
        public IActionResult Inline()
        {
            return View();
        }
        public IActionResult Morris()
        {
            return View();
        }
    }
}