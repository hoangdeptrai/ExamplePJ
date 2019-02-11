using Example.Data.Infrastructure;
using Example.Model.Models;
using Example.Data.Infrastructure;

namespace Example.Data.Repositories
{
    public interface IVisitorStatisticRepository : IRepository<VisitorStatistic>
    {
    }

    public class VisitorStatisticRepository : RepositoryBase<VisitorStatistic>
    {
        public VisitorStatisticRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}