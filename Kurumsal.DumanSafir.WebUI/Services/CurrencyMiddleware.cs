public class CurrencyMiddleware
{
    private readonly RequestDelegate _next;

    public CurrencyMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if (context.Request.Cookies.TryGetValue("currency", out var currency))
        {
            context.Items["Currency"] = currency;
        }
        else
        {
            context.Items["Currency"] = "949"; // Default to TL
        }

        await _next(context);
    }
}

