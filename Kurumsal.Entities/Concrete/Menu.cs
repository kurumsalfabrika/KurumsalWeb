using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class Menu : IEntity
    {
        public int Id { get; set; }
        public int AnaMenuId { get; set; } = 0;
        public int MenuYeriId { get; set; }
        public int MenuSira { get; set; } = 1;
        public string MenuAdi { get; set; }
        public string OneCikanGorsel { get; set; }
        public string MenuAciklama { get; set; }
        public int OtomatikListelemeId { get; set; } = 0;
        public int OtomatikListelemeLimiti { get; set; } = 4;
        public string MenuIcon { get; set; }
        public int BagliSayfaId { get; set; } = 0;
        public string BaglantiAdresi { get; set; }
        public bool YeniPenceredeAc { get; set; }
        public bool Durum { get; set; }


        public DateTime Ekleme { get; set; } = DateTime.Now;
    } 
}
