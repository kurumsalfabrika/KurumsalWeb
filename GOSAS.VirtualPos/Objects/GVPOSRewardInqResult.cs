using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// 
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class GVPOSRewardInqResult
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("RewardList")]
        public GVPOSRewardList RewardList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("ChequeList")]
        public GVPOSChequeList ChequeList { get; set; }
    }
}