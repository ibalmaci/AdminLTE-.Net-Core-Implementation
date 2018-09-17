using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminLTE.Web.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult Data()
        {
            return View();
        }
        public IActionResult Simple()
        {
            return View();
        }
    }
}