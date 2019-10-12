using System;
using System.Data.Entity;

namespace StoreManagement.DAL
{
    public class StoreManagementContext : DbContext
    {
        public StoreManagementContext() : base("StoreManagementDb")
        {
        }

        public virtual DbSet<Dress> Dresses { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
