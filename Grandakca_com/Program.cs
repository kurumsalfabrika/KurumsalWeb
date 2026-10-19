using Kurumsal.Business.Abstract;
using Kurumsal.Business.Concrete;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.FileProviders;
using SixLabors.ImageSharp.Web.Commands;
using SixLabors.ImageSharp.Web.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddImageSharp(options =>
{
    options.BrowserMaxAge = TimeSpan.FromDays(30);
}).ClearProcessors().SetRequestParser<QueryCollectionRequestParser>();
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRezervasyonService, RezervasyonManager>();
builder.Services.AddScoped<IRezervasyonDal, EfRezervasyonDal>();


builder.Services.AddScoped<IMarkaService, MarkaManager>();
builder.Services.AddScoped<IMarkaDal, EfMarkaDal>();

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

builder.Services.AddScoped<IBlogService, BlogManager>();
builder.Services.AddScoped<IBlogDal, EfBlogDal>();

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

app.MapStaticAssets();


app.MapControllerRoute(
    name: "anasayfa",
    pattern: "anasayfa/{slug}.html",
    defaults: new { controller = "Home", action = "Index" });

app.MapControllerRoute(
    name: "oda",
    pattern: "oda/{slug}.html",
    defaults: new { controller = "Oda", action = "Index" });

app.MapControllerRoute(
    name: "odalar",
    pattern: "odalar/{slug}.html",
    defaults: new { controller = "Oda", action = "Index" });

app.MapControllerRoute(
    name: "iletisim",
    pattern: "iletisim/{slug}.html",
    defaults: new { controller = "Iletisim", action = "Index" });

app.MapControllerRoute(
    name: "havuz",
    pattern: "havuz/{slug}.html",
    defaults: new { controller = "Havuz", action = "Index" });

app.MapControllerRoute(
    name: "blog",
    pattern: "blog/{slug}.html",
    defaults: new { controller = "Blog", action = "Index" });

app.MapControllerRoute(
    name: "sahil",
    pattern: "sahil/{slug}.html",
    defaults: new { controller = "Sahil", action = "Index" });

app.MapControllerRoute(
    name: "selinus-plaji",
    pattern: "selinus-plaji/{slug}.html",
    defaults: new { controller = "Sahil", action = "Index" });

app.MapControllerRoute(
    name: "yiyecek-icecek",
    pattern: "yiyecek-icecek/{slug}.html",
    defaults: new { controller = "Yiyecek", action = "Index" });

app.MapControllerRoute(
    name: "foto-galeri",
    pattern: "foto-galeri/{slug}.html",
    defaults: new { controller = "FotoGaleri", action = "Index" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapControllerRoute(
    name: "odadetay",
    pattern: "odadetay/{slug}-{id:int}.html",
    defaults: new { controller = "Oda", action = "OdaDetay" });

app.MapControllerRoute(
    name: "blogdetay",
    pattern: "blogdetay/{slug}-{id:int}.html",
    defaults: new { controller = "Blog", action = "BlogDetay" });


app.MapControllerRoute(
    name: "sayfa",
    pattern: "sayfa/{slug}-{id:int}.html",
    defaults: new { controller = "Sayfa", action = "Index" });

app.Run();
