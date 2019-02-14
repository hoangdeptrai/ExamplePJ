using Example.Data.Infrastructure;
using Example.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Data.Repositories
{
    public interface IProductTagRepository: IRepository<Product>
    {

    }
    public class ProductTagRepository:RepositoryBase<Product>
    {
        public ProductTagRepository(DbFactory dbFactory):base(dbFactory)
        {

        }

    }
}
