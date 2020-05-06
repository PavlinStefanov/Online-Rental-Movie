using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OnlineMovieRental.Application.Common;
using OnlineMovieRental.Application.Interfaces;

namespace OnlineMovieRental.Application.Customer.Queries.FetchCustomers
{
    public partial class FetchCustomersQuery : IRequest<IEnumerable<CustomerDto>>
    {
        public class FetchCustomerQueryHandler : IRequestHandler<FetchCustomersQuery, IEnumerable<CustomerDto>>
        {
            private readonly IMovieRentalDbContext _dbContext;

            public FetchCustomerQueryHandler(IMovieRentalDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<IEnumerable<CustomerDto>> Handle(FetchCustomersQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    return await Task.FromResult(_dbContext.Customers.ToDtos());
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
