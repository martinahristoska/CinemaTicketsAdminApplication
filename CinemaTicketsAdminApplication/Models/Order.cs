﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTicketsAdminApplication.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public CinemaTicketsApplicationUser User { get; set; }
        public  ICollection<TicketInOrder> TicketInOrders { get; set; }
    }
}
