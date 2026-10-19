namespace Kurumsal.Infrastructure.Tenancy
{
    public interface ITenantProvider
    {
        Guid? TenantId { get; }
    }
}
