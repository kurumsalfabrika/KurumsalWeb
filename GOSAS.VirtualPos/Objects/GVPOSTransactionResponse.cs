using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase
    /// <summary>
    /// 
    /// </summary>
    [XmlType(AnonymousType =true)]
    public class GVPOSTransactionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public string SysErrMsg { get; set; }
    }
}