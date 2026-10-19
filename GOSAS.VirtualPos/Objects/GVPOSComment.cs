 using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// Order comment
    /// <para lang="tr">Sipariş yorumu</para> 
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class GVPOSComment
    {

        /// <summary>
        /// Comment no
        /// <para>But the virtual pos must be sent in the defined and defined order in the screens.</para>
        /// <para lang="tr">Ancak sanal pos ekranlarda tanımlı ve tanımlı sıra ile gönderilmelidir.</para>
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [FormElement("ordercommentnumber")]
        public uint Number { get; set; }


        /// <summary>
        /// Comment
        /// <para>Size 20 Byte</para>
        /// <para lang="tr">Yorum</para>
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [FormElement("ordercommenttext")]
        public string Text { get; set; }
    }
}