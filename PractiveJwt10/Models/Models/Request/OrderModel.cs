﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Request
{
    public class OrderModel
    {
        public long ProductId { get; set; }

        public long CustomerId { get; set; }

        public int Amount { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; } = null!;
    }
}
