using CMS.Contracts;
using CMS.Model;
using CMS.ServiceLogic;
using Microsoft.AspNetCore.Mvc;

namespace CustomerWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        // Dependency is injected here
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("greet/{name}")]
        public ActionResult<CustomerGreetingResponse> GetCustomerGreeting(string name)
        {
            return Ok(_customerService.GetGreeting(name));
        }
    }
}