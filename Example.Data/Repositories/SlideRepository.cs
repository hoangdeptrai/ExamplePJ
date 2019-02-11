using Example.Data.Infrastructure;
using Example.Model.Models;

namespace Example.Data.Repositories
{
    public interface ISlideRepository : IRepository<Slide>
    {
    }

    public class SlideRepository : RepositoryBase<Slide>
    {
        public SlideRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}