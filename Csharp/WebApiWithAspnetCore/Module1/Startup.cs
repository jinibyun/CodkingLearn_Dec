using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Module1.Data;
using Module1.Services;
using Swashbuckle.AspNetCore.Swagger;

namespace Module1
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
            // default
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // built-in dependency injection
            services.AddScoped<IProduct, ProductRepository>();

            // versioning
            // it requires package named "Microsoft.AspNetCore.Mvc.Versioning"
            services.AddApiVersioning(options => {
                    options.AssumeDefaultVersionWhenUnspecified = true;
                    options.ApiVersionReader = new MediaTypeApiVersionReader();

            });            

            // contend negotiation(accept type should be matching with mime type)
            // to send xml type if client (browser) wants
            services.AddMvc().AddXmlSerializerFormatters();

            // entiry framework connection string
            var connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProductsDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            // var connString = Configuration.GetConnectionString("ProductDbContext"); // azure

            services.AddDbContext<ProductDbContext>(option => option.UseSqlServer(connString));

            // documentation
            services.AddSwaggerGen(x => x.SwaggerDoc("v1", new Info { Title = "Product Api", Version = "v1" }));
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ProductDbContext productDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(x => x.SwaggerEndpoint("/swagger/v1/swagger.json", "API for product"));

            app.UseHttpsRedirection();
            app.UseMvc();
            productDbContext.Database.EnsureCreated();
        }
    }
}
