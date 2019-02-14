using Example.Data.Infrastructure;
using Example.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Data.Repositories
{
    public interface IMenuGroupRepository : IRepository<MenuGroup>
    {

    }
    public class MenuGroupRepository :RepositoryBase<MenuGroup>
    {
        public MenuGroupRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
