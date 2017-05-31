using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IYWEB.Controllers
{
    public class KomikController : Controller
    {
        //
        // GET: /Komik/
        public ActionResult Video()
        {
            return View();
        }

        public ActionResult Resim()
        {
            return View();
        }
	}
}