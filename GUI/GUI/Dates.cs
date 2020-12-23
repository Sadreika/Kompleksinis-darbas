using System;

namespace GUI
{
    public class Dates
    {
        public DateTime departureDate;
        public DateTime? arrivalDate;

        public Dates(DateTime departureDate, DateTime? arrivalDate = null)
        {
            this.departureDate = departureDate;
            this.arrivalDate = arrivalDate;
        }
    }
}
