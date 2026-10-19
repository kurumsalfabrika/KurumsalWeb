using Kurumsal.Business.Abstract;
using Kurumsal.Business.Concrete;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.DataAccess.Concrete.EntityFramework;
using Kurumsal.WebUI.Context;
using Kurumsal.WebUI.Controllers;
using Kurumsal.WebUI.CustomValidator;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.IO;

namespace Kurumsal.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddMvc(options =>
            {
                options.Filters.Add(new IgnoreAntiforgeryTokenAttribute());
            });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<ImageController, ImageController>();
      
            services.AddScoped<ISiteAyarService, SiteAyarManager>();
            services.AddScoped<ISiteAyarDal, EfSiteAyarDal>();

            services.AddScoped<IRezervasyonService, RezervasyonManager>();
            services.AddScoped<IRezervasyonDal, EfRezervasyonDal>();
      

            services.AddScoped<IInsaatProjeService, InsaatProjeManager>();
            services.AddScoped<IInsaatProjeDal, EfInsaatProjeDal>();
      
            services.AddScoped<IMarkaService, MarkaManager>();
            services.AddScoped<IMarkaDal, EfMarkaDal>();
            
            services.AddScoped<ITeklifService, TeklifManager>();
            services.AddScoped<ITeklifDal, EfTeklifDal>();
      
            services.AddScoped<IIletisimService, IletisimManager>();
            services.AddScoped<IIletisimDal, EfIletisimDal>();
      
            services.AddScoped<IPortfolyoService, PortfolyoManager>();
            services.AddScoped<IPortfolyoDal, EfPortfolyoDal>();
      
            services.AddScoped<IReferansService, ReferansManager>();
            services.AddScoped<IReferansDal, EfReferansDal>();
      
            services.AddScoped<IYorumService, YorumManager>();
            services.AddScoped<IYorumDal, EfYorumDal>();
      
            services.AddScoped<IPortfolyoKategoriService, PortfolyoKategoriManager>();
            services.AddScoped<IPortfolyoKategoriDal, EfPortfolyoKategoriDal>();

            services.AddScoped<IFtpService, FtpManager>();
            services.AddScoped<IFtpDal, EfFtpDal>();

            services.AddScoped<ISosyalMedyaAdresService, SosyalMedyaAdresManager>();
            services.AddScoped<ISosyalMedyaAdresDal, EfSosyalMedyaAdresDal>();

            services.AddScoped<IAcilirMesajService, AcilirMesajManager>();
            services.AddScoped<IAcilirMesajDal, EfAcilirMesajDal>();

            services.AddScoped<IMesajService, MesajManager>();
            services.AddScoped<IMesajDal, EfMesajDal>();
           
            services.AddScoped<IApiAyarService, ApiAyarManager>();
            services.AddScoped<IApiAyarDal, EfApiAyarDal>();
                       
            services.AddScoped<ISSSService, SSSManager>();
            services.AddScoped<ISSSDal, EfSSSDal>();
           
            services.AddScoped<IBankaHesapService, BankaHesapManager>();
            services.AddScoped<IBankaHesapDal, EfBankaHesapDal>();
           
            services.AddScoped<IBelgeService, BelgeManager>();
            services.AddScoped<IBelgeDal, EfBelgeDal>();
           
            services.AddScoped<IBildirimSablonService, BildirimSablonManager>();
            services.AddScoped<IBildirimSablonDal, EfBildirimSablonDal>();
           
            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBlogDal, EfBlogDal>();
           
            services.AddScoped<IEkipService, EkipManager>();
            services.AddScoped<IEkipDal, EfEkipDal>();

            services.AddScoped<IFotoGaleriService, FotoGaleriManager>();
            services.AddScoped<IFotoGaleriDal, EfFotoGaleriDal>();
             
            services.AddScoped<IFotografService, FotografManager>();
            services.AddScoped<IFotografDal, EfFotografDal>();
             
            services.AddScoped<IGenelAyarService, GenelAyarManager>();
            services.AddScoped<IGenelAyarDal, EfGenelAyarDal>();
             
            services.AddScoped<IHizmetService, HizmetManager>();
            services.AddScoped<IHizmetDal, EfHizmetDal>();
             
            services.AddScoped<IIletisimAyarService, IletisimAyarManager>();
            services.AddScoped<IIletisimAyarDal, EfIletisimAyarDal>();
             
            services.AddScoped<IKatalogService, KatalogManager>();
            services.AddScoped<IKatalogDal, EfKatalogDal>();

            services.AddScoped<IKatalogKategoriService, KatalogKategoriManager>();
            services.AddScoped<IKatalogKategoriDal, EfKatalogKategoriDal>();
             
            services.AddScoped<IMailAyarService, MailAyarManager>();
            services.AddScoped<IMailAyarDal, EfMailAyarDal>();

            services.AddScoped<IMenuService, MenuManager>();
            services.AddScoped<IMenuDal, EfMenuDal>();
             
            services.AddScoped<IPaketService, PaketManager>();
            services.AddScoped<IPaketDal, EfPaketDal>();
             
            services.AddScoped<IProjeService, ProjeManager>();
            services.AddScoped<IProjeDal, EfProjeDal>();
             
            services.AddScoped<IReferansService, ReferansManager>();
            services.AddScoped<IReferansDal, EfReferansDal>();
             
            services.AddScoped<IRehberService, RehberManager>();
            services.AddScoped<IRehberDal, EfRehberDal>();
             
            services.AddScoped<ISayfaService, SayfaManager>();
            services.AddScoped<ISayfaDal, EfSayfaDal>();
             
            services.AddScoped<ISayfaKategoriService, SayfaKategoriManager>();
            services.AddScoped<ISayfaKategoriDal, EfSayfaKategoriDal>();
            
            services.AddScoped<ISliderService, SliderManager>();
            services.AddScoped<ISliderDal, EfSliderDal>();
            
            services.AddScoped<ISMSAyarService, SMSAyarManager>();
            services.AddScoped<ISMSAyarDal, EfSMSAyarDal>();
            
            services.AddScoped<ISosyalMedyaAyarService, SosyalMedyaAyarManager>();
            services.AddScoped<ISosyalMedyaAyarDal, EfSosyalMedyaAyarDal>();
            
            services.AddScoped<ISSSKategoriService, SSSKategoriManager>();
            services.AddScoped<ISSSKategoriDal, EfSSSKategoriDal>();
            
            services.AddScoped<ISubeService, SubeManager>();
            services.AddScoped<ISubeDal, EfSubeDal>();
            
            services.AddScoped<ISosyalMedyaAyarService, SosyalMedyaAyarManager>();
            services.AddScoped<ISosyalMedyaAyarDal, EfSosyalMedyaAyarDal>();
                        
            services.AddScoped<ISubeService, SubeManager>();
            services.AddScoped<ISubeDal, EfSubeDal>();
            
            services.AddScoped<IUrunService, UrunManager>();
            services.AddScoped<IUrunDal, EfUrunDal>();
            
            services.AddScoped<IUrunKategoriService, UrunKategoriManager>();
            services.AddScoped<IUrunKategoriDal, EfUrunKategoriDal>();
            
            services.AddScoped<IVideoGaleriService, VideoGaleriManager>();
            services.AddScoped<IVideoGaleriDal, EfVideoGaleriDal>();
            
            services.AddScoped<IHaberKategoriService, HaberKategoriManager>();
            services.AddScoped<IHaberKategoriDal, EfHaberKategoriDal>();
            
            services.AddScoped<IHaberService, HaberManager>();
            services.AddScoped<IHaberDal, EfHaberDal>();
            
            services.AddScoped<IOdaKategoriService, OdaKategoriManager>();
            services.AddScoped<IOdaKategoriDal, EfOdaKategoriDal>();
            
            services.AddScoped<IOdaService, OdaManager>();
            services.AddScoped<IOdaDal, EfOdaDal>();
            
            services.AddDbContext<IdentityContext>();

            services.AddIdentity<AppUser, AppRole>(opt =>
            {
                opt.Password.RequireDigit = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireDigit = false;
                opt.Password.RequiredLength = 6;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireUppercase = false;
                opt.SignIn.RequireConfirmedEmail = true;
            }).AddErrorDescriber<CustomIdentityValidator>().AddPasswordValidator<CustomPasswordValidator>().AddEntityFrameworkStores<IdentityContext>();
            //services.ConfigureApplicationCookie(opt =>
            //{
            //    opt.LoginPath = new Microsoft.AspNetCore.Http.PathString("/User/Login");
            //    opt.Cookie.HttpOnly = true;
            //    opt.Cookie.Name = "Kurumsal";
            //    opt.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict; // eriþim subdomainler dahil hiçbiri eriþemez.
            //    opt.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest; //http ve https
            //    opt.ExpireTimeSpan = TimeSpan.FromDays(30);
            //});

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/User/Login";
                options.AccessDeniedPath = "/User/AccessDenied"; // Eriþim reddedildi sayfasý
                options.ExpireTimeSpan = TimeSpan.FromDays(30);
            });

            services.AddRazorPages();
        }
        private void InitializeDatabase(IApplicationBuilder app, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            // Uygulama baþlatýldýðýnda veritabaný seed iþlemini tetikle
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var scopedUserManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                var scopedRoleManager = scope.ServiceProvider.GetRequiredService<RoleManager<AppRole>>();
                IdentityDataInitializer.SeedData(scopedUserManager, scopedRoleManager).Wait();
            }
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {

            InitializeDatabase(app, userManager, roleManager);

            var filePath = Path.Combine(env.ContentRootPath, "Files");
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(filePath),
                RequestPath = "/Files"
            });


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
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
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Dashboard}/{action=Index}/{id?}");
            });
        }
    }
}
