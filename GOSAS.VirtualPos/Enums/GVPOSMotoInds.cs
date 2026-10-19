 using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Enums
{
    /// <summary>
    /// For ECommerce operations value is N. For Moto operations value is Y.
    /// <para lang="tr">E-ticaret operasyonları için değer N'dir. Moto işlemleri için değer Y'dir.</para> 
    /// </summary>
    [XmlType(AnonymousType = true)]
    public enum GVPOSMotoInds
    {
        /// <summary>
        /// Unspecified
        /// <para lang="tr">Belirtilmemiş</para> 
        /// </summary>
        [XmlEnum("")]
        Unspecified,

        /// <summary>
        /// E-Commerce operation
        /// <para>Stored value is N</para>
        /// <para lang="tr">E-ticaret işlemleri</para> 
        /// </summary>
        [XmlEnum("N")]
        ECommerce,

        /// <summary>
        /// Moto operations
        /// <para>Stored value is Y</para>
        /// <para lang="tr">Moto işlemler için</para> 
        /// </summary>
        [XmlEnum("Y")]
        Moto,

        /// <summary>
        /// Stored value is H
        /// </summary>
        [XmlEnum("H")]
        H
    }
}