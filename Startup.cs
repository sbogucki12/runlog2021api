using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using runlog2021api.Extensions;
using runlog2021api.Helpers;
using runlog2021api.Models;
using runlog2021api.Models.DataManager;
using runlog2021api.Models.Repository;

namespace runlog2021api
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
            services.ConfigureCors();
            //services.AddCors(options =>
            //{
            //    options.AddPolicy(name: "CorsPolicy",
            //       builder =>
            //       {
            //           builder.AllowAnyOrigin()
            //           .AllowAnyHeader()
            //           .AllowAnyMethod();                       
            //       });
            //});


            services.ConfigureIISIntegration();
            services.AddDbContext<RunContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:RunDB"]));
            services.AddScoped<IDataRepository<Run>, RunManager>();
            services.AddScoped<IDataRepository<Image>, ImageManager>();
            services.AddControllers()
                    .AddJsonOptions(options =>
            options.JsonSerializerOptions.Converters.Add(new TimeSpanToStringConverter()));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCors("CorsPolicy");
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
