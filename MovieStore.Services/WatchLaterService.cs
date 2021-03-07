using MovieStore.Repositories.Interfaces;
using MovieStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
   public class WatchLaterService : IWatchLaterService
    {
        private readonly IWatchLaterRepository _watchLaterRepository;

        public WatchLaterService(IWatchLaterRepository watchLaterRepository)
        {
            _watchLaterRepository = watchLaterRepository;
        }
    }
}
