using System;
using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// Response packed
    /// <para lang="tr">Cevap paketi</para> 
    /// </summary>
    [Serializable]
    [XmlRoot("GVPSResponse", Namespace = null)]
    [XmlInclude(typeof(GVPOSPacked))]
    public class GVPOSResponse : GVPOSPacked
    {
    }
}
