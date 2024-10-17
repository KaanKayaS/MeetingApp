var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var app = builder.Build();


app.UseStaticFiles();  //wwwrootu dışarıya açmış oluyoruz

app.UseRouting();

// mvc
// rest api
// razor pages


// app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);


app.Run();
