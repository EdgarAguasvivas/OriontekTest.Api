using AutoMapper;
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
using OriontekTest.Api.Middleware;
using OriontekTest.Business.Builders;
using OriontekTest.Business.Profiles;
using OriontekTest.Data.Builders;
using OriontekTest.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriontekTest.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "OriontekTest.Api", Version = "v1" });
            });
            services.DataServices();
            services.BusinessServices(Configuration);
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //services.AddScoped<IMapper, Mapper>();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new CustomerProfile());
                mc.AddProfile(new CompanyProfile());
                mc.AddProfile(new AddressProfile());
            });



            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddScoped<IMapper, Mapper>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "OriontekTest.Api v1"));
            }

            app.UseCors(builder => builder.WithOrigins("http://localhost:4200")
  .AllowAnyMethod()
  .AllowAnyHeader());

            app.UseMiddleware<ErrorHandlingMiddleware>();

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
