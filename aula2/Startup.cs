using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula2.context;
using Microsoft.EntityFrameworkCore;
using aula2.services;
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
            services.AddScoped<IAdicionarFantasiaUseCase, AdicionarFantasiaUseCase>();
            services.AddScoped<IAdicionarFraquesaUseCase, AdicionarFraquesaUseCase>();
            services.AddScoped<IAdicionarHeroiUseCase, AdicionarHeroiUseCase>();
            services.AddScoped<IAdicionarPoderUseCase, AdicionarPoderUseCase>();
            services.AddScoped<IDeletarHeroiUseCase, DeletarHeroiUseCase>();
            services.AddScoped<IRetornrHeroiPorIdUseCase, RetornrHeroiPorIdUseCase>();
            services.AddScoped<IAtualizarHeroiUseCase, AtualizarHeroiUseCase>();
            services.AddScoped<IRetornrHeroiPorIdUseCase, RetornrHeroiPorIdUseCase>();
            services.AddScoped<IRetornrHeroiPorIdUseCase, RetornrHeroiPorIdUseCase>();
            services.AddScoped<IAdicionarHeroi, AdicionarHeroiAdapter>();


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
