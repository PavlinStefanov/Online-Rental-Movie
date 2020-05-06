using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OnlineMovieRental.Application.Customer.Queries.FetchCustomers;

namespace OnlineMovieRental.WebApi.Customer
{
    [Produces("application/json")]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        [HttpGet("fetchCustomers")]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> FetchCustomers()
        {
            try
            {
                var response = await Mediator.Send(new FetchCustomersQuery());

                return new OkObjectResult(response);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}