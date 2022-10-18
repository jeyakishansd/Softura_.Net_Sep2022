using System;
using System.Collections.Generic;

namespace GixxWings.Models
{
    public partial class City
    {
        public City()
        {
            BookingInfoArrivalNavigations = new HashSet<BookingInfo>();
            BookingInfoDepartureNavigations = new HashSet<BookingInfo>();
        }

        public int CityId { get; set; }
        public string? CityName { get; set; }
        public string? CityCode { get; set; }

        public virtual ICollection<BookingInfo> BookingInfoArrivalNavigations { get; set; }
        public virtual ICollection<BookingInfo> BookingInfoDepartureNavigations { get; set; }
    }
}
