using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Kurumsal.Entities.Enums
{
    public static class EnumHelper
    {
        public static List<KeyValuePair<byte, string>> GetEnumDescriptionList<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T))
                       .Cast<T>()
                       .Select(e => new KeyValuePair<byte, string>(
                           Convert.ToByte(e),
                           (e.GetType()
                              .GetField(e.ToString())
                              .GetCustomAttributes(typeof(DescriptionAttribute), false)
                              .FirstOrDefault() as DescriptionAttribute)?.Description ?? e.ToString()
                       ))
                       .ToList();
        }
    }
}
