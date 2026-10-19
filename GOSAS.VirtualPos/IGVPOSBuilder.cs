using System;
using GOSAS.VirtualPos.Core.Enums;
using GOSAS.VirtualPos.Core.Objects;

namespace GOSAS.VirtualPos.Core
{
#pragma warning disable S101 // Types should be named in PascalCase
    public interface IGVPOSBuilder
#pragma warning restore S101 // Types should be named in PascalCase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="posUrl"></param>
        /// <param name="mode">TEST, PROD</param>
        /// <returns></returns>
        IGVPOSBuilder Environment(string posUrl);

        /// <summary>
        /// İşlemler Test sunucusuna yönlendirilir.
        /// </summary>
        /// <returns></returns>
        IGVPOSBuilder Test(bool isTest = true);

        /// <summary>
        /// Firma bilgileri
        /// </summary>
        /// <param name="terminalId"></param>
        /// <param name="MerchantID"></param>
        /// <param name="userID"></param>
        /// <param name="userPassword"></param>
        /// <returns></returns>
        IGVPOSBuilder Company(string terminalId, string MerchantID, string userID, string userPassword, string SubMerchantID = null);

        /// <summary>
        /// Müşteri Bilgileri
        /// </summary>
        /// <param name="customerMail">Müşteri eposta adresi</param>
        /// <param name="customerIP">Müşterinin IP adresi</param>
        /// <returns></returns>
        IGVPOSBuilder Customer(string customerMail, string customerIP);

        IGVPOSBuilder CreditCard(string number, string cvv2, int month, int year);

        /// <summary>
        /// Sipariş Numarası. Boş bırakılırsa sistem otomatik bir numara belirler
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="groupID"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        IGVPOSBuilder Order(string orderID, string groupID = "", DateTime? startDate = null, DateTime? endDate = null);

        /// <summary>
        /// Sipariş Numarası. Boş bırakılırsa sistem otomatik bir numara belirler
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="recurring"></param>
        /// <param name="groupID"></param>
        /// <returns></returns>
        IGVPOSBuilder Order(string orderID, GVPOSRecurring recurring, string groupID = "");

        /// <summary>
        /// Sipariş ile ilgili adres bilgilerinin eklenmesi sağlar.
        /// </summary>
        /// <param name="type">Adres türü</param>
        /// <param name="city"></param>
        /// <param name="district"></param>
        /// <param name="addressText"></param>
        /// <param name="phone"></param>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="Company"></param>
        /// <param name="postalCode"></param>
        /// <returns></returns>
        IGVPOSBuilder AddOrderAddress(GVPOSAddressTypes type, string city, string district, string addressText, string phone, string name, string lastName, string Company = null, string postalCode = null);

        /// <summary>
        /// Sipariş ile ilgili adres bilgilerinin eklenmesi sağlar.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        IGVPOSBuilder AddOrderAddress(GVPOSAddress address);

        /// <summary>
        /// Siparişe ait ürün / hizmet detayı eklenmesini sağlar.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="productCode"></param>
        /// <param name="productId"></param>
        /// <param name="price"></param>
        /// <param name="quantity"></param>
        /// <param name="totalAmount"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        IGVPOSBuilder AddOrderItem(uint number, string productCode, string productId, double price, double quantity, string description = null, double totalAmount = 0.0);

        /// <summary>
        /// Siparişe ait ürün / hizmet detayı eklenmesini sağlar.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        IGVPOSBuilder AddOrderItem(GVPOSItem item);

        /// <summary>
        /// Raporlama ekranlarında kullanılmak üzere özel açıklama eklemek için kullanılır.
        /// </summary>
        /// <param name="number">Sanal pos ekranında tanımlanan parametre numarası</param>
        /// <param name="text"></param>
        /// <returns></returns>
        IGVPOSBuilder AddOrderComment(uint number, string text);

        /// <summary>
        /// Raporlama ekranlarında kullanılmak üzere özel açıklama eklemek için kullanılır.
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        IGVPOSBuilder AddOrderComment(GVPOSComment comment);

        /// <summary>
        /// Kredi Kartından çekilecek tutar
        /// </summary>
        /// <param name="totalAmount">Tutar</param>
        /// <param name="currencyCode">Para Birimi. Varsayılan: TRL</param>
        /// <returns></returns>
        IGVPOSBuilder Amount(double totalAmount, GVPOSCurrencyCodes currencyCode = GVPOSCurrencyCodes.TRY);

        /// <summary>
        /// Taksitli İşlem
        /// </summary>
        /// <param name="installment">Taksit Sayısı</param>
        /// <returns></returns>
        IGVPOSBuilder Installment(int installment);

        /// <summary>
        /// Bonus İşlem
        /// </summary>
        /// <param name="type">Ödül Tipi</param>
        /// <param name="usedAmount">Kullanılan ödül tutarı</param>
        /// <param name="gainedAmount">Kazanılan ödül tutarı</param>
        /// <returns></returns>
        IGVPOSBuilder Reward(GVPOSRewardTypes type, ulong usedAmount, ulong? gainedAmount = null);

        IGVPOSBuilder Reward(GVPOSRewardRequest reward);

        /// <summary>
        /// Satış
        /// </summary>
        /// <returns></returns>
        GVPOSResponse Sales();

        /// <summary>
        /// Geri İade
        /// </summary>
        /// <returns></returns>
        GVPOSResponse Refund();

        /// <summary>
        /// Geri İade İptali
        /// </summary>
        /// <param name="refundRetrefNum"></param>
        /// <returns></returns>
        GVPOSResponse RefundCancel(string refundRetrefNum);

        /// <summary>
        /// İptal / Kısmi İptal
        /// </summary>
        /// <param name="retrefNum"></param>
        /// <returns></returns>
        GVPOSResponse Cancel(string retrefNum, bool partial = false);

        /// <summary>
        /// Önotorizasyon
        /// </summary>
        /// <returns></returns>
        GVPOSResponse Preauth();

        /// <summary>
        /// Önotorizasyon Kapama
        /// </summary>
        /// <returns></returns>
        GVPOSResponse Postauth();

        /// <summary>
        /// Bonus Sorgulama
        /// </summary>
        /// <returns></returns>
        GVPOSResponse BonusInquiry();

        /// <summary>
        /// İşlem Sorgulama
        /// </summary>
        /// <returns></returns>
        GVPOSResponse OrderInquiry();

        /// <summary>
        /// İşlem Detay Sorgulama
        /// </summary>
        /// <returns></returns>
        GVPOSResponse OrderDetailInquiry();

        /// <summary>
        /// Tarih Aralığı Sorgulama
        /// </summary>
        /// <returns></returns>
        GVPOSResponse DateRangeInquiry(int pageNum);

        /// <summary>
        /// DCC
        /// </summary>
        /// <returns></returns>
        GVPOSResponse DCC();
    }
}
