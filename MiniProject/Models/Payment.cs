using System;
using System.Collections.Generic;

namespace GixxWings.Models
{
    public partial class Payment
    {
        public int NoOfSeats { get; set; }
        public string? CardNumber { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? Cvv{ get; set; }
    }
}
