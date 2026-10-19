using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml.Linq;

public interface ICurrencyService
{
    decimal ConvertToCurrency(decimal amount);
    string GetCurrencySymbol();
    Task<IDictionary<string, decimal>> GetExchangeRatesAsync(); // Yeni metod eklendi
}

public class CurrencyService : ICurrencyService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IDictionary<string, (decimal rate, string symbol)> _exchangeRates;
    private readonly string _tcmbUrl = "https://www.tcmb.gov.tr/kurlar/today.xml";

    public CurrencyService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
        _exchangeRates = new Dictionary<string, (decimal rate, string symbol)>
        {
            { "949", (1.0m, "TL") }, // TL
        };

        // Load exchange rates from TCMB
        LoadExchangeRates().Wait();
    }

    private async Task LoadExchangeRates()
    {
        using (var client = new HttpClient())
        {
            try
            {
            var response = await client.GetStringAsync(_tcmbUrl);
            var xdoc = XDocument.Parse(response);

            var usdRate = xdoc.Descendants("Currency")
                              .FirstOrDefault(x => (string)x.Attribute("CurrencyCode") == "USD")?
                              .Element("ForexBuying")?.Value;

            var eurRate = xdoc.Descendants("Currency")
                              .FirstOrDefault(x => (string)x.Attribute("CurrencyCode") == "EUR")?
                              .Element("ForexBuying")?.Value;

            var culture = new CultureInfo("tr-TR");
            if (decimal.TryParse(usdRate.Replace(".", ","), NumberStyles.Any, culture, out var usd))
            {
                _exchangeRates["840"] = (1 / usd, "USD"); // TL to USD conversion rate
            }

            if (decimal.TryParse(eurRate.Replace(".", ","), NumberStyles.Any, culture, out var eur))
            {
                _exchangeRates["978"] = (1 / eur, "EUR"); // TL to EUR conversion rate
            }
            }
            catch (Exception)
            {

  
            }

        }
    }

    public async Task<IDictionary<string, decimal>> GetExchangeRatesAsync()
    {
        var exchangeRates = new Dictionary<string, decimal>();

        using (var client = new HttpClient())
        {
            var response = await client.GetStringAsync(_tcmbUrl);
            var xdoc = XDocument.Parse(response);

            var usdRate = xdoc.Descendants("Currency")
                              .FirstOrDefault(x => (string)x.Attribute("CurrencyCode") == "USD")?
                              .Element("ForexBuying")?.Value;

            var eurRate = xdoc.Descendants("Currency")
                              .FirstOrDefault(x => (string)x.Attribute("CurrencyCode") == "EUR")?
                              .Element("ForexBuying")?.Value;

            var culture = new CultureInfo("tr-TR");
            if (decimal.TryParse(usdRate.Replace(".", ","), NumberStyles.Any, culture, out var usd))
            {
                exchangeRates["USD"] = usd;
            }

            if (decimal.TryParse(eurRate.Replace(".", ","), NumberStyles.Any, culture, out var eur))
            {
                exchangeRates["EUR"] = eur;
            }
        }

        return exchangeRates;
    }

    public decimal ConvertToCurrency(decimal amount)
    {
        var selectedCurrency = _httpContextAccessor.HttpContext?.Items["Currency"] as string ?? "949";
        if (_exchangeRates.TryGetValue(selectedCurrency, out var rateInfo))
        {
            return amount * rateInfo.rate;
        }
        return amount;
    }

    public string GetCurrencySymbol()
    {
        var selectedCurrency = _httpContextAccessor.HttpContext?.Items["Currency"] as string ?? "949";
        if (_exchangeRates.TryGetValue(selectedCurrency, out var rateInfo))
        {
            return rateInfo.symbol;
        }
        return "TL";
    }
}


