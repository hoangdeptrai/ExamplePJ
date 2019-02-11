using Example.Data.Infrastructure;
using Example.Model.Models;


namespace Example.Data.Repositories
{
    public interface IMenuRepository : IRepository<Menu>
    {

    }
    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}