using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// 
    /// </summary>
    [XmlType(AnonymousType = true)]
    public abstract class GVPOSTransactionInqBase
    {
        /// <summary>
        /// Corporate code
        /// <para>Size 3 Byte numeric</para>
        /// <para lang="tr">Kurum kodu</para> 
        /// </summary>
        [XmlElement]
        public ushort InstitutionCode { get; set; }


        /// <summary>
        /// Subscriber code
        /// <para>Size ? Byte alfanumeric</para>
        /// <para lang="tr">Abone / tesisat numarası</para> 
        /// </summary>
        [XmlElement]
        [FormElement("utilitypaysubscode")]
        public string SubscriberCode { get; set; }
    }
}