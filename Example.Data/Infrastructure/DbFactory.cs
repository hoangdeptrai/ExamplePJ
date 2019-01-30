namespace Example.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ExampleDbContext dbContext;

        public ExampleDbContext Init()
        {
            return dbContext ?? (dbContext = new ExampleDbContext());
        }
        protected override void DisposeCore()
        {
            dbContext?.Dispose();
        }
    }
}