using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineMovieRental.Application.Customer.Queries.FetchCustomers
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}
