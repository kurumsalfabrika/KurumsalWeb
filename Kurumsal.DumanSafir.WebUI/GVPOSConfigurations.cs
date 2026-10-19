namespace Kurumsal.DumanSafir.WebUI
{
#pragma warning disable S101 // Types should be named in PascalCase
    public static class GVPOSConfigurations
    {
        //GARANTI VPos definations
        public const string MerchandID = "2539995";
        public const string SubMerchandID = null;
        public const string SecureKey = "4d757374616661313938334d757374616661313938333034";

        //GARANTI Terminal definations
        public const string TerminalID_For_XML = "10291563";
        public const string TerminalID_For_3D = "10291563";
        public const string TerminalID_For_3D_PAY = "10291563";
        public const string TerminalID_For_3D_OOS_PAY = "10291563";
        public const string TerminalID_For_OOS_PAY = "10291563";
        public const string TerminalID_For_3D_FULL = "10291563";

        //GARANTI Provision user definations
        public const string ProvUserID_AUT = "PROVAUT";
        public const string ProvUserID_FRN = "PROVRFN";
        public const string ProvUserID_OOS = "PROVOOS";
        public const string ProvUserID_3DS = "GARANTI";
        public const string ProvUserPassword = "YyDd245.";

        //3D Secure configs
        public const string HostUriSuccessPath = "/success";
        public const string HostUriFailPath = "/fail";

        //Credit card details
        public const string Credit_Card_Number = "4282209027132016";
        public const string Credit_Card_Cvv2 = "358";
        public const int Credit_Card_Month = 9;
        public const int Credit_Card_Year = 26;

        //Credit card details for 3D
        public const string Credit_Card_Number_For_3D = "4282209004348015";
        public const string Credit_Card_Cvv2_For_3D = "123";
        public const int Credit_Card_Month_For_3D = 7;
        public const int Credit_Card_Year_For_3D = 19;

        //Order address details
        public const string Order_Address_Name = "MERKEZ";
        public const string Order_Address_City = "İstanbul";
        public const string Order_Address_District = "Pendik";
        public const string Order_Address_Text = "Çamçeşme Mah. Tersane Cad. No:15 Üst Kaynarca/Pendik - İstanbul";
        public const string Order_Address_PostalCode = "34890";
        public const string Order_Address_Phone = "+902166622000";

        //Customer details
        public const string Customer_Email = "eticaret@garanti.com.tr";
        public const string Customer_IPAddress = "192.168.0.1";
    }
}
