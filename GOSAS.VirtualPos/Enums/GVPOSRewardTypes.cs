using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Enums
{
    /// <summary>
    /// Prize type
    /// <para lang="tr">Ödül tipi</para>
    /// <para>Alfanumeric</para> 
    /// </summary>
    [XmlType(AnonymousType = true)]
    public enum GVPOSRewardTypes
    {
        [XmlEnum("")]
        Unspecified,

        /// <summary>
        /// BONUS Puan
        /// </summary>
        [XmlEnum("BNS")]
        BNS,

        /// <summary>
        /// FBB Puan
        /// </summary>
        [XmlEnum("FBB")]
        FBB
    }
}