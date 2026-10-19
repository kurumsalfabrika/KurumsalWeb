using System;

namespace Kurumsal.WebUI.TagHelpers
{
    public static class TimeConvertHelper
    {
        public static string TimeAgo(DateTime dt)
        {
            TimeSpan span = DateTime.Now - dt;

            if (span.Days > 365)
            {
                int years = (span.Days / 365);
                return $"{years} {(years == 1 ? "yıl" : "yıl")} önce";
            }
            else if (span.Days > 30)
            {
                int months = (span.Days / 30);
                return $"{months} {(months == 1 ? "ay" : "ay")} önce";
            }
            else if (span.Days > 0)
            {
                return $"{span.Days} {(span.Days == 1 ? "gün" : "gün")} önce";
            }
            else if (span.Hours > 0)
            {
                return $"{span.Hours} {(span.Hours == 1 ? "saat" : "saat")} önce";
            }
            else if (span.Minutes > 0)
            {
                return $"{span.Minutes} {(span.Minutes == 1 ? "dakika" : "dakika")} önce";
            }
            else
            {
                return "Birkaç saniye önce";
            }
        }

    }
}
