using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// Host message list
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class GVPOSHostMsgList
    {
        /// <summary>
        /// Host messages
        /// </summary>
        [XmlElement("HostMsg", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] HostMsg { get; set; }
    }
}