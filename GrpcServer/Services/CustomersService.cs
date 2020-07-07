using Grpc.Core;
using GrpcServer.Protos;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Services
{
    public class CustomersService:Customer.CustomerBase
    {
        private readonly ILogger<CustomersService>_logger;
        public CustomersService(ILogger<CustomersService> logger)
        {
            _logger = logger;
        }

        public override Task<CustomerModel> GetCustomerInfo(CustomerLookupModel request, ServerCallContext context)
        {
            CustomerModel output = new CustomerModel();

            if(request.UserId==1)
            {
                output.Firstname = "Andrus";
                output.Lastname = "Gerber";

            }
            else if(request.UserId==2)
            {
                output.Firstname = "Ingar";
                output.Lastname = "Ashment";
            }
            else
            {
                output.Firstname = "Amalee";
                output.Lastname = "Mcbeth";
            }
            return Task.FromResult(output);
        }
    }
}
