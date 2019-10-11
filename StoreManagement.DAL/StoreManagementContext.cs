using Microsoft.EntityFrameworkCore;
using StoreManagement.Entity;
using System;

namespace StoreManagement.DAL
{
    public class StoreManagementContext : DbContext
    {
        public StoreManagementContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Dress> Dresses { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
