using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// Amount information for recurring payment
    /// <para lang="tr">Ödeme için miktar bilgisi</para> 
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class GVPOSReccurringPayment : GVPOSPaymentBase
    {
        #region Just used for Reccurring

        /// <summary>
        /// Payment order number
        /// Beginning with 1, an increment is specified.
        /// <para lang="tr">
        /// </para>Ödeme sıra numarası
        /// 1 den başlayarak, bir artarak belirtilir.</summary>
        [XmlElement]
        public ushort PaymentNum { get; set; }

        #endregion
    }
}
