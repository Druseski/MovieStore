using MovieStore.Repositories.Interfaces;
using MovieStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
   public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
    }
}
