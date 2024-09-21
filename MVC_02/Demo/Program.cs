namespace Session_02;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        /*
         * Add Any services to the container Before Build.
         */

        builder.Services.AddControllers(); // Registering The Build-in APIS Services In The Container
        builder.Services.AddControllersWithViews(); // Registering The Build-in MVC Services In The Container
        builder.Services.AddRazorPages(); // Registering The Build-in Razor Pages Services In The Container
        builder.Services.AddMvc(); // Registering The Build-in All Web Services In The Container
        
        var app = builder.Build();
        app.UseStaticFiles(); // This is a Middleware to use Static Files Like CSS, JS, Images, etc.
        app.MapGet("/", () => "Hello World!");
        app.MapGet("/login", () => "Hello World!");
        app.MapGet("/signin", () => login);

    /*
     * Constrains
     * - :int is an Int Constraint
     * - :alpha? is a String Constraint
     * - :int:alpha? Nested Constraint
     */
    
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action}/{id:int?}" ,// this is a Segment of the URL
            defaults: new { controller = "Movies", action = "Test" } // this is a Default Value
        );
        app.Run();
    }

    static string login()
    {
        return "login!";
    }
}
