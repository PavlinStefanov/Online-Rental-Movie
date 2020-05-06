using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineMovieRental.Domain.Entities
{
    public class Rental
    {
        public int RentalId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int StockId { get; set; }
        public virtual Stock Stock { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public string Status { get; set; }
    }
}
