using AulasDotNet.Adapter;
using AulasDotNet.Borders.Adapter;
using AulasDotNet.Borders.Repositorios;
using AulasDotNet.Borders.UseCase;
using AulasDotNet.Context;
using AulasDotNet.Repositorios;
using AulasDotNet.Services;
using AulasDotNet.UseCase;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet
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
            services.AddEntityFrameworkNpgsql().AddDbContext<LocalDBContext>(opt => opt.UseNpgsql(Configuration.GetConnectionString("postgresql")));

            services.AddScoped<IPessoaService, PessoaService>();


            services.AddScoped<IAdicionaPessoaUseCase, AdicionaPessoaUseCase>();
            services.AddScoped<IAtualizaPessoaUseCase, AtualizaPessoaUseCase>();
            services.AddScoped<IRemoverPessoaUseCase, RemoverPessoaUseCase>();
            services.AddScoped<IRetornaListaPessoaUseCase, RetornaListaPessoaUseCase>();
            services.AddScoped<IRetornaPessoaUseCase, RetornaPessoaUseCase>();
            services.AddScoped<IRepositorioPessoas, RepositorioPessoas>();
            services.AddScoped<IAdicionarPessoaAdapter, AdicionarPessoaAdapter>();
            services.AddScoped<IAtualizarPessoaAdapter, AtualizarPessoaAdapter>();

            services.AddControllers();




            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AulasDotNet", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AulasDotNet v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
