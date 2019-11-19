using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using PoolSaison2019.Data;
using PoolSaison2019.Models;

namespace PoolSaison2019
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<Models.PoolSaison2019Context>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("PoolSaison2019Context")), ServiceLifetime.Transient);

            services.AddSingleton<IRepository<Joueur>, MockJoueurRepository>();
            services.AddSingleton<IRepository<DerniereSignature>, MockSignatureRepository>();
            services.AddSingleton<IRepository<Participant>, MockParticipantRepository>();
            /*
            services.AddSingleton<IRepository<Joueur>, PoolSaison2019Repository<Joueur>>();
            services.AddSingleton<IRepository<DerniereSignature>, PoolSaison2019Repository<DerniereSignature>>();
            services.AddSingleton<IRepository<Participant>, PoolSaison2019Repository<Participant>>();
            */
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
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
