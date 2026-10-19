using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// Customer information
    /// <para lang="tr">Müşteri bilgileri</para> 
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class GVPOSCustomer
    {
        /// <summary>
        /// Customer IP address
        /// <para>Size alfanumeric 20 Byte</para> 
        /// <para lang="tr">Müşteri IP Adresi</para> 
        /// </summary>
        [XmlElement]
        [FormElement("customeripaddress")]
        public string IPAddress { get; set; }

        /// <summary>
        /// Customer e-mail address
        /// <para>Size alfanumeric 64 Byte</para> 
        /// <para lang="tr">Müşteri e-posta adresi</para> 
        /// </summary>
        [XmlElement]
        [FormElement("customeremailaddress")]
        public string EmailAddress { get; set; }
    }
}