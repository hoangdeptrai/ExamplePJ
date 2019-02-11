using Example.Data.Infrastructure;
using Example.Model.Models;
using TeduShop.Data.Infrastructure;

namespace Example.Data.Repositories
{
    public interface ISupportOnlineRepository
    {
    }

    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(DbFactory dbFactory) : base(dbFactory)

        {
        }
    }
}