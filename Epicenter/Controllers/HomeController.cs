using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Epicenter.Models;

namespace Epicenter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ShowCollection()
        {
            var viewModel =
                new List<ShowViewModel>()
                {
                    new ShowViewModel
                    {
                        ShowId = 0,
                        ShowName = "Show1",
                        AverageRating = 4.5,
                        ImageURL = "...",
                        DateUpdated = DateTime.Now
                    },
                    new ShowViewModel
                    {
                        ShowId = 1,
                        ShowName = "Show2",
                        AverageRating = 4.0,
                        ImageURL = "...",
                        DateUpdated = DateTime.Now
                    },
                    new ShowViewModel
                    {
                        ShowId = 2,
                        ShowName = "Show3",
                        AverageRating = 3.5,
                        ImageURL = "...",
                        DateUpdated = DateTime.Now
                    }
                };

            return PartialView(viewModel);
        }

        [HttpGet]
        public ActionResult EpisodeList(int id)
        {
            var viewModel =
                new List<EpisodeViewModel>()
                {
                    new EpisodeViewModel()
                    {
                        EpisodeId = 0,
                        ShowId = 0,
                        EpisodeNumber = 1,
                        SeasonNumber = 1,
                        EpisodeRating = 3.0,
                        Description = "Decent episode"
                    },
                    new EpisodeViewModel()
                    {
                        EpisodeId = 1,
                        ShowId = 1,
                        EpisodeNumber = 2,
                        SeasonNumber = 3,
                        EpisodeRating = 4.5,
                        Description = "Awesome episode"
                    },
                    new EpisodeViewModel()
                    {
                        EpisodeId = 2,
                        ShowId = 2,
                        EpisodeNumber = 10,
                        SeasonNumber = 2,
                        EpisodeRating = 3.5,
                        Description = "Good episode"
                    }
                };

            return PartialView(viewModel.Where(x => x.ShowId == id));
        }

        [HttpGet]
        public ActionResult GetFavoriteEpisodes(int? id)
        {
            var viewModel =
                new List<EpisodeViewModel>()
                {
                    new EpisodeViewModel()
                    {
                        EpisodeId = 0,
                        ShowId = 0,
                        ShowName = "Show1",
                        EpisodeNumber = 1,
                        SeasonNumber = 1,
                        EpisodeRating = 3.0,
                        Description = "Decent episode"
                    },
                    new EpisodeViewModel()
                    {
                        EpisodeId = 1,
                        ShowId = 1,
                        ShowName = "Show2",
                        EpisodeNumber = 2,
                        SeasonNumber = 3,
                        EpisodeRating = 4.5,
                        Description = "Awesome episode"
                    },
                    new EpisodeViewModel()
                    {
                        EpisodeId = 2,
                        ShowId = 2,
                        ShowName = "Show3",
                        EpisodeNumber = 10,
                        SeasonNumber = 2,
                        EpisodeRating = 3.5,
                        Description = "Good episode"
                    }
                };

            if (id == null)
            {
                return PartialView("_FavoriteEpisodes", viewModel.Where(x => x.EpisodeRating > 4));
            }

            return PartialView("_FavoriteEpisodes", viewModel.Where(x => x.EpisodeRating > 4 && x.ShowId == id));
        }

        [HttpGet]
        public ActionResult GetFavoriteShows()
        {
            var viewModel =
                new List<ShowViewModel>()
                {
                    new ShowViewModel
                    {
                        ShowId = 0,
                        ShowName = "Show1",
                        AverageRating = 4.5,
                        ImageURL = "...",
                        DateUpdated = DateTime.Now
                    },
                    new ShowViewModel
                    {
                        ShowId = 1,
                        ShowName = "Show2",
                        AverageRating = 4.0,
                        ImageURL = "...",
                        DateUpdated = DateTime.Now
                    },
                    new ShowViewModel
                    {
                        ShowId = 2,
                        ShowName = "Show3",
                        AverageRating = 5,
                        ImageURL = "...",
                        DateUpdated = DateTime.Now
                    }
                };

            return PartialView("_SmallShowCollection", viewModel.Where(x => x.AverageRating >= 4));
        }

        [HttpGet]
        public ActionResult GetRecentShows()
        {
            var viewModel =
                new List<ShowViewModel>()
                {
                    new ShowViewModel
                    {
                        ShowId = 0,
                        ShowName = "Show1",
                        AverageRating = 4.5,
                        ImageURL = "...",
                        DateUpdated = DateTime.Now
                    },
                    new ShowViewModel
                    {
                        ShowId = 1,
                        ShowName = "Show2",
                        AverageRating = 4.0,
                        ImageURL = "...",
                        DateUpdated = DateTime.Now
                    },
                    new ShowViewModel
                    {
                        ShowId = 2,
                        ShowName = "Show3",
                        AverageRating = 5,
                        ImageURL = "...",
                        DateUpdated = DateTime.Now
                    }
                };

            return PartialView("_SmallShowCollection", viewModel);
        }
    }
}