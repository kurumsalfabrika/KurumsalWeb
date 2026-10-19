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


builder.Services.AddScoped<IRezervasyonService, RezervasyonManager>();
builder.Services.AddScoped<IRezervasyonDal, EfRezervasyonDal>();


builder.Services.AddScoped<IMenuService, MenuManager>();
builder.Services.AddScoped<IMenuDal, EfMenuDal>();

builder.Services.AddScoped<IUrunService, UrunManager>();
builder.Services.AddScoped<IUrunDal, EfUrunDal>();

builder.Services.AddScoped<IUrunKategoriService, UrunKategoriManager>();
builder.Services.AddScoped<IUrunKategoriDal, EfUrunKategoriDal>();

builder.Services.AddScoped<ISayfaService, SayfaManager>();
builder.Services.AddScoped<ISayfaDal, EfSayfaDal>();

builder.Services.AddScoped<IOdaKategoriService, OdaKategoriManager>();
builder.Services.AddScoped<IOdaKategoriDal, EfOdaKategoriDal>();

builder.Services.AddScoped<IOdaService, OdaManager>();
builder.Services.AddScoped<IOdaDal, EfOdaDal>();

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

builder.Services.AddScoped<IFotoGaleriService, FotoGaleriManager>();
builder.Services.AddScoped<IFotoGaleriDal, EfFotoGaleriDal>();

builder.Services.AddScoped<IFotografService, FotografManager>();
builder.Services.AddScoped<IFotografDal, EfFotografDal>();


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
    name: "urun-detay",
    pattern: "urun-detay/{slug}-{id:int}.html",
    defaults: new { controller = "Urun", action = "UrunDetay" });

app.MapControllerRoute(
    name: "kategori",
    pattern: "kategori/{slug}-{id:int}.html",
    defaults: new { controller = "Kategori", action = "KategoriList" });

app.MapControllerRoute(
    name: "portfolyo",
    pattern: "portfolyo/{slug}-{id:int}.html",
    defaults: new { controller = "Portfolyo", action = "Detay" });

app.MapControllerRoute(
    name: "rezervasyon",
    pattern: "rezervasyon/{slug}-{id:int}.html",
    defaults: new { controller = "Rezervasyon", action = "Index" });

app.MapControllerRoute(
    name: "anasayfa",
    pattern: "anasayfa/{slug}.html",
    defaults: new { controller = "Home", action = "Index" });

app.Run();
