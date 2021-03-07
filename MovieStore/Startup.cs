using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MovieStore.Data;
using MovieStore.Services;
using MovieStore.Repositories.Interfaces;
using MovieStore.Services.Interfaces;
using MovieStore.Repositories;

namespace MovieStore
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
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("MovieStoreConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<DataContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();

            //***Repositories
            services.AddTransient<IActorRepository,ActorRepository>();
            services.AddTransient<IDirectorRepository, DirectorRepository>();
            services.AddTransient<IGenreRepository,GenreRepository>();
            services.AddTransient<IMovieRepository,MovieRepository>();
            services.AddTransient<IOrderRepository,OrderRepository>();
            services.AddTransient<IShoppingCartRepository,ShoppingCartRepository>();
            services.AddTransient<IWatchedListRepository,WatchedListRepository>();
            services.AddTransient<IWatchLaterRepository,WatchLaterRepository>();
            services.AddTransient<IWriterRepository,WriterRepository>();
            

            //***Services
            services.AddTransient<IActorService, ActorService>();
            services.AddTransient<IDirectorService,DirectorService>();
            services.AddTransient<IGenreService,GenreService>();
            services.AddTransient<IMovieService,MovieService>();
            services.AddTransient<IOrderService,OrderService>();
            services.AddTransient<IShoppingCartService,ShoppingCartService>();
            services.AddTransient<IWatchedListService,WatchedListService>();
            services.AddTransient<IWatchLaterService,WatchLaterService>();
            services.AddTransient<IWriterService,WriterService>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
