using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StoreManagement.Entity
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderCreated { get; set; }
        [Required]
        public string RenterName { get; set; }
        [Required]
        public string RenterMobile { get; set; }
        [Required]
        public string RenterAddress { get; set; }
        [Required]
        public string Source { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? ExpectedReturnDate { get; set; }
        [Required]
        public string Status { get; set; }
        public string Note { get; set; }

        public int DressId { get; set; }
        public Dress Dress { get; set; }
    }
}
