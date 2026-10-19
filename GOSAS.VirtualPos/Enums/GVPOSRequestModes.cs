using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Enums
{
    [XmlType(AnonymousType = true)]
    public enum GVPOSRequestModes
    {

        [XmlEnum("")]
        Unspecified,

        /// <summary>
        /// Test
        /// </summary>
        [XmlEnum("TEST")]
        Test,

        /// <summary>
        /// Production
        /// <para lang="tr">Gerçek/Canlı/Üretim</para> 
        /// </summary>
        [XmlEnum("PROD")]
        Production
    }
}