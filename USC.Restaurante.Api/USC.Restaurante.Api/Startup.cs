using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.Swagger;
using USC.Restaurante.Api.UoW;
using USC.Restaurante.Api.UoW.Infra;
using USC.Restaurante.BLL;
using USC.Restaurante.BLL.Infra;
using USC.Restaurante.DAL;
using USC.Restaurante.DAL.DataBaseContext;
using USC.Restaurante.DAL.Infra;

namespace USC.Restaurante.Api
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }
        public object PlatformServices { get; private set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // Configurando o serviço de documentação do Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "Arquitetura de Software - Restaurante",
                        Version = "v1"
                    });

                c.IncludeXmlComments(GetXmlCommentsPath());
            });

            // DB CONTEXT
            services.AddScoped<IRestauranteDbContext, RestauranteDbContext>();

            // REPOSITORY
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IRestauranteHistoricoRepository, RestauranteHistoricoRepository>();
            services.AddScoped<IRestauranteRepository, RestauranteRepository>();
            services.AddScoped<IUsuarioRestauranteRepository, UsuarioRestauranteRepository>();

            // BLL
            services.AddScoped<IUsuarioBLL, UsuarioBLL>();
            services.AddScoped<IAutenticadorBLL, AutenticadorBLL>();
            services.AddScoped<IRestauranteBLL, RestauranteBLL>();
            services.AddScoped<IVotosBLL, VotosBLL>();

            // UoW
            services.AddScoped<IUsuarioUoW, UsuarioUoW>();
            services.AddScoped<IAutenticadorUoW, AutenticadorUoW>();
            services.AddScoped<IRestautanteUoW, RestauranteUoW>();
            services.AddScoped<IVotosUoW, VotosUoW>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                // FORMATACAO JSON (PASCAL CASE)
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());

        }

        protected static string GetXmlCommentsPath()
        {
            return string.Format(@"{0}\USC.Restaurante.Api.xml", System.AppDomain.CurrentDomain.BaseDirectory);
        }

        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();

            app.UseCors(builder => builder
                                    .AllowAnyOrigin()
                                    .AllowAnyMethod()
                                    .AllowAnyHeader()
                                    .AllowCredentials());

            app.UseMvc();

            // Ativando middlewares para uso do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "Arquitetura de Software - Restaurante");
            });
        }
    }
}