using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminLTE.Web.Controllers
{
    public class MailboxController : Controller
    {
        public IActionResult Compose()
        {
            return View();
        }
        public IActionResult Mailbox()
        {
            return View();
        }
        public IActionResult ReadMail()
        {
            return View("read-mail");
        }
    }
}