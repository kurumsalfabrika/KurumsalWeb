using System.Security.Cryptography;
using System.Text;
using GOSAS.VirtualPos.Core.Enums;

namespace GOSAS.VirtualPos.Core
{
#pragma warning disable S101 // Types should be named in PascalCase

    public static class GVPOSHelper
    {
        public static string Sha1(string text)
        {
            var provider = CodePagesEncodingProvider.Instance;
            Encoding.RegisterProvider(provider);

            var cryptoServiceProvider = new SHA1CryptoServiceProvider();
            var inputbytes = cryptoServiceProvider.ComputeHash(Encoding.GetEncoding("ISO-8859-9").GetBytes(text));

            var builder = new StringBuilder();
            for (int i = 0; i < inputbytes.Length; i++)
            {
                builder.Append(string.Format("{0,2:x}", inputbytes[i]).Replace(" ", "0"));
            }

            return builder.ToString().ToUpper();
        }

        public static string Sha512(string text)
        {
            var provider = CodePagesEncodingProvider.Instance;
            Encoding.RegisterProvider(provider);

            var cryptoServiceProvider = new SHA512CryptoServiceProvider();
            var inputbytes = cryptoServiceProvider.ComputeHash(Encoding.GetEncoding("ISO-8859-9").GetBytes(text));

            var builder = new StringBuilder();
            for (int i = 0; i < inputbytes.Length; i++)
            {
                builder.Append(string.Format("{0,2:x}", inputbytes[i]).Replace(" ", "0"));
            }

            return builder.ToString().ToUpper();
        }

        public static string ThreeDHashData(string terminalID, string orderID, string amount, GVPOSCurrencyCodes currencyCode, string successUrl, string errorUrl, string type, string installmentCount, string storeKey, string hashedPassword)
        {

            var sonuc = terminalID + orderID + amount + (int)currencyCode + successUrl + errorUrl + type + installmentCount + storeKey + hashedPassword;

            return GVPOSHelper.Sha512(terminalID + orderID + amount + (int)currencyCode + successUrl + errorUrl + type + installmentCount + storeKey + hashedPassword).ToUpper();
        }

        public static string IsRequireZero(string id, int complete)
        {
            var _tmp = id.Trim();

            if (_tmp.Length < complete)
                for (int i = 0; (i < (complete - _tmp.Length)); i++)
                    id = id.Insert(0, "0");

            return id;
        }
    }
}
