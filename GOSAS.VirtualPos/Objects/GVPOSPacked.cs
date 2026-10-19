using GOSAS.VirtualPos.Core.Enums;
using System;
using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core.Objects
{
#pragma warning disable S101 // Types should be named in PascalCase

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class GVPOSPacked
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore()]
        public string RawRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore()]
        public string RawResponse { get; set; }


        /// <summary>
        /// Operation mode
        /// <para lang="tr">İşlem modu</para> 
        /// </summary>
        [XmlElement]
        [FormElement("mode")]
        public GVPOSRequestModes Mode { get; set; }

        /// <summary>
        /// API version used
        /// <para>Size 16 Byte alfanumeric</para> 
        /// <para lang="tr">Kullanılan api sürümü</para> 
        /// </summary>
        [XmlElement]
        [FormElement("apiversion")]
        public string Version { get; set; }

        /// <summary>
        /// Channel code
        /// <para>ChannelCode field must be one of 'A,R,S,O,P,D,T' chars.</para>
        /// <para>Size 1 Byte alfanumeric</para> 
        /// <para lang="tr">Kanal kodu.</para> 
        /// </summary>
        [XmlElement]
        public string ChannelCode { get; set; }

        /// <summary>
        /// Virtual pos validation parameters
        /// <para lang="tr">Sanal pos doğrulama parametreleri</para> 
        /// </summary>
        [XmlElement]
        public GVPOSTerminal Terminal { get; set; }

        /// <summary>
        /// Customer information
        /// <para lang="tr">Müşteri bilgileri</para> 
        /// </summary>
        [XmlElement]
        public GVPOSCustomer Customer { get; set; }

        /// <summary>
        /// Card information
        /// <para lang="tr">Kart bilgileri</para> 
        /// </summary>
        [XmlElement]
        public GVPOSCard Card { get; set; }

        /// <summary>
        /// Order information
        /// <para lang="tr">Sipariş bilgileri</para> 
        /// </summary>
        [XmlElement]
        public GVPOSOrder Order { get; set; }

        /// <summary>
        /// Transaction and financial information
        /// <para lang="tr">İşlem ve finansal bilgiler</para> 
        /// </summary>
        [XmlElement]
        public GVPOSTransaction Transaction { get; set; }

        /// <summary>
        /// For end-of-day inquiries
        /// <para lang="tr">Gün sonu sorgulamaları için</para> 
        /// </summary>
        [XmlElement]
        public GVPOSSettlementInq SettlementInq { get; set; }

    }

}
