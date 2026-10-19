using Kurumsal.Infrastructure.Context;
using Kurumsal.Infrastructure.Tenancy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        // 1) appsettings.json + appsettings.{ENV}.json + UserSecrets + ENV VARS
        var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";

        // Not: appsettings.json genelde WebAPI projesinde durur.
        // Factory sınıfı Infrastructure’da ise basePath’i WebAPI’ye kaydırıyoruz.
        var basePath = Directory.GetCurrentDirectory();
        var webApiPath = Path.Combine(basePath, "../Kurumsal.WebAPI"); // projenin adına göre düzelt

        var configBuilder = new ConfigurationBuilder()
            .SetBasePath(Directory.Exists(webApiPath) ? webApiPath : basePath)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
            .AddJsonFile($"appsettings.{env}.json", optional: true, reloadOnChange: false)
            .AddUserSecrets<AppDbContextFactory>(optional: true) // geliştirmede UserSecrets kullanıyorsan
            .AddEnvironmentVariables();

        var configuration = configBuilder.Build();
        var connStr = configuration.GetConnectionString("DefaultConnection")
                     ?? throw new InvalidOperationException("ConnectionStrings:DefaultConnection bulunamadı.");

        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

        // Migrations’ı bu assembly’de tutuyorsan (Infrastructure), migration assembly belirtebilirsin:
        optionsBuilder.UseSqlServer(connStr, b =>
        {
            b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName);
            b.EnableRetryOnFailure();
        });

        // Design-time’da tenant yok: null dönen provider
        ITenantProvider tenantProvider = new NullTenantProvider();

        return new AppDbContext(optionsBuilder.Options, tenantProvider);
    }

    private sealed class NullTenantProvider : ITenantProvider
    {
        public Guid? TenantId => null;
    }
}
