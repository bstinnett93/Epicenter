using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Epicenter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect(Url.Action("Index", "Summary", new { area = "Shows" }));
        }
    }
}