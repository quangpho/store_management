using System;
using System.Data.Entity;
using StoreManagement.Entity;

namespace StoreManagement.DAL
{
    public class StoreManagementContext : DbContext
    {
        public StoreManagementContext() : base("name=StoreManagementContext")
        {
        }

        public virtual DbSet<Dress> Dresses { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
