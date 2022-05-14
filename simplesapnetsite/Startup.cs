using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace simplesapnetsite
{
    public class Startup
    {
        [Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddSessionStateTempDataProvider();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseRouting();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}]");
            });
        }
    }
}
