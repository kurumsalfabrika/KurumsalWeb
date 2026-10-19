using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// Comment list
    /// </summary>
    [XmlType(AnonymousType = false)]
    public class GVPOSCommentList
    {
        /// <summary>
        /// Comment list
        /// </summary>
        [XmlElement("Comment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [FormElement("orderaddresscount")]
        public GVPOSComment[] Comment { get; set; }
    }
}