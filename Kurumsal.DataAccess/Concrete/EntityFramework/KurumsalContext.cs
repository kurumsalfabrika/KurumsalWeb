using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Kurumsal.DataAccess.Concrete.EntityFramework
{
    public class KurumsalContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

          //  optionsBuilder.UseSqlServer(@"Server=.;DataBase=Test;Trusted_Connection=true;TrustServerCertificate=true");
            // optionsBuilder.UseSqlServer(@"Server=DESKTOP-PIQCR63\SQLEXPRESS;DataBase=KurumsalMuhasebe;Trusted_Connection=true");
            //  optionsBuilder.UseSqlServer(@"Server=www.enerjiab.com\MSSQLSERVER2016; Database = mikron; User Id = mikron; Password = fc263066K!;");
            //   optionsBuilder.UseSqlServer(@"Server=www.kurumsalfabrika.com.tr\MSSQLSERVER2017; Database = KURUMSAL; User Id = KURUMSAL; Password = fc263066K!;");
        //  optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = KURUMSALPORTAL; User Id = KURUMSALPORTAL; Password = fc263066K!;TrustServerCertificate=true");
      //  optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = DUMANSAFIR; User Id = DUMANSAFIR; Password = fc263066K!;TrustServerCertificate=true");
       //   optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = AYDOGANTEKNIK; User Id = AYDOGANTEKNIK; Password = fc263066K!;TrustServerCertificate=true");
       //   optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = UFUKBACA; User Id = UFUKBACA; Password = fc263066K!;TrustServerCertificate=true");
       //  optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = 3ASOSGB; User Id = 3ASOSGB; Password = fc263066K!;TrustServerCertificate=true");
      //   optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = KIRILMAZLAR2025; User Id = KIRILMAZLAR2025; Password = fc263066K!;TrustServerCertificate=true");
       //   optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = ARIKVIDANJOR; User Id = ARIKVIDANJOR; Password = fc263066K!;TrustServerCertificate=true");
       //   optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = METSIS; User Id = METSIS; Password = fc263066K!;TrustServerCertificate=true");
       ////   optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = CARITA; User Id = CARITA; Password = fc263066K!;TrustServerCertificate=true");
       //   optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = GOKHANERASLAN; User Id = GOKHANERASLAN; Password = fc263066K!;TrustServerCertificate=true");
       //   optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = GRANDAKCA; User Id = GRANDAKCA; Password = fc263066K!;TrustServerCertificate=true");
      //    optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = EVONOTEL; User Id = EVONOTEL; Password = fc263066K!;TrustServerCertificate=true");
       //   optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = OKAYNUSECZA; User Id = OKYANUSECZA; Password = fc263066K!;TrustServerCertificate=true");
         optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = YAZICIOGLU; User Id = YAZICIOGLU; Password = yo263066K!;TrustServerCertificate=true");
      //    optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = AGWEB2026; User Id = AGWEB2026; Password = fc263066K!;TrustServerCertificate=true");
      //    optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = 3ASOSGB2025; User Id = 3ASOSGB2025; Password = fc263066K!;TrustServerCertificate=true");
     //    optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = SODEMCANTA; User Id = SODEMCANTA; Password = fc263066K!;TrustServerCertificate=true");
        //  optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = SURBIMS; User Id = SURBIMS; Password = fc263066K!;TrustServerCertificate=true");
     //     optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = MELBEY; User Id = MELBEY; Password = fc263066K!;TrustServerCertificate=true");
      //     optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = KURUMSALTICARI; User Id = KURUMSALTICARI; Password = fc263066K!;TrustServerCertificate=true");
        }
        public DbSet<InsaatProje> InsaatProje { get; set; }
        public DbSet<Yorum> Yorum { get; set; }
        public DbSet<Teklif> Teklif { get; set; }
        public DbSet<Marka> Marka { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartItem> CartItem { get; set; }
        public DbSet<Rezervasyon> Rezervasyon { get; set; }
        public DbSet<Oda> Oda { get; set; }
        public DbSet<OdaKategori> OdaKategori { get; set; }
        public DbSet<Portfolyo> Portfolyo { get; set; }
        public DbSet<PortfolyoKategori> PortfolyoKategori { get; set; }
        public DbSet<SiteAyar> SiteAyar { get; set; }
        public DbSet<SosyalMedyaAdres> SosyalMedyaAdres { get; set; }
        public DbSet<Sayfa> Sayfa { get; set; }
        public DbSet<SayfaKategori> SayfaKategori { get; set; }
        public DbSet<Ftp> Ftp { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<HaberKategori> HaberKategori { get; set; }
        public DbSet<SSSKategori> SSSKategori { get; set; }
        public DbSet<Haber> Haber { get; set; }
        public DbSet<IletisimAyar> IletisimAyar { get; set; }
        public DbSet<Mesaj> Mesaj { get; set; }
        public DbSet<AcilirMesaj> AcilirMesaj { get; set; }
        public DbSet<ApiAyar> ApiAyar { get; set; }
        public DbSet<BankaHesap> BankaHesap { get; set; }
        public DbSet<Belge> Belge { get; set; }
        public DbSet<Ekip> Ekip { get; set; }
        public DbSet<FotoGaleri> FotoGaleri { get; set; }
        public DbSet<Fotograf> Fotograf { get; set; }
        public DbSet<GenelAyar> GenelAyar { get; set; }
        public DbSet<Hizmet> Hizmet { get; set; }
        public DbSet<Katalog> Katalog { get; set; }
        public DbSet<KatalogKategori> KatalogKategori { get; set; }
        public DbSet<MailAyar> MailAyar { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Paket> Paket { get; set; }
        public DbSet<Proje> Proje { get; set; }
        public DbSet<ProjeKategori> ProjeKategori { get; set; }
        public DbSet<Referans> Referans { get; set; }
        public DbSet<Rehber> Rehber { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<SMSAyar> SMSAyar { get; set; }
        public DbSet<SosyalMedyaAyar> SosyalMedyaAyar { get; set; }
        public DbSet<SSS> SSS { get; set; }
        public DbSet<Sube> Sube { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<UrunKategori> UrunKategori { get; set; }
        public DbSet<VideoGaleri> VideoGaleri { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Rezervasyon>()
            .Property(r => r.GunlukUcret)
            .HasColumnType("decimal(18, 4)");

            modelBuilder.Entity<Rezervasyon>()
                        .Property(r => r.ToplamTutar)
                        .HasColumnType("decimal(18, 4)");

            modelBuilder.Entity<Haber>()
                .HasOne(h => h.HaberKategori)
                .WithMany(k => k.Haberler)
                .HasForeignKey(h => h.HaberKategoriId)
                .OnDelete(DeleteBehavior.SetNull);



			modelBuilder.Entity<Sayfa>()
                .HasOne(h => h.SayfaKategori)
                .WithMany(k => k.Sayfalar)
                .HasForeignKey(h => h.SayfaKategoriId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Portfolyo>()
                .HasOne(h => h.PortfolyoKategori)
                .WithMany(k => k.Portfolyolar)
                .HasForeignKey(h => h.PortfolyoKategoriId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<CartItem>()
                       .HasOne(ci => ci.Cart)
                       .WithMany(c => c.CartItems)
                       .HasForeignKey(ci => ci.CartId);

            // Configuring decimal properties
            modelBuilder.Entity<Cart>()
                .Property(c => c.GenelToplam)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Cart>()
                .Property(c => c.KdvTutari)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Cart>()
                .Property(c => c.ToplamTutar)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<CartItem>()
                .Property(ci => ci.Miktar)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<CartItem>()
                .Property(ci => ci.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<CartItem>()
                .Property(ci => ci.SatirToplami)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<CartItem>()
                .Property(ci => ci.KdvTutari)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Urun>()
                .HasOne(h => h.UrunKategori)
                .WithMany(k => k.Urunler)
                .HasForeignKey(h => h.UrunKategoriId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Oda>()
                .HasOne(h => h.OdaKategori)
                .WithMany(k => k.Odalar)
                .HasForeignKey(h => h.OdaKategoriId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Oda>()
                .HasOne(h => h.FotoGaleri)
                .WithMany(k => k.Odalar)
                .HasForeignKey(h => h.FotoGaleriId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<SSS>()
                .HasOne(h => h.SSSKategori)
                .WithMany(k => k.SSSLer)
                .HasForeignKey(h => h.SSSKategoriId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Paket>()
                .Property(p => p.Fiyat)
                .HasColumnType("decimal(18, 4)");

            modelBuilder.Entity<Urun>()
                .Property(u => u.Fiyat)
                .HasColumnType("decimal(18, 4)");

            modelBuilder.Entity<Urun>()
                .Property(u => u.IndirimliFiyat)
                .HasColumnType("decimal(18, 4)");

            modelBuilder.Entity<Oda>()
                .Property(u => u.GunlukUcret)
                .HasColumnType("decimal(18, 4)");
            modelBuilder.Entity<Oda>()
                .Property(u => u.GunlukUcret1)
                .HasColumnType("decimal(18, 4)");
            modelBuilder.Entity<Oda>()
                .Property(u => u.GunlukUcret2)
                .HasColumnType("decimal(18, 4)");
            modelBuilder.Entity<Oda>()
                .Property(u => u.GunlukUcret3)
                .HasColumnType("decimal(18, 4)");

			modelBuilder.Entity<UrunKategori>()
	        .HasOne(uk => uk.UstKategori)
	        .WithMany(uk => uk.AltKategoriler)
	        .HasForeignKey(uk => uk.UstKategoriId)
	        .OnDelete(DeleteBehavior.NoAction); // Prevents cascading delete

			modelBuilder.Entity<Urun>()
				.HasOne(u => u.UrunKategori)
				.WithMany(k => k.Urunler)
				.HasForeignKey(u => u.UrunKategoriId)
				.OnDelete(DeleteBehavior.SetNull); // Sets foreign key to null on delete
		}
    }
}
