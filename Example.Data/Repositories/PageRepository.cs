using Example.Data.Infrastructure;
using Example.Model.Models;
using TeduShop.Data.Infrastructure;

namespace Example.Data.Repositories
{
    public interface IPageRepository
    {
    }

    public class PageRepository : RepositoryBase<Page>
    {
        public PageRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}