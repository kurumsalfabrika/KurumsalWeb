using System;
using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// Request packed
    /// <para lang="tr">İstek paketi</para> 
    /// </summary>
    [Serializable]
    [XmlRoot("GVPSRequest", Namespace = null)]
    [XmlInclude(typeof(GVPOSPacked))]
    public class GVPOSRequest : GVPOSPacked
    {
    }

}
