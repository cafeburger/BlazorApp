using BlazorApp.Components;
using BlazorApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.FluentUI.AspNetCore.Components;


namespace BlazorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<BlazorAppContext>(options =>
               options.UseSqlite(builder.Configuration.GetConnectionString("BlazorAppContext") 
               ?? throw new InvalidOperationException("Connection string 'BlazorAppContext' not found.")));
            
            // string databaseUrl = builder.Configuration["ConnectionStrings:DefaultConnection"];
            // string userId = Environment.GetEnvironmentVariable("DB_USER");
            // string password = Environment.GetEnvironmentVariable("DB_PASSWORD");
            // string connectionString = $"{databaseUrl} user={userId}; password={password};";
            
            // builder.Services.AddDbContext<BlazorAppContext>(options =>
            //     options.UseMySql(
            //         connectionString,
            //         new MySqlServerVersion(new Version(8, 0, 21)) // 確保指定正確的 MySQL 版本
            //     ));

            builder.Services.AddQuickGridEntityFrameworkAdapter();

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents()
                .AddInteractiveWebAssemblyComponents();
            builder.Services.AddFluentUIComponents();
            builder.Services.AddDataGridEntityFrameworkAdapter();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddInteractiveWebAssemblyRenderMode()
                .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

            app.Run();
        }
    }
}
