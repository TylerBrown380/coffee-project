﻿using System;
using System.Collections.Generic;

namespace CoffeeProject.Data.Models
{
    public class SalesOrder
    {
        public int Id { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Customer Customer { get; set; }
        public List<SalesOrderItem> SalesOrderItems { get; set; }
        public bool IsPaid { get; set; }
    }
}