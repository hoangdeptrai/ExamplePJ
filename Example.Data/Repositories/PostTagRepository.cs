using Example.Data.Infrastructure;
using Example.Model.Models;

namespace Example.Data.Repositories
{
    public interface IPostTagRepository : IRepository<PostTag>
    {
    }

    public class PostTagRepository : RepositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}