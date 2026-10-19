using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase
    /// <summary>
    /// 
    /// </summary>
    [XmlType(AnonymousType =true)]
    public class GVPOSVerification
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("Identity")]
        public string Identity { get; set; }
    }
}