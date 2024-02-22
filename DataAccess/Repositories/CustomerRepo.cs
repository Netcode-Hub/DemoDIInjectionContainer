using DataAccess.Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace DataAccess.Repositories
{
    public class CustomerRepo : ICustomer
    {
        private readonly AppDbContext appDbContext;

        public CustomerRepo(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task AddCustomer(Customer customer)
        {
            appDbContext.Customers.Add(customer);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<ICollection<Customer>> GetCustomers() 
            => await appDbContext.Customers.ToListAsync();
    }
}
