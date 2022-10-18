using System;
using System.Collections.Generic;

namespace GixxWings.Models
{
    public partial class BookingInfo
    {
        public int BookingId { get; set; }
        public int? Departure { get; set; }
        public int? Arrival { get; set; }
        public DateTime? TravelDate { get; set; }

        public virtual City? ArrivalNavigation { get; set; }
        public virtual City? DepartureNavigation { get; set; }
    }
}
