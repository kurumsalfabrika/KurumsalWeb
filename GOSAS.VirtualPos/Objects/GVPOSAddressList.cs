using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// Address list
    /// <para lang="tr">Adres listesi</para> 
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class GVPOSAddressList
    {
        /// <summary>
        /// Addresses
        /// <para lang="tr">Adresler</para> 
        /// </summary>
        [XmlElement("Address", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [FormElement("orderaddresscount")]
        public GVPOSAddress[] Address { get; set; }
    }
}