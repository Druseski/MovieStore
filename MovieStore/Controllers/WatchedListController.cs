using Microsoft.AspNetCore.Mvc;
using MovieStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Controllers
{
    public class WatchedListController : Controller
    {
        private readonly IWatchedListService _watchedListService;
        public WatchedListController(IWatchedListService watchedListService)
        {
            _watchedListService = watchedListService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
