using Example.Data.Infrastructure;
using Example.Model.Models;

namespace Example.Data.Repositories
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
    }

    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}