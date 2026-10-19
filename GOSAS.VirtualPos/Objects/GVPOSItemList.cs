using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// Contain for order items.
    /// <para lang="tr">Sipariş kalemlerini taşır</para> 
    /// </summary>
    [XmlType(AnonymousType=true)]
    public class GVPOSItemList
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("Item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [FormElement("orderitemcount")]
        public GVPOSItem[] Item { get; set; }
    }
}