using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private ExampleDbContext dbContext;
        public UnitOfWork (DbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public ExampleDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }
        public void Commit()
        {
            throw new NotImplementedException();
        }
    }
}
