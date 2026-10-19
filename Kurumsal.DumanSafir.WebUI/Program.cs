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


builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddHttpClient();
builder.Services.AddMemoryCache();

builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ICurrencyService, CurrencyService>();

builder.Services.AddScoped<ICartService, CartManager>();
builder.Services.AddScoped<ICartDal, EfCartDal>();

builder.Services.AddScoped<IYorumService, YorumManager>();
builder.Services.AddScoped<IYorumDal, EfYorumDal>();

builder.Services.AddScoped<ISubeService, SubeManager>();
builder.Services.AddScoped<ISubeDal, EfSubeDal>();

builder.Services.AddScoped<IIletisimService, IletisimManager>();
builder.Services.AddScoped<IIletisimDal, EfIletisimDal>();

builder.Services.AddScoped<ICartItemService, CartItemManager>();
builder.Services.AddScoped<ICartItemDal, EfCartItemDal>();

builder.Services.AddScoped<IRezervasyonService, RezervasyonManager>();
builder.Services.AddScoped<IRezervasyonDal, EfRezervasyonDal>();

builder.Services.AddScoped<IHaberService, HaberManager>();
builder.Services.AddScoped<IHaberDal, EfHaberDal>();

builder.Services.AddScoped<IFotografService, FotografManager>();
builder.Services.AddScoped<IFotografDal, EfFotografDal>();


builder.Services.AddScoped<IFotoGaleriService, FotoGaleriManager>();
builder.Services.AddScoped<IFotoGaleriDal, EfFotoGaleriDal>();


builder.Services.AddScoped<IMenuService, MenuManager>();
builder.Services.AddScoped<IMenuDal, EfMenuDal>();

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


builder.Services.AddScoped<ISayfaService, SayfaManager>();
builder.Services.AddScoped<ISayfaDal, EfSayfaDal>();

builder.Services.AddScoped<IOdaService, OdaManager>();
builder.Services.AddScoped<IOdaDal, EfOdaDal>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseMiddleware<CurrencyMiddleware>();

app.UseHttpsRedirection();
app.UseStaticFiles();
var filesPath = Path.Combine(Directory.GetCurrentDirectory(), "Files");


if (!Directory.Exists(filesPath))
{
    Directory.CreateDirectory(filesPath);
}

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(filesPath),
    RequestPath = "/Files"
});

app.UseRouting();
app.UseAuthorization();

//app.UseMiddleware<IPAddressMiddleware>();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "hizmet",
    pattern: "hizmet/{slug}-{id:int}.html",
    defaults: new { controller = "Hizmet", action = "Detay" });

app.MapControllerRoute(
    name: "sayfa",
    pattern: "sayfa/{slug}-{id:int}.html",
    defaults: new { controller = "Sayfa", action = "Detay" });

app.MapControllerRoute(
    name: "referans",
    pattern: "referans/{slug}-{id:int}.html",
    defaults: new { controller = "Referans", action = "Detay" });

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

app.MapControllerRoute(
    name: "iletisim",
    pattern: "iletisim/{slug}.html",
    defaults: new { controller = "Iletisim", action = "Index" });

app.MapControllerRoute(
    name: "daire",
    pattern: "daire/{slug}-{id:int}.html",
    defaults: new { controller = "Oda", action = "Index" });

app.MapControllerRoute(
    name: "sube",
    pattern: "sube/{slug}-{id:int}.html",
    defaults: new { controller = "Sube", action = "Index" });

app.MapControllerRoute(
    name: "haber",
    pattern: "haber/{slug}-{id:int}.html",
    defaults: new { controller = "Haber", action = "Index" });

app.MapControllerRoute(
    name: "fotogaleri",
    pattern: "fotogaleri/{slug}.html",
    defaults: new { controller = "FotoGaleri", action = "Index" });
app.MapControllerRoute(
    name: "haberler",
    pattern: "haber/{slug}.html",
    defaults: new { controller = "Haber", action = "List" });
app.MapControllerRoute(
    name: "yorumlar",
    pattern: "yorum/{slug}.html",
    defaults: new { controller = "Yorum", action = "List" });

app.Run();
