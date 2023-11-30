using MintStores.Core;
using MintStores.Core.Interfaces.DataRepositories;
using MintStores.Core.Model;
using MintStores.Core.Services;
using MintStores.Data;
using MintStores.Infrastructure.DataRepositories;
using MintStores.Services;

namespace MintStores
{
    public class Program
    {

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddHttpClient();

            //DataControllers
            services.AddScoped<IBaseDataRepository<Brand>, BrandDataRepository>();
            services.AddScoped<IBaseDataRepository<Category>, CategoryDataRepository>();
            services.AddScoped<IBaseDataRepository<Customer>, CustomerDataRepository>();
            services.AddScoped<IBaseDataRepository<Order>, OrderDataRepository>();
            services.AddScoped<IBaseDataRepository<OrderItem>, OrderItemDataRepository>();
            services.AddScoped<IBaseDataRepository<Product>, ProductDataRepository>();
            services.AddScoped<IBaseDataRepository<Staff>, StaffDataRepository>();
            services.AddScoped<IBaseDataRepository<Store>, StoreDataRepository>();
            services.AddScoped<IProductDataRepository, ProductDataRepository>();

            // Servise
            services.AddScoped<IBaseService<Brand>, BaseService<Brand>>();
            services.AddScoped<IBaseService<Category>, BaseService<Category>>();
            services.AddScoped<IBaseService<Customer>, BaseService<Customer>>();
            services.AddScoped<IBaseService<Order>, BaseService<Order>>();
            services.AddScoped<IBaseService<OrderItem>, BaseService<OrderItem>>();
            services.AddScoped<IBaseService<Product>, BaseService<Product>>();
            services.AddScoped<IBaseService<Staff>, BaseService<Staff>>();
            services.AddScoped<IBaseService<Store>, BaseService<Store>>();
            services.AddScoped<IProductService, ProductService>();

        }

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            ConfigureServices(builder.Services);


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}
