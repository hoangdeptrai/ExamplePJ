using Example.Data.Infrastructure;
using Example.Model.Models;
using TeduShop.Data.Infrastructure;

namespace Example.Data.Repositories
{
    public interface IFooterRepository
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}