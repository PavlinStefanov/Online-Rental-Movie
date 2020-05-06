using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineMovieRental.Domain.Entities
{
    public class Stock
    {
        public Stock()
        {
            Rentals = new HashSet<Rental>();
        }
        public int StockId { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        public Guid UniqueKey { get; set; }
        public bool IsAvailable { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
