using Example.Data.Infrastructure;
using Example.Model.Models;

namespace Example.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
    }

    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}