﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Plans
{
    public class Plan
    {

        public string? Id { get; set; }
        public string? ProductName { get; set; }
        public string? ProductId { get; set; }
        public string? BillingPeriod { get; set; }
        public long? NumberRequests { get; set; }
        public double? Amount { get; set; }
        public bool Active { get; set; } = false;
        //public DateTime? CreatedAt { get; set; }
        public ICollection<Subscription>? Subscriptions { get; set; }

    }
}