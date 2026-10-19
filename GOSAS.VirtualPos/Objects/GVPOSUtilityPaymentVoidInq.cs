using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// Corporate payment cancellation inquiry
    /// <para lang="tr">Kurumsal ödeme iptali sorgusu</para> 
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class GVPOSUtilityPaymentVoidInq : GVPOSTransactionInqBase 
    {
    }
}