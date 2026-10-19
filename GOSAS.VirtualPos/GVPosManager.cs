using GOSAS.VirtualPos.Core.Enums;
using GOSAS.VirtualPos.Core.Objects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace GOSAS.VirtualPos.Core
{
#pragma warning disable S3928 // Parameter names used into ArgumentException constructors should match an existing one 

    public class GVPosManager : IGVPOSBuilder
    {
        private GVPOSRequest GVPosRequest { get; set; }

        private const GVPOSRequestModes REQUEST_TEST_MODE = GVPOSRequestModes.Test;
        private const GVPOSRequestModes REQUEST_PROD_MODE = GVPOSRequestModes.Production;
        private const string REQUEST_USER_PROVAUT = "PROVAUT"; //Provizyon kullanıcısı
        private const string REQUEST_USER_PROVRFN = "PROVRFN"; //İptal ve İade işlemlerinde kullanılır

        private string REQUEST_URL;
        private string REQUEST_URL_FOR_3D;
        private string hashedPassword;

        public GVPosManager(bool test = false)
        {
            var provider = CodePagesEncodingProvider.Instance;
            Encoding.RegisterProvider(provider);

            GVPosRequest = new GVPOSRequest
            {
                Version = "512",
                Terminal = new GVPOSTerminal()
            };
            GVPosRequest.Terminal.ProvUserID = REQUEST_USER_PROVAUT;

            GVPosRequest.Transaction = new GVPOSTransaction
            {
                Type = GVPOSTransactionTypes.sales,
                MotoInd = GVPOSMotoInds.ECommerce,
                CurrencyCode = GVPOSCurrencyCodes.TRY
            };

            this.Test(test);
        }

        public IGVPOSBuilder Environment(string posUrl)
        {
            if (!String.IsNullOrEmpty(posUrl))
                REQUEST_URL = posUrl;

            return this;
        }

        public IGVPOSBuilder Test(bool isTest = true)
        {
            if (isTest)
            {
                this.REQUEST_URL = "https://sanalposprovtest.garantibbva.com.tr/VPServlet";
                this.REQUEST_URL_FOR_3D = "https://sanalposprovtest.garantibbva.com.tr/servlet/gt3dengine";
                GVPosRequest.Mode = REQUEST_TEST_MODE;
            }
            else
            {
                this.REQUEST_URL = "https://sanalposprov.garanti.com.tr/VPServlet";
                this.REQUEST_URL_FOR_3D = "https://sanalposprov.garanti.com.tr/servlet/gt3dengine";
                GVPosRequest.Mode = REQUEST_PROD_MODE;
            }
            return this;
        }

        public IGVPOSBuilder Company(string terminalId, string MerchantID, string userID, string userPassword, string SubMerchantID = null)
        {
            GVPosRequest.Terminal.ID = terminalId;
            GVPosRequest.Terminal.MerchantID = MerchantID;
            GVPosRequest.Terminal.SubMerchantID = SubMerchantID;
            GVPosRequest.Terminal.UserID = userID;
            this.hashedPassword = GVPOSHelper.Sha1(userPassword + GVPOSHelper.IsRequireZero(terminalId, 9)).ToUpper();
            return this;
        }

        public IGVPOSBuilder Customer(string customerMail, string customerIP)
        {
            GVPosRequest.Customer = GVPosRequest.Customer ?? new GVPOSCustomer();

            GVPosRequest.Customer.EmailAddress = customerMail;
            GVPosRequest.Customer.IPAddress = customerIP;

            return this;
        }

        public IGVPOSBuilder CreditCard(string number, string cvv2, int month, int year)
        {
            GVPosRequest.Card = GVPosRequest.Card ?? new GVPOSCard();

            GVPosRequest.Card.Number = number;
            GVPosRequest.Card.CVV2 = cvv2.ToString();
            GVPosRequest.Card.ExpireDate = String.Format("{0}{1}", IsRequireZero(month), IsRequireZero(year));

            return this;
        }

        public IGVPOSBuilder Order(string orderID, string groupID = "", DateTime? startDate = null, DateTime? endDate = null)
        {
            GVPosRequest.Order = GVPosRequest.Order ?? new GVPOSOrder();
            GVPosRequest.Order.OrderID = orderID;
            GVPosRequest.Order.GroupID = groupID;

            if (startDate != null && endDate != null)
            {
                GVPosRequest.Order.StartDate = startDate.Value.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                GVPosRequest.Order.EndDate = endDate.Value.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            }
            return this;
        }

        public IGVPOSBuilder Order(string orderID, GVPOSRecurring recurring, string groupID = "")
        {
            GVPosRequest.Order = GVPosRequest.Order ?? new GVPOSOrder();
            GVPosRequest.Order.OrderID = orderID;
            GVPosRequest.Order.GroupID = groupID;
            GVPosRequest.Order.Recurring = recurring;
            return this;
        }

        public IGVPOSBuilder AddOrderAddress(GVPOSAddressTypes type, string city, string district, string addressText, string phone, string name, string lastName, string Company = null, string postalCode = null)
        {
            var address = new GVPOSAddress
            {
                Type = type,
                City = city,
                District = district,
                Text = addressText,
                PhoneNumber = phone,
                Name = name,
                LastName = lastName,
                Company = Company,
                PostalCode = postalCode
            };
            return AddOrderAddress(address);
        }

        public IGVPOSBuilder AddOrderAddress(GVPOSAddress address)
        {
            if (address == null)
            {
                throw new ArgumentNullException("address");
            }
            if (GVPosRequest.Order == null)
            {
                throw new ArgumentException("Order must first be defined.", nameof(GVPosRequest.Order));
            }
            if (address.Type == GVPOSAddressTypes.Unspecified)
            {
                throw new ArgumentOutOfRangeException(nameof(address.Type), "The address type must be defined.");
            }
            GVPosRequest.Order.AddressList = GVPosRequest.Order.AddressList ?? new GVPOSAddressList();
            GVPosRequest.Order.AddressList.Address = GVPosRequest.Order.AddressList.Address ?? new GVPOSAddress[] { };
            var Addresses = new List<GVPOSAddress>();
            Addresses.AddRange(GVPosRequest.Order.AddressList.Address);
            if (Addresses.Any(e => e.Type.Equals(address.Type)))
            {
                throw new ArgumentException("Address type already defined.");
            }

            Addresses.Add(address);
            GVPosRequest.Order.AddressList.Address = Addresses.ToArray();
            return this;
        }

        public IGVPOSBuilder AddOrderItem(uint number, string productCode, string productId, double price, double quantity, string description = null, double totalAmount = 0.0)
        {
            if ((number > 99) || (number < 1))
            {
                throw new ArgumentOutOfRangeException("number", "Must be between 1 and 99");
            }
            if (quantity <= 0)
            {
                throw new ArgumentOutOfRangeException("quantity", "Must be greater than 0");
            }
            if (totalAmount < 0)
            {
                throw new ArgumentOutOfRangeException("totalAmount", "Must be greater than 0");
            }
            totalAmount = (totalAmount == 0.0) ? (price * quantity) : totalAmount;
            var item = new GVPOSItem
            {
                Description = description,
                Number = number,
                Price = (ulong)(Math.Round(price, 2) * 100),
                ProductCode = productCode,
                ProductID = productId,
                Quantity = (ulong)(Math.Round(quantity, 2) * 100),
                TotalAmount = (ulong)(Math.Round(totalAmount, 2) * 100)
            };
            return AddOrderItem(item);
        }

        public IGVPOSBuilder AddOrderItem(GVPOSItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            if (GVPosRequest.Order == null)
            {
                throw new ArgumentException("Order must first be defined.", nameof(GVPosRequest.Order));
            }
            if ((item.Number > 99) || (item.Number < 1))
            {
                throw new ArgumentOutOfRangeException(nameof(item.Number), "Must be between 1 and 99");
            }
            if (item.Quantity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(item.Quantity), "Must be greater than 0");
            }
            if (item.TotalAmount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(item.TotalAmount), "Must be greater than 0");
            }
            GVPosRequest.Order.ItemList = GVPosRequest.Order.ItemList ?? new GVPOSItemList();
            GVPosRequest.Order.ItemList.Item = GVPosRequest.Order.ItemList.Item ?? new GVPOSItem[] { };
            var Items = new List<GVPOSItem>();
            Items.AddRange(GVPosRequest.Order.ItemList.Item);
            Items.Add(item);
            GVPosRequest.Order.ItemList.Item = Items.ToArray();
            return this;
        }

        public IGVPOSBuilder AddOrderComment(uint number, string text)
        {
            var comment = new GVPOSComment
            {
                Number = number,
                Text = text
            };
            return AddOrderComment(comment);
        }

        public IGVPOSBuilder AddOrderComment(GVPOSComment comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException("comment");
            }
            if (GVPosRequest.Order == null)
            {
                throw new ArgumentException("Order must first be defined.", nameof(GVPosRequest.Order));
            }
            if (comment.Number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(comment.Number));
            }
            if (!string.IsNullOrEmpty(comment.Text) && (comment.Text.Length > 20))
            {
                throw new ArgumentException("Comment text field must be max 20 char.");
            }

            GVPosRequest.Order.CommentList = GVPosRequest.Order.CommentList ?? new GVPOSCommentList();
            GVPosRequest.Order.CommentList.Comment = GVPosRequest.Order.CommentList.Comment ?? new GVPOSComment[] { };
            var Comments = new List<GVPOSComment>();
            Comments.AddRange(GVPosRequest.Order.CommentList.Comment);
            if (Comments.Any(e => e.Number.Equals(comment.Number)))
            {
                throw new ArgumentException("Comment number already defined.");
            }
            Comments.Add(comment);
            GVPosRequest.Order.CommentList.Comment = Comments.ToArray();
            return this;
        }

        public IGVPOSBuilder Amount(double totalAmount, GVPOSCurrencyCodes currencyCode = GVPOSCurrencyCodes.TRY)
        {
            GVPosRequest.Transaction.Amount = (ulong)(Math.Round(totalAmount, 2) * 100);
            GVPosRequest.Transaction.CurrencyCode = currencyCode;

            return this;
        }

        public IGVPOSBuilder Installment(int installment)
        {
            GVPosRequest.Transaction.InstallmentCnt = installment <= 0 ? string.Empty : installment.ToString();

            return this;
        }

        public IGVPOSBuilder Reward(GVPOSRewardTypes type, ulong usedAmount, ulong? gainedAmount = null)
        {
            var reward = new GVPOSRewardRequest
            {
                Type = type,
                UsedAmount = usedAmount,
                GainedAmount = gainedAmount
            };
            return Reward(reward);
        }

        public IGVPOSBuilder Reward(GVPOSRewardRequest reward)
        {
            GVPosRequest.Transaction.RewardList = GVPosRequest.Transaction.RewardList ?? new GVPOSRewardList();
            GVPosRequest.Transaction.RewardList.Reward = GVPosRequest.Transaction.RewardList.Reward ?? new GVPOSRewardRequest[] { };
            var Rewards = new List<GVPOSRewardRequest>();
            Rewards.AddRange(GVPosRequest.Transaction.RewardList.Reward);
            Rewards.Add(reward);
            GVPosRequest.Transaction.RewardList.Reward = Rewards.ToArray();
            return this;
        }

        public GVPOSResponse Sales()
        {
            if (GVPosRequest == null)
                throw new ArgumentNullException("GVPosRequest");
            if ((GVPosRequest.Order == null) || string.IsNullOrWhiteSpace(GVPosRequest.Order.OrderID))
                throw new ArgumentNullException("Order ID");
            if ((GVPosRequest.Card == null) || string.IsNullOrWhiteSpace(GVPosRequest.Card.Number))
                throw new ArgumentNullException("Card Number");
            if ((GVPosRequest.Terminal == null) || string.IsNullOrWhiteSpace(GVPosRequest.Terminal.ID))
                throw new ArgumentNullException("Terminal ID");
            if (GVPosRequest.Transaction == null)
                throw new ArgumentNullException("Transaction");

            GVPosRequest.Transaction.Type = GVPOSTransactionTypes.sales;
            GVPosRequest.Transaction.CardholderPresentCode = GVPOSCardholderPresentCodes.Normal;

            GVPosRequest.Terminal.HashData = GVPOSHelper.Sha512(GVPosRequest.Order.OrderID + GVPosRequest.Terminal.ID + GVPosRequest.Card.Number + GVPosRequest.Transaction.Amount + (int)GVPosRequest.Transaction.CurrencyCode + this.hashedPassword).ToUpper();

            return Send();
        }

        public GVPOSResponse DCC()
        {
            if (GVPosRequest == null)
                throw new ArgumentNullException("GVPosRequest");
            if ((GVPosRequest.Order == null) || string.IsNullOrWhiteSpace(GVPosRequest.Order.OrderID))
                throw new ArgumentNullException("Order ID");
            if ((GVPosRequest.Card == null) || string.IsNullOrWhiteSpace(GVPosRequest.Card.Number))
                throw new ArgumentNullException("Card Number");
            if ((GVPosRequest.Terminal == null) || string.IsNullOrWhiteSpace(GVPosRequest.Terminal.ID))
                throw new ArgumentNullException("Terminal ID");
            if (GVPosRequest.Transaction == null)
                throw new ArgumentNullException("Transaction");

            GVPosRequest.Transaction.Type = GVPOSTransactionTypes.dccinq;
            GVPosRequest.Transaction.CardholderPresentCode = GVPOSCardholderPresentCodes.Normal;

            GVPosRequest.Terminal.HashData = GVPOSHelper.Sha512(GVPosRequest.Order.OrderID + GVPosRequest.Terminal.ID + GVPosRequest.Card.Number + GVPosRequest.Transaction.Amount + (int)GVPosRequest.Transaction.CurrencyCode + this.hashedPassword).ToUpper();

            return Send();
        }

        public GVPOSResponse BonusInquiry()
        {
            if (GVPosRequest == null)
                throw new ArgumentNullException("GVPosRequest");
            if ((GVPosRequest.Order == null) || string.IsNullOrWhiteSpace(GVPosRequest.Order.OrderID))
                throw new ArgumentNullException("Order ID");
            if ((GVPosRequest.Card == null) || string.IsNullOrWhiteSpace(GVPosRequest.Card.Number))
                throw new ArgumentNullException("Card Number");
            if ((GVPosRequest.Terminal == null) || string.IsNullOrWhiteSpace(GVPosRequest.Terminal.ID))
                throw new ArgumentNullException("Terminal ID");
            if (GVPosRequest.Transaction == null)
                throw new ArgumentNullException("Transaction");

            GVPosRequest.Transaction.Type = GVPOSTransactionTypes.rewardinq;
            GVPosRequest.Transaction.CardholderPresentCode = GVPOSCardholderPresentCodes.Normal;

            GVPosRequest.Terminal.HashData = GVPOSHelper.Sha512(GVPosRequest.Order.OrderID + GVPosRequest.Terminal.ID + GVPosRequest.Card.Number + GVPosRequest.Transaction.Amount + (int)GVPosRequest.Transaction.CurrencyCode + this.hashedPassword).ToUpper();

            return Send();
        }

        public GVPOSResponse Refund()
        {
            GVPosRequest.Transaction.Type = GVPOSTransactionTypes.refund;
            GVPosRequest.Terminal.ProvUserID = REQUEST_USER_PROVRFN;
            GVPosRequest.Transaction.CardholderPresentCode = GVPOSCardholderPresentCodes.Normal;
            GVPosRequest.Transaction.MotoInd = GVPOSMotoInds.H;
            GVPosRequest.Terminal.HashData = GVPOSHelper.Sha512(GVPosRequest.Order.OrderID + GVPosRequest.Terminal.ID + GVPosRequest.Transaction.Amount + (int)GVPosRequest.Transaction.CurrencyCode + this.hashedPassword).ToUpper();
            return Send();
        }

        public GVPOSResponse RefundCancel(string refundRetrefNum)
        {
            return Cancel(refundRetrefNum);
        }

        public GVPOSResponse Cancel(string retrefNum, bool partial = false)
        {
            if (GVPosRequest == null)
                throw new ArgumentNullException("request");
            if (GVPosRequest.Order == null)
                throw new ArgumentNullException("Order");
            if (string.IsNullOrWhiteSpace(GVPosRequest.Order.OrderID))
                throw new ArgumentNullException("OrderID");
            if (GVPosRequest.Terminal == null)
                throw new ArgumentNullException("Terminal");
            if (string.IsNullOrWhiteSpace(GVPosRequest.Terminal.ID))
                throw new ArgumentNullException("Terminal ID");
            if (GVPosRequest.Transaction == null)
                throw new ArgumentNullException("Transaction");

            if (partial)
            {
                GVPosRequest.Transaction.Type = GVPOSTransactionTypes.partialvoid;
            }
            else
            {
                GVPosRequest.Transaction.Type = GVPOSTransactionTypes.@void;
            }
            
            GVPosRequest.Terminal.ProvUserID = REQUEST_USER_PROVRFN;
            GVPosRequest.Transaction.OriginalRetrefNum = retrefNum;

            GVPosRequest.Terminal.HashData = GVPOSHelper.Sha512(GVPosRequest.Order.OrderID + GVPosRequest.Terminal.ID + GVPosRequest.Transaction.Amount + (int)GVPosRequest.Transaction.CurrencyCode + this.hashedPassword).ToUpper();

            return Send();
        }

        public GVPOSResponse Preauth()
        {
            GVPosRequest.Transaction.Type = GVPOSTransactionTypes.preauth;
            GVPosRequest.Transaction.MotoInd = GVPOSMotoInds.ECommerce;
            GVPosRequest.Transaction.CardholderPresentCode = GVPOSCardholderPresentCodes.Normal;
            GVPosRequest.Terminal.HashData = GVPOSHelper.Sha512(GVPosRequest.Order.OrderID + GVPosRequest.Terminal.ID + GVPosRequest.Card.Number + GVPosRequest.Transaction.Amount + (int)GVPosRequest.Transaction.CurrencyCode + this.hashedPassword).ToUpper();
            return Send();
        }

        public GVPOSResponse Postauth()
        {
            GVPosRequest.Transaction.Type = GVPOSTransactionTypes.postauth;
            GVPosRequest.Transaction.MotoInd = GVPOSMotoInds.ECommerce;
            GVPosRequest.Transaction.CardholderPresentCode = GVPOSCardholderPresentCodes.Normal;
            GVPosRequest.Terminal.HashData = GVPOSHelper.Sha512(GVPosRequest.Order.OrderID + GVPosRequest.Terminal.ID + GVPosRequest.Transaction.Amount + (int)GVPosRequest.Transaction.CurrencyCode + this.hashedPassword).ToUpper();
            return Send();
        }

        public GVPOSResponse OrderInquiry()
        {
            if (GVPosRequest == null)
                throw new ArgumentNullException("GVPosRequest");
            if ((GVPosRequest.Order == null) || string.IsNullOrWhiteSpace(GVPosRequest.Order.OrderID))
                throw new ArgumentNullException("Order ID");
            if ((GVPosRequest.Terminal == null) || string.IsNullOrWhiteSpace(GVPosRequest.Terminal.ID))
                throw new ArgumentNullException("Terminal ID");
            if (GVPosRequest.Transaction == null)
                throw new ArgumentNullException("Transaction");

            GVPosRequest.Transaction.Type = GVPOSTransactionTypes.orderinq;
            GVPosRequest.Transaction.CardholderPresentCode = GVPOSCardholderPresentCodes.Unspecified;

            GVPosRequest.Terminal.HashData = GVPOSHelper.Sha512(GVPosRequest.Order.OrderID + GVPosRequest.Terminal.ID + GVPosRequest.Transaction.Amount + (int)GVPosRequest.Transaction.CurrencyCode + this.hashedPassword).ToUpper();

            return Send();
        }

        public GVPOSResponse OrderDetailInquiry()
        {
            if (GVPosRequest == null)
                throw new ArgumentNullException("GVPosRequest");
            if ((GVPosRequest.Order == null) || string.IsNullOrWhiteSpace(GVPosRequest.Order.OrderID))
                throw new ArgumentNullException("Order ID");
            if ((GVPosRequest.Terminal == null) || string.IsNullOrWhiteSpace(GVPosRequest.Terminal.ID))
                throw new ArgumentNullException("Terminal ID");
            if (GVPosRequest.Transaction == null)
                throw new ArgumentNullException("Transaction");

            GVPosRequest.Transaction.Type = GVPOSTransactionTypes.orderhistoryinq;
            GVPosRequest.Transaction.CardholderPresentCode = GVPOSCardholderPresentCodes.Unspecified;

            GVPosRequest.Terminal.HashData = GVPOSHelper.Sha512(GVPosRequest.Order.OrderID + GVPosRequest.Terminal.ID + GVPosRequest.Transaction.Amount + (int)GVPosRequest.Transaction.CurrencyCode + this.hashedPassword).ToUpper();

            return Send();
        }

        public GVPOSResponse DateRangeInquiry(int pageNum)
        {
            if (GVPosRequest == null)
                throw new ArgumentNullException("GVPosRequest");
            if ((GVPosRequest.Order == null) || string.IsNullOrWhiteSpace(GVPosRequest.Order.OrderID))
                throw new ArgumentNullException("Order ID");
            if ((GVPosRequest.Order == null) || string.IsNullOrWhiteSpace(GVPosRequest.Order.StartDate) || string.IsNullOrWhiteSpace(GVPosRequest.Order.EndDate))
                throw new ArgumentNullException("Order Start/End Date");
            if ((GVPosRequest.Terminal == null) || string.IsNullOrWhiteSpace(GVPosRequest.Terminal.ID))
                throw new ArgumentNullException("Terminal ID");
            if (GVPosRequest.Transaction == null)
                throw new ArgumentNullException("Transaction");

            GVPosRequest.Transaction.Type = GVPOSTransactionTypes.orderlistinq;
            GVPosRequest.Transaction.ListPageNum = pageNum;
            GVPosRequest.Transaction.CardholderPresentCode = GVPOSCardholderPresentCodes.Unspecified;

            GVPosRequest.Terminal.HashData = GVPOSHelper.Sha512(GVPosRequest.Order.OrderID + GVPosRequest.Terminal.ID + GVPosRequest.Transaction.Amount + (int)GVPosRequest.Transaction.CurrencyCode + this.hashedPassword).ToUpper();

            return Send();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        #region Privates
        private string IsRequireZero(int time)
        {
            var formatedTime = time > 2000 ? IsRequireZero(time - 2000) : time.ToString();
            return time < 10 ? String.Format("0{0}", time) : formatedTime;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="TModel"></param>
        /// <returns></returns>
        private string SerializeObjectToXmlString<T>(T TModel)
        {
            XmlSerializerNamespaces EmptyNameSpace = new XmlSerializerNamespaces();
            EmptyNameSpace.Add("", "");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            MemoryStream memoryStream = new MemoryStream();
            XmlTextWriter xmlWriter = new XmlTextWriter(memoryStream, Encoding.GetEncoding("ISO-8859-9"));

            xmlSerializer.Serialize(xmlWriter, TModel, EmptyNameSpace);

            memoryStream = (MemoryStream)xmlWriter.BaseStream;
            var xmlData = Encoding.GetEncoding("ISO-8859-9").GetString(memoryStream.ToArray());

            return xmlData;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlData"></param>
        /// <returns></returns>
        private T DeSerializeObject<T>(string xmlData)
        {
            T deSerializeObject = default;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            StringReader stringReader = new StringReader(xmlData);
            XmlReader XR = new XmlTextReader(stringReader);

            if (xmlSerializer.CanDeserialize(XR))
            {
                deSerializeObject = (T)xmlSerializer.Deserialize(XR);
            }

            return deSerializeObject;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Host"></param>
        /// <param name="Method"></param>
        /// <param name="Params"></param>
        /// <returns></returns>
        private string SendHttpRequest(string Host, string Method, string Params)
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            { return true; };

            var returnSrting = String.Empty;

            var request = (HttpWebRequest)WebRequest.Create(Host);
            request.Timeout = 30000;
            request.Method = Method;

            var bytes = new ASCIIEncoding().GetBytes(Params);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = Params.Length;

            using (var requestStream = request.GetRequestStream())
            {
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
            }

            using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream()))
            {
                returnSrting = sr.ReadToEnd();
            }

            return returnSrting;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Use3D"></param>
        /// <returns></returns>
        private GVPOSResponse Send(bool Use3D = false)
        {
            var gvpResponse = new GVPOSResponse();
            var xmlString = SerializeObjectToXmlString<GVPOSRequest>(GVPosRequest);
            gvpResponse.RawRequest = xmlString;

            try
            {
                var responseString = string.Empty;
                if (Use3D)
                {
                    responseString = SendHttpRequest(REQUEST_URL_FOR_3D, "Post", String.Format("data={0}", WebUtility.UrlEncode(xmlString)));
                }
                else
                {
                    responseString = SendHttpRequest(REQUEST_URL, "Post", String.Format("data={0}", WebUtility.UrlEncode(xmlString)));
                }
                gvpResponse.RawResponse = responseString;
                gvpResponse = DeSerializeObject<GVPOSResponse>(responseString);
                gvpResponse.RawRequest = xmlString;
                gvpResponse.RawResponse = responseString;
            }
            catch (Exception ex)
            {
                gvpResponse.Transaction = new GVPOSTransaction();
                gvpResponse.Order = new GVPOSOrder();
                gvpResponse.Transaction.Response = new GVPOSTransactionResponse
                {
                    Code = "99",
                    Message = ex.Message,
                    ErrorMsg = ex.StackTrace
                };
            }

            return gvpResponse;
        }

        #endregion
    }
}