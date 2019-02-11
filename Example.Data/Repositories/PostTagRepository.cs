using Example.Data.Infrastructure;
using Example.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;

namespace Example.Data.Repositories
{
    public interface IPostTagRepository
    { }
    public class PostTagRepository: RepositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
