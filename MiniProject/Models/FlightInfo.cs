using System;
using System.Collections.Generic;

namespace GixxWings.Models
{
    public partial class FlightInfo
    {
        public int FlightId { get; set; }
        public string? Airlines { get; set; }
        public int? Depature { get; set; }
        public int? Arrival { get; set; }
        public DateTime? DepatureDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public int? PriceInr { get; set; }
    }
}
