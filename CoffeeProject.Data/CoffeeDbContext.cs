using CoffeeProject.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoffeeProject.Data
{
    public class CoffeeDbContext : IdentityDbContext
    {
        public CoffeeDbContext() {}
        public CoffeeDbContext(DbContextOptions options) : base(options) {}
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddress> CustomersAddresses { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductInventory> ProductInventories { get; set; }
        public virtual DbSet<ProductInventorySnapshot> ProductInventorySnapshots { get; set; }
        public virtual DbSet<SalesOrder> SlSalesOrders { get; set; }
        public virtual DbSet<SalesOrderItem> SlSalesOrderItems { get; set; }
        
    }
}