using Domain.Entities;
namespace DataAccess.Repositories
{
    public interface ICustomer
    {
        Task AddCustomer(Customer customer);
        Task<ICollection<Customer>> GetCustomers();
    }
}
