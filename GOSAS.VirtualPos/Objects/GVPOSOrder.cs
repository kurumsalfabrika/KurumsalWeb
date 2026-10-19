using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase
    /// <summary>
    /// Order information
    /// </summary>
    [XmlType(AnonymousType = true)]
    public class GVPOSOrder
    {
        /// <summary>
        /// Unique order reference.
        /// It is automatically generate by the bank when it is not sent.
        /// <para>Size 36 Byte</para>
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [FormElement("orderid")]
        public string OrderID { get; set; }

        /// <summary>
        /// Used for reporting.
        /// <para>Size 36 Byte</para>
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [FormElement("ordergroupid")]
        public string GroupID { get; set; }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [FormElement("startdate")]
        public string StartDate { get; set; }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [FormElement("enddate")]
        public string EndDate { get; set; }

        /// <summary>
        /// Contain order items.
        /// If you want to see in the virtual pos screens can be filled.
        /// </summary>
        [XmlElement("ItemList", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPOSItemList ItemList { get; set; }

        /// <summary>
        /// Contain order addresses.
        /// <para>Used for reporting. If you want to see in the virtual pos screens can be filled.</para>
        /// </summary>
        [XmlElement("AddressList", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPOSAddressList AddressList { get; set; }

        /// <summary>
        /// For special field definations.
        /// <para>Used for reporting. If you want to see in the virtual pos screens can be filled.</para>
        /// <para>But the virtual pos must be sent in the defined and defined order in the screens.</para>
        /// </summary>
        [XmlElement("CommentList", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPOSCommentList CommentList { get; set; }

        /// <summary>
        /// Repetitive transaction information
        /// <para lang="tr">Tekrarlanan işlem bilgileri</para> 
        /// </summary>
        [XmlElement]
        public GVPOSRecurring Recurring { get; set; }

        /// <summary>
        /// Description
        /// <para lang="tr">Açıklama</para> 
        /// </summary>
        [XmlElement]
        [FormElement("orderdescription")]
        public string Description { get; set; }
    }
}