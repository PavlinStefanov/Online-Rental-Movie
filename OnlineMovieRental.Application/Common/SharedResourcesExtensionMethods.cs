using OnlineMovieRental.Application.Customer.Queries.FetchCustomers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineMovieRental.Application.Common
{
    public static class SharedResourcesExtensionMethods
    {
        public static IEnumerable<CustomerDto> ToDtos(this IEnumerable<Domain.Entities.Customer> customers)
        {
            return customers.Select(x => new CustomerDto
            {
                Id = x.CustomerId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                Mobile = x.Mobile
            });
        }
    }
}
