namespace Kurumsal.DumanSafir.WebUI.TagHelpers
{
    public class IPAddressMiddleware
    {
        private readonly RequestDelegate _next;

        public IPAddressMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var ipAddress = httpContext.Connection.RemoteIpAddress;
            var path = httpContext.Request.Path;

            Console.WriteLine($"Request path: {path}, IP Address: {ipAddress}");

            try
            {

            await _next(httpContext);
            }
            catch (Exception)
            {

            }

        }
    }
}
