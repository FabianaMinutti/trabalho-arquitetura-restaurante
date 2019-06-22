using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;
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

        public DbSet<Pessoa> Pessoa { get; set; }
        public IQueryable<Pessoa> QueryPessoa { get { return Pessoa; } }

        public DbSet<Entities.Restaurante> Restaurante { get; set; }
        public IQueryable<Entities.Restaurante> QueryRestaurante { get { return Restaurante; } }

        public DbSet<RestauranteHistorico> RestauranteHistorico { get; set; }
        public IQueryable<RestauranteHistorico> QueryRestauranteHistorico { get { return RestauranteHistorico; } }

        public DbSet<UsuarioRestaurante> UsuarioRestaurante { get; set; }
        public IQueryable<UsuarioRestaurante> QueryUsuarioRestaurante { get { return UsuarioRestaurante; } }
    }
}
