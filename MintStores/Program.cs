using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MintStores.Data;
using MintStores.DataControllers;
using MintStores.Interfaces;
using MintStores.Interfaces.DataController;
using MintStores.Interfaces.Services;
using MintStores.Models;
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

            //DataControllers
            services.AddScoped<IDataController<Brand>, BrandDataController>();
            services.AddScoped<IDataController<Category>, CategoryDataController>();
            services.AddScoped<IDataController<Customer>, CustomerDataController>();
            services.AddScoped<IDataController<Order>, OrderDataController>();
            services.AddScoped<IDataController<OrderItem>, OrderItemDataController>();
            services.AddScoped<IDataController<Product>, ProductDataController>();
            services.AddScoped<IDataController<Staff>, StaffDataController>();
            services.AddScoped<IDataController<Store>, StoreDataController>();
            services.AddScoped<IProductDataController, ProductDataController>();

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
