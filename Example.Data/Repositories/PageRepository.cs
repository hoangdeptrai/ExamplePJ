using Example.Data.Infrastructure;
using Example.Model.Models;
using Example.Data.Infrastructure;

namespace Example.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    {
    }

    public class PageRepository : RepositoryBase<Page>
    {
        public PageRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}