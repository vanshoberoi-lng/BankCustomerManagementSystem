using CMS.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.ServiceLogic
{
    public interface ICustomerService
    {
        CustomerGreetingResponse GetGreeting(string name);
    }
}
