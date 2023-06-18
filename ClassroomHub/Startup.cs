using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Services;
using ClassroomHub.Web.AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using ClassroomHub.Data;
using ClassroomHub.DependencyInjetion;
using ClassroomHub.Web;
using ClassroomHub.Service;

namespace ClassroomHub
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
			services.AddAutoMapper(typeof(MapperProfile));
            services.AddDbContext<Context>(x => x.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ClassroomHubDB;Trusted_Connection=True;"));
            services.AddServicesDependency();
            services.AddRepositoryDependency();
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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        public void InjectDependencies(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();   
            services.AddScoped<ITeacherService, TeacherService>();
			services.AddScoped<IClassService, ClassService>();
			services.AddScoped<IModuleService, ModuleService>();
        }
    }
}
