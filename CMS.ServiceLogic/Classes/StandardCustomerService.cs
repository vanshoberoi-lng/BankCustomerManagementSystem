using System;
using System.Collections.Generic;
using System.Text;
using CMS.Contracts;

namespace CMS.ServiceLogic.Classes
{
    public class StandardCustomerService : ICustomerService
    {
        public CustomerGreetingResponse GetGreeting(string name)
        {
            var customer = new CMS.Model.CustomerEntity
            {
                Name = name,
                CurrentBalance = 1000.50m
            };

            return new CMS.Contracts.CustomerGreetingResponse
            {
                Message = $"Hello {customer.Name}, welcome to our Standard Bank account! " +
                $"You get initial balance of {customer.CurrentBalance}",

                CustomerTier = "Standard",
                GeneratedAt = DateTime.Now
            };
        }
    }
}
