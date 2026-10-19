using GOSAS.VirtualPos.Core.Enums;
using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// Repetitive transaction information
    /// <para lang="tr">Tekrarlanan işlem bilgileri</para> 
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class GVPOSRecurring
    {

        /// <summary>
        /// Repeat type
        /// <para>Size alfanumeric 1 Byte</para> 
        /// <para lang="tr">Tekrarlama tipi</para>
        /// </summary>
        [XmlElement]
        public GVPOSRecurringTypes Type { get; set; }

        /// <summary>
        /// Total payment count
        /// <para>Size numeric 3 Byte</para> 
        /// <para lang="tr">Toplam ödeme sayısı</para> 
        /// </summary>
        [XmlElement]
        public ushort TotalPaymentNum { get; set; }

        /// <summary>
        /// Repeat frequency
        /// <para lang="tr">Tekrar sıklığı</para> 
        /// </summary>
        public GVPOSFrequencyTypes FrequencyType { get; set; }

        /// <summary>
        /// Recurrence frequency
        /// <para>Size 3 Byte</para> 
        /// <para>When 2 is given for <paramref name="FrequencyType"/> = <see cref="GVPOSFrequencyTypes.Weekly"/>, the pay is taken every 2 weeks.</para>
        /// <para lang="tr">Tekrarlama sıklığı sayısı</para>
        /// <para lang="tr"><paramref name="FrequencyType"/> = <see cref="GVPOSFrequencyTypes.Weekly"/> için, 2 değeri verildiğinde ödeme her 2 haftada bir alınır.</para> 
        /// </summary>
        public ushort FrequencyInterval { get; set; }

        /// <summary>
        /// First payment date.
        /// <para>Size 8 Byte, Format must be YYYYMMDD</para>
        /// <para lang="tr">İlk ödeme tarihi</para>
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// Amount information for variable recurrent payment
        /// <para lang="tr">Değişken tekrarlayan ödeme için tutar bilgileri</para> 
        /// </summary>
        [XmlElement("PaymentList", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPOSReccuringPaymentList PaymentList { get; set; }
    }
}