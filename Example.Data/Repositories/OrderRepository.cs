using Example.Data.Infrastructure;
using Example.Model.Models;
using Example.Data.Infrastructure;

namespace Example.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
    }

    public class OrderRepository : RepositoryBase<Order>
    {
        public OrderRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}