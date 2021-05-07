using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzaBox.Storage;

namespace PizzaBox.Client
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
            services.AddControllersWithViews();
            services.AddScoped<UnitOfWork>();
            services.AddDbContext<PizzaBoxContext>(options => 
            {
                options.UseSqlServer(Configuration.GetConnectionString("mssql"));
                
                // ^--The connection string is in the appsetting.json
                //  ^-- This is the same code that we wrote in OnConfiguring 
                // but now we are injecting the configuration instead.
                // options .UseNpgsql("server=localhost;database=PizzaBoxDB;user id=postgres;password=postgres;");
            //server=Localhost
            //database=PizzaBoxDB
            //user id=postgres
            //password=postgres
            
            });
        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });      
        }
    }
}
