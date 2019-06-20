using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using USC.Restaurante.DAL.Infra;
using USC.Restaurante.Entities;

namespace USC.Restaurante.DAL.DataBaseContext
{
    public class RestauranteDbContext : DbContext, IRestauranteDbContext
    {
        private IConfiguration _configuration;

        public RestauranteDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = _configuration.GetConnectionString("RestauranteDbBase");
            optionsBuilder.UseSqlServer(connection);
            base.OnConfiguring(optionsBuilder);
        }

        public void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }

        public DbSet<Usuario> Usuario { get; set; }
        public IQueryable<Usuario> QueryUsuario { get { return Usuario; } }
    }
}
