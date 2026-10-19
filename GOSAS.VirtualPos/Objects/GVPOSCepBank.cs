using GOSAS.VirtualPos.Core.Enums;
using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// For CepBank operation information
    /// <para lang="tr">CepBank işlem bilgileri için</para> 
    /// </summary>
    [XmlType(AnonymousType =true)]
    public class GVPOSCepBank : GVPOSCepBankIng
    {
        /// <summary>
        /// Pay source type
        /// <para>Size 1 Byte alfanumeric</para> 
        /// <para lang="tr">Ödeme kaynağı tipi</para> 
        /// </summary>
        [XmlElement("PaymentType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified )]
        public GVPOSPaymentTypes PaymentType { get; set; }
    }
}