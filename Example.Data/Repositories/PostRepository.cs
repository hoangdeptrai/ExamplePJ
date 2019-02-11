using Example.Data.Infrastructure;
using Example.Model.Models;
using TeduShop.Data.Infrastructure;

namespace Example.Data.Repositories
{
    public interface IPostRepository
    {
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}