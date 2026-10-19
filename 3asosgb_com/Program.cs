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

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRezervasyonService, RezervasyonManager>();
builder.Services.AddScoped<IRezervasyonDal, EfRezervasyonDal>();


builder.Services.AddScoped<IMenuService, MenuManager>();
builder.Services.AddScoped<IMenuDal, EfMenuDal>();

builder.Services.AddScoped<IIletisimService, IletisimManager>();
builder.Services.AddScoped<IIletisimDal, EfIletisimDal>();

builder.Services.AddScoped<IHaberService, HaberManager>();
builder.Services.AddScoped<IHaberDal, EfHaberDal>();

builder.Services.AddScoped<IInsaatProjeService, InsaatProjeManager>();
builder.Services.AddScoped<IInsaatProjeDal, EfInsaatProjeDal>();

builder.Services.AddScoped<IUrunKategoriService, UrunKategoriManager>();
builder.Services.AddScoped<IUrunKategoriDal, EfUrunKategoriDal>();

builder.Services.AddScoped<IUrunService, UrunManager>();
builder.Services.AddScoped<IUrunDal, EfUrunDal>();

builder.Services.AddScoped<ISayfaService, SayfaManager>();
builder.Services.AddScoped<ISayfaDal, EfSayfaDal>();

builder.Services.AddScoped<ITeklifService, TeklifManager>();
builder.Services.AddScoped<ITeklifDal, EfTeklifDal>();

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

app.UseCors("AllowAll");

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "hizmet",
    pattern: "hizmet/{slug}-{id:int}.html",
    defaults: new { controller = "Hizmet", action = "Detay" });

app.MapControllerRoute(
    name: "urunkategori",
    pattern: "urunkategori/{slug}-{id:int}.html",
    defaults: new { controller = "Urun", action = "KategoriDetay" });


app.MapControllerRoute(
    name: "urun",
    pattern: "urun/{slug}-{id:int}.html",
    defaults: new { controller = "Urun", action = "Detay" });

app.MapControllerRoute(
    name: "referans",
    pattern: "referans/{slug}-{id:int}.html",
    defaults: new { controller = "Referans", action = "Detay" });

app.MapControllerRoute(
    name: "sayfa",
    pattern: "sayfa/{slug}-{id:int}.html",
    defaults: new { controller = "Sayfa", action = "Index" });

app.MapControllerRoute(
    name: "hizmet",
    pattern: "hizmet/{slug}-{id:int}.html",
    defaults: new { controller = "Hizmet", action = "Index" });

app.MapControllerRoute(
    name: "haber-detay",
    pattern: "haber-detay/{slug}-{id:int}.html",
    defaults: new { controller = "Haber", action = "Detay" });

app.MapControllerRoute(
    name: "iletisim",
    pattern: "iletisim/{slug}.html",
    defaults: new { controller = "Iletisim", action = "Index" });

app.MapControllerRoute(
    name: "teklif",
    pattern: "teklif/{slug}.html",
    defaults: new { controller = "Teklif", action = "Index" });

app.MapControllerRoute(
    name: "anasayfa",
    pattern: "anasayfa/{slug}.html",
    defaults: new { controller = "Home", action = "Index" });

app.MapControllerRoute(
    name: "haber",
    pattern: "haber/{slug}.html",
    defaults: new { controller = "Haber", action = "Index" });

app.MapControllerRoute(
    name: "fiyatal",
    pattern: "fiyatal/{slug}.html",
    defaults: new { controller = "FiyatAl", action = "Index" });

app.MapControllerRoute(
    name: "referans",
    pattern: "referans/{slug}.html",
    defaults: new { controller = "Referans", action = "Index" });

app.MapControllerRoute(
    name: "proje-detay",
    pattern: "proje-detay/{slug}-{id:int}.html",
    defaults: new { controller = "Proje", action = "Detay" });

app.MapControllerRoute(
    name: "proje",
    pattern: "proje/{slug}.html",
    defaults: new { controller = "Proje", action = "Index" });

app.MapControllerRoute(
    name: "foto-galeri",
    pattern: "foto-galeri/{slug}.html",
    defaults: new { controller = "FotoGaleri", action = "Index" });

app.MapControllerRoute(
    name: "anasayfa",
    pattern: "anasayfa/{slug}.html",
    defaults: new { controller = "Home", action = "Index" });

app.MapControllerRoute(
    name: "fiyatal",
    pattern: "fiyatal/{slug}.html",
    defaults: new { controller = "FiyatAl", action = "Index" });

app.MapControllerRoute(
    name: "fiyataldesign",
    pattern: "fiyatal/fiyataldesign/design.html",
    defaults: new { controller = "FiyatAl", action = "Design" });

app.Run();
