using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// Amount information for variable recurrent payment
    /// <para lang="tr">Değişken tekrarlayan ödeme için tutar bilgileri</para> 
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class GVPOSTransactionPaymentList : GVPOSPaymentListBase<GVPOSTransactionPayment>
    {
    }
}
