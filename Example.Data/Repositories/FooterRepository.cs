using Example.Data.Infrastructure;
using Example.Model.Models;

namespace Example.Data.Repositories
{
    public interface IRepository : IRepository<Footer>
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IRepository
    {
        public FooterRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}