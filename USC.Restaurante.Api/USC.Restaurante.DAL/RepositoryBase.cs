using USC.Restaurante.DAL.Infra;

namespace USC.Restaurante.DAL
{
    public abstract class RepositoryBase<TContext> where TContext : IRestauranteDbContext
    {
        protected TContext _dbContext;

        public RepositoryBase(TContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}

