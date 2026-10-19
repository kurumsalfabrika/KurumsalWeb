using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// Amount information for transaction payment
    /// <para lang="tr">Ödeme için miktar bilgisi</para> 
    /// </summary>
    public class GVPOSTransactionPayment : GVPOSPaymentBase
    {
        #region Just used for Transaction

        /// <summary>
        /// Payment order number
        /// Beginning with 1, an increment is specified.
        /// <para>Size 2 Byte numeric</para> 
        /// <para lang="tr">
        /// </para>Ödeme sıra numarası
        /// 1 den başlayarak, bir artarak belirtilir.</summary>
        [XmlElement]
        public ushort Number { get; set; }

        /// <summary>
        /// Installment date
        /// <para>Size 8 Byte numeric, Format yyyyMMdd</para> 
        /// <para lang="tr">
        /// </para>Taksit tarihi</summary>
        [XmlElement]
        public string DueDate { get; set; }

        #endregion

    }
}
