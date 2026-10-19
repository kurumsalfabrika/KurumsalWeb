using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// For CepBank reward inquiry
    /// <para lang="tr">CepBank bonus / ödül sorgulama için</para> 
    /// </summary>
    [XmlType(AnonymousType =true)]
    public class GVPOSCepBankIng
    {
        /// <summary>
        /// Cell phone number
        /// <para lang="tr">Cep telefonu numarası</para> 
        /// </summary>
        [XmlElement]
        public string GSMNumber { get; set; }
    }
}