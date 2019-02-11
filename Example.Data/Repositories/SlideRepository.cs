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
    public class SlideRepository : RepositoryBase<Slide>
    {
        public SlideRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
