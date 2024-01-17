using MyErp.Business.Interfaces;
using MyErp.DAL;

namespace MyErp.Business;

public class OrderRepository : IGenericRepository<Order>
{
    public void Create(Order element)
    {
        ErpDB.Orders.Add(element);
    }

    public IEnumerable<Order> GetAll()
    {
        return ErpDB.Orders;
    }
}