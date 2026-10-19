using Kurumsal.Business.Abstract;
using Kurumsal.Business.Concrete;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
var configurationBuilder = new ConfigurationBuilder();
configurationBuilder.AddJsonFile("appsettings.json");
var configuration = configurationBuilder.Build();
// Add services to the container.

builder.Services.AddControllersWithViews();


builder.Services.AddScoped<IMenuService, MenuManager>();
builder.Services.AddScoped<IMenuDal, EfMenuDal>();

builder.Services.AddScoped<IIletisimAyarService, IletisimAyarManager>();
builder.Services.AddScoped<IIletisimAyarDal, EfIletisimAyarDal>();

builder.Services.AddScoped<IFtpService, FtpManager>();
builder.Services.AddScoped<IFtpDal, EfFtpDal>();

builder.Services.AddScoped<ISiteAyarService, SiteAyarManager>();
builder.Services.AddScoped<ISiteAyarDal, EfSiteAyarDal>();

builder.Services.AddScoped<ISliderService, SliderManager>();
builder.Services.AddScoped<ISliderDal, EfSliderDal>();

builder.Services.AddScoped<IPortfolyoService, PortfolyoManager>();
builder.Services.AddScoped<IPortfolyoDal, EfPortfolyoDal>();

builder.Services.AddScoped<ISosyalMedyaAdresService, SosyalMedyaAdresManager>();
builder.Services.AddScoped<ISosyalMedyaAdresDal, EfSosyalMedyaAdresDal>();

builder.Services.AddScoped<IHizmetService, HizmetManager>();
builder.Services.AddScoped<IHizmetDal, EfHizmetDal>();


builder.Services.AddScoped<IReferansService, ReferansManager>();
builder.Services.AddScoped<IReferansDal, EfReferansDal>();


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
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
    Path.Combine(Directory.GetCurrentDirectory(), "Files")),
    RequestPath = "/Files"
});

app.UseRouting();
app.UseAuthorization();




app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "hizmet",
    pattern: "hizmet/{slug}-{id:int}.html",
    defaults: new { controller = "Hizmet", action = "Detay" });

app.MapControllerRoute(
    name: "referans",
    pattern: "referans/{slug}-{id:int}.html",
    defaults: new { controller = "Referans", action = "Detay" });

app.MapControllerRoute(
    name: "portfolyo",
    pattern: "portfolyo/{slug}-{id:int}.html",
    defaults: new { controller = "Portfolyo", action = "Detay" });

app.Run();
