using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using aula2.context;
using Microsoft.EntityFrameworkCore;
using aula2.UseCases.Heroi;
using aula2.Repositorio;
using aula2.Bordas.Adapter;
using aula2.Adapter;

namespace aula2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddEntityFrameworkNpgsql().AddDbContext<LocalDBContext>(opt => opt.UseNpgsql("Server=127.0.0.1;Database=bancoPablo;Port=5433;User Id=postgres;Password=123"));
            //services.AddEntityFrameworkNpgsql().AddDbContext<LocalDBContext>(opt => opt.UseNpgsql(Configuration.GetConnectionString("urlpablo")));

            services.AddScoped<IAdicionarHeroiUseCase, AdicionarHeroiUseCase>();
            services.AddScoped<IRemoverHeroiUseCase, RemoverHeroiUseCase>();
            services.AddScoped<IAtualizarHeroiUseCase, AtualizarHeroiUseCase>();
            services.AddScoped<IListarHeroiUseCase, ListarHeroiUseCase>();
            services.AddScoped<IObterHeroiUseCase, ObterHeroiUseCase>();
            services.AddScoped<IHeroiAdapter, HeroiAdapter>();
            services.AddScoped<IRepositorioHeroi, RepositorioHeroi>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
