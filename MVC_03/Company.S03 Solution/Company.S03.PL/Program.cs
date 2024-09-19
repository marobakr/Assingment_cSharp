using Company.S03.BLL.Repositories;
using Company.S03.DAL.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Company.S03.PL;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

   

        /* === === === === === === Start Dependency Injection === === === === === === */
        // Add services to the container.
        builder.Services.AddControllersWithViews();
         
        // builder.Services.AddScoped<AppDbContext>(); //* Allow Dependency Injection for AppDbContext because CLR will not be able to create an instance of AppDbContext without a parameterless constructor
        builder.Services.AddDbContext<AppDbContext>(option =>
        {
            // *  get the connection string from appsettings.json
            option.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]); 
            
            //! Or Use the GetConnectionString method
            // option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            
        }); //* Extensions Method: AddDbContext will create an instance of AppDbContext and add it to the service container
       
        builder.Services.AddScoped<DepartmentRepository>(); //* Allow Dependency Injection for DepartmentRepository
        
        /* === === === === === === End Dependency Injection === === === === === === */
        
        var app = builder.Build();
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}