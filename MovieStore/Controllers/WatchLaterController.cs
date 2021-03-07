using Microsoft.AspNetCore.Mvc;
using MovieStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Controllers
{
    public class WatchLaterController : Controller
    {
        private readonly IWatchLaterService _watchLaterService;
        public WatchLaterController(IWatchLaterService watchLaterService)
        {
            _watchLaterService = watchLaterService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
