using Blog.Context;
using Microsoft.EntityFrameworkCore;

namespace Blog.Commons.Bootstrapper
{
    public static class Bootstrapper
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BlogContext>(x => x.UseSqlServer(configuration.GetConnectionString("DbConnection")));
            services.AddRazorPages();


            return services;
        }
        public static WebApplication UseAppMidderWares(this WebApplication app)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapRazorPages()
               .WithStaticAssets();

            return app;
        }
    }
}
