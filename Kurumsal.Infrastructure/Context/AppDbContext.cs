using Kurumsal.Domain.Entities;
using Kurumsal.Domain.Entities.Base;
using Kurumsal.Infrastructure.Seed;
using Kurumsal.Infrastructure.Tenancy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Kurumsal.Infrastructure.Context
{
    // AppRole eklendi!
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        private readonly ITenantProvider _tenantProvider;
        private readonly bool _tenantEnabled;
        private readonly Guid _tenantId;
        

        public AppDbContext(DbContextOptions<AppDbContext> options, ITenantProvider tenantProvider)
            : base(options)
        {
            _tenantProvider = tenantProvider;
            var t = _tenantProvider?.TenantId;
            _tenantEnabled = t.HasValue;
            _tenantId = t ?? Guid.Empty;
        }

        public DbSet<Ulke> Ulkeler { get; set; } = null!;
        public DbSet<Sehir> Sehirler { get; set; } = null!;
        public DbSet<Ilce> Ilceler { get; set; } = null!;
        public DbSet<Sektor> Sektorler { get; set; } = null!;
        public DbSet<Doviz> Dovizler { get; set; } = null!;
        public DbSet<Tenant> Tenantler { get; set; } = null!;
        public DbSet<RefreshToken> RefreshTokens => Set<RefreshToken>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<RefreshToken>(b =>
            {
                b.ToTable("RefreshTokens");
                b.HasKey(x => x.Id);
                b.Property(x => x.TokenHash).IsRequired().HasMaxLength(128);
                b.HasIndex(x => x.TokenHash).IsUnique();
                b.Property(x => x.CreatedAtUtc).IsRequired();
                b.Property(x => x.ExpiresAtUtc).IsRequired();

                b.HasOne<AppUser>()
                 .WithMany() // veya .WithMany(u => u.RefreshTokens)
                 .HasForeignKey(x => x.UserId)
                 .OnDelete(DeleteBehavior.Cascade);
            });

            // Tenantlı entity’ler
            SetTenantFilter<Doviz>(modelBuilder);
            // Kullanıcı & rol için de tenant filtresi
            modelBuilder.Entity<AppUser>().HasQueryFilter(u => !_tenantEnabled || u.TenantId == _tenantId);
            modelBuilder.Entity<AppRole>().HasQueryFilter(r => !_tenantEnabled || r.TenantId == _tenantId);

            // Tenant’sız entity’ler (soft delete)
            SetSoftDeleteFilter<Ulke>(modelBuilder);
            SetSoftDeleteFilter<Sehir>(modelBuilder);
            SetSoftDeleteFilter<Ilce>(modelBuilder);
            SetSoftDeleteFilter<Sektor>(modelBuilder);
            SetSoftDeleteFilter<Tenant>(modelBuilder);

            // Seed'ler
            UlkeSeedData.Seed(modelBuilder);
            SehirSeedData.Seed(modelBuilder);
            IlceSeedData.Seed(modelBuilder);
            SektorSeedData.Seed(modelBuilder);
            TenantSeedData.Seed(modelBuilder);
            DovizSeedData.Seed(modelBuilder);
        }

        private static void SetSoftDeleteFilter<TEntity>(ModelBuilder b) where TEntity : BaseEntity
            => b.Entity<TEntity>().HasQueryFilter(e => !e.IsDeleted);

        private void SetTenantFilter<TEntity>(ModelBuilder b) where TEntity : BaseTenantEntity
            => b.Entity<TEntity>().HasQueryFilter(e => !e.IsDeleted && (!_tenantEnabled || e.TenantId == _tenantId));

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            if (_tenantEnabled)
            {
                foreach (var e in ChangeTracker.Entries<BaseTenantEntity>().Where(x => x.State == EntityState.Added))
                    e.Entity.TenantId = _tenantId;

                // AppUser eklenirken TenantId boş kalmasın
                foreach (var u in ChangeTracker.Entries<AppUser>().Where(x => x.State == EntityState.Added))
                    u.Entity.TenantId = _tenantId;
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
