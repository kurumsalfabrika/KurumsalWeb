using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Enums
{
    [XmlType(AnonymousType = true)]
    public enum GVPOSRecurringTypes
    {
        /// <summary>
        /// Unspecified
        /// <para lang="tr">Belirtilmemiş</para> 
        /// </summary>
        [XmlEnum("")]
        Unspecified,

        /// <summary>
        /// Repetitive
        /// <para lang="tr">Tekrarlanan</para> 
        /// </summary>
        [XmlEnum("R")]
        Repetitive
    }
}