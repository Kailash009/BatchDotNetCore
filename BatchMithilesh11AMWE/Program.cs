using BatchMithilesh11AMWE.Filter;
using BatchMithilesh11AMWE.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Configuration.GetConnectionString("DBCS");
builder.Services.AddScoped<FileUpload>();
builder.Services.AddMvc(options =>
{
    options.Filters.Add(new CustomActionFilter());
});
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(4); // Set Session time is 4 Min.
});
var app = builder.Build();

// Configure the HTTP request pipeline.  // MiddleWare.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();  //
app.UseStaticFiles();

app.UseRouting();
app.UseSession();
app.UseAuthorization();


app.MapControllerRoute(    // Routing
    name: "default",
    pattern: "{controller=Doctor}/{action=GetDoctorDetails}/{id?}");  // Routing


app.Run();

// MiddleWare

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Hello! First MiddleWare");
//});













