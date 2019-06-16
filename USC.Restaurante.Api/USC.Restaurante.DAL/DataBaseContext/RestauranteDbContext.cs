using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using USC.Restaurante.DAL.Infra;
using USC.Restaurante.Entities;

namespace USC.Restaurante.DAL.DataBaseContext
{
    public class RestauranteDbContext : DbContext, IRestauranteDbContext
    {
        #region Construtor
        private IConfiguration _configuration;

        public RestauranteDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IQueryable<Usuario> QueryUsuario => throw new System.NotImplementedException();
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = _configuration.GetConnectionString("RestauranteDbBase");
            optionsBuilder.UseSqlServer(connection);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
