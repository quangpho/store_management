using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Entity
{
    public class Dress
    {
        [Key]
        public int DressId { get; set; }
        public string Drescription { get; set; }
        public decimal Price { get; set; }
        public decimal OriginialCost { get; set; }
        public DateTime? BoughtDate { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
