using DataAccess.Repositories;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomer customer;

        public CustomerController(ICustomer customer)
        {
            this.customer = customer;
        }

        [HttpPost]
        public async Task <IActionResult> AddCustomer(Customer data)
        {
            await customer.AddCustomer(data);
            return Ok("Saved");
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers() => Ok(await customer.GetCustomers());
    }
}
