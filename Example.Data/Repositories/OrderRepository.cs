using Example.Data.Infrastructure;
using Example.Model.Models;
using TeduShop.Data.Infrastructure;

namespace Example.Data.Repositories
{
    public interface IOrderRepository
    {
    }

    public class OrderRepository : RepositoryBase<Order>
    {
        public OrderRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}