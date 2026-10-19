using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// Corporate payment inquiry
    /// <para lang="tr">Kurum ödeme sorgulaması</para> 
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class GVPOSUtilityPaymentInq : GVPOSTransactionInqBase
    {
    }
}