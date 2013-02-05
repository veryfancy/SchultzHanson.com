using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchultzHanson.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() { return View(); }
        public ActionResult Directions() { return View(); }
        public ActionResult WeddingParty() { return View(); }
        public ActionResult Guestbook() { return View(); }

        [HttpPost]
        public ActionResult Guestbook(FormCollection formCollection)
        {


            return RedirectToAction("Guestbook");
        }
    }
}
