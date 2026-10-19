using Microsoft.AspNetCore.Http;

namespace Kurumsal.Infrastructure.Tenancy
{
    public sealed class HttpTenantProvider : ITenantProvider
    {
        private readonly IHttpContextAccessor _http;
        public HttpTenantProvider(IHttpContextAccessor http) => _http = http;

        public Guid? TenantId
        {
            get
            {
                // Tercih 1: JWT claim
                var claim = _http.HttpContext?.User?.FindFirst("tenant_id")?.Value;
                // Tercih 2: Header (X-Tenant-Id)
                claim ??= _http.HttpContext?.Request.Headers["X-Tenant-Id"].FirstOrDefault();
                return Guid.TryParse(claim, out var id) ? id : (Guid?)null;
            }
        }
    }
}
