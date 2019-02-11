using Example.Data.Infrastructure;
using Example.Model.Models;
using Example.Data.Infrastructure;

namespace Example.Data.Repositories
{
    public interface ISupportOnlineRepository : IRepository<SupportOnline>
    {
    }

    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(DbFactory dbFactory) : base(dbFactory)

        {
        }
    }
}