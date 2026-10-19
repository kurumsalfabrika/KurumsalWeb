using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// The field where the prize related transactions are sent.
    /// <para lang="tr">Ödül ile ilgili işlemlerin yollanıldığı alandır.</para> 
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class GVPOSRewardList
    {
        /// <summary>
        /// Bonus winnings, Bonus Usage, MR, Company Bonus, Field where the company check transactions are sent.
        /// <para lang="tr">Bonus kazanım, Bonus Kullanım, MR, Firma Bonus, Firma Çek işlemlerinin gönderildiği alandır.</para>
        /// </summary>
        [XmlElement("Reward", Form =System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPOSRewardRequest[] Reward { get; set; }
    }
}