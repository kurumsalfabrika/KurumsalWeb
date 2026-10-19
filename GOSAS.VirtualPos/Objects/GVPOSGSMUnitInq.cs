using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// GSM money uploading, query processing parameters
    /// <para lang="tr">GSM para yükleme, sorgulama işlemi parametreleri</para> 
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class GVPOSGSMUnitInq : GVPOSTransactionInqBase
    {
        /// <summary>
        /// It contains information such as package ID, amount, and so on.
        /// <para>Size ? Byte alfanumeric</para> 
        /// <para lang="tr">Paket ID, tutar ve benzeri gibi bilgileri içerir.</para> 
        /// </summary>
        [XmlElement]
        [FormElement("gsmquantity")]
        public string Quantity { get; set; }
    }
}