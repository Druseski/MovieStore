using MovieStore.Repositories.Interfaces;
using MovieStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
   public class WatchedListService : IWatchedListService
    {
        private readonly IWatchedListRepository _watchedListRepository;

        public WatchedListService(IWatchedListRepository watchedListRepository)
        {
            _watchedListRepository = watchedListRepository;
        }
    }
}
