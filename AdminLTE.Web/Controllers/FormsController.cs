using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminLTE.Web.Controllers
{
    public class FormsController : Controller
    {
        public IActionResult Advanced()
        {
            return View();
        }
        public IActionResult Editors()
        {
            return View();
        }
        public IActionResult General()
        {
            return View();
        }
    }
}