using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Enums
{
    [XmlType(AnonymousType = true)]
    public enum GVPOSAddressTypes
    {
        [XmlEnum("")]
        Unspecified,

        /// <summary>
        /// Billing
        /// <para lang="tr">Fatura</para> 
        /// </summary>
        [XmlEnum("B")]
        Billing,

        /// <summary>
        /// Shipping
        /// <para lang="tr">Teslim</para> 
        /// </summary>
        [XmlEnum("S")]
        Shipping
    }
}