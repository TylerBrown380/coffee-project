﻿using System;

namespace CoffeeProject.Data.Models
{
    public class ProductInventorySnapshot
    {
        public int Id { get; set; }
        public DateTime SnapshotTime { get; set; }
        public DateTime QuantityOnHand { get; set; }
        public Product Product { get; set; }
        
    }
}