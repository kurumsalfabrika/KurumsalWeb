using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// Trading card transaction information
    /// As much as the installment number, it should be installment information.
    /// <para lang="tr">Ortak kart işlemleri bilgisi</para> 
    /// <para lang="tr">Taksit sayısı kadar vade bilgisi olmalıdır.</para> 
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class GVPOSCommercialCardExtendedCredit
    {
        /// <summary>
        /// Installment information
        /// <para lang="tr">Taksit bilgileri</para> 
        /// </summary>
        [XmlElement("PaymentList", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPOSTransactionPaymentList PaymentList { get; set; }
    }
}