using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Kurumsal.Core.Functions
{
    public static class SeoUrlGenerator
    {
        public static string GenerateSlug(string phrase)
        {

            if (phrase == null)
                return "";

            string str = phrase.ToLowerInvariant();

            // Türkçe karakterleri İngilizce karşılıklarına dönüştür
            str = str.Replace('ö', 'o').Replace('ç', 'c').Replace('ş', 's')
                     .Replace('ı', 'i').Replace('ğ', 'g').Replace('ü', 'u');

            // Kültürel özelliklere göre string'i normalize et
            str = RemoveDiacritics(str);

            // Geçersiz karakterleri kaldır
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");

            // Boşlukları ve ardışık tireleri tek tire ile değiştir
            str = Regex.Replace(str, @"\s+", " ").Trim();
            str = Regex.Replace(str, @"\s", "-");
            str = Regex.Replace(str, @"-+", "-");

            return str;
        }

        private static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
