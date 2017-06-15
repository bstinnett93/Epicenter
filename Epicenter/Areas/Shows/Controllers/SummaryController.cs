using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Epicenter.Areas.Shows.Models;

namespace Epicenter.Areas.Shows.Controllers
{
    public class SummaryController : Controller
    {
        public ActionResult Index()
        {
            var viewModel =
                new LibraryViewModel()
                {
                    Shows = new List<ShowViewModel>()
                    {
                        new ShowViewModel
                        {
                            Name = "Show1",
                            Rating = 4.5,
                            ImageURL = "...",
                            DateUpdated = DateTime.Now
                        },
                        new ShowViewModel
                        {
                            Name = "Show2",
                            Rating = 4.0,
                            ImageURL = "...",
                            DateUpdated = DateTime.Now
                        },
                        new ShowViewModel
                        {
                            Name = "Show3",
                            Rating = 3.5,
                            ImageURL = "...",
                            DateUpdated = DateTime.Now
                        }
                    },
                    Username = "Brooke"
                };

            return View(viewModel);
        }
    }
}