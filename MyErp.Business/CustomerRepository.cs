using MyErp.Business.Interfaces;
using MyErp.DAL;

namespace MyErp.Business;

public class CustomerRepository : IGenericRepository<Customer>
{
    public void Create(Customer element)
    {
        ErpDB.Customers.Add(element);
    }

    public IEnumerable<Customer> GetAll()
    {
        return ErpDB.Customers;
    }
}