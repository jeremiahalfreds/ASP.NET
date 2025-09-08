using DiaryApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add the DB service context & connect to it
builder.Services.AddDbContext<ApplicationDBContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);


// Service worker logging in the background
builder.Services.AddHostedService<WorkerService>(); 

builder.Services.AddSession(); // session storage
builder.Services.AddDistributedMemoryCache(); // in-memory cache
builder.Services.AddDataProtection(); // encrypt cookies, tokens


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSession(); // Enable session

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting(); // routing 

app.UseAuthorization(); // authorization 
app.UseAuthentication(); // checks authentication (optional)


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
