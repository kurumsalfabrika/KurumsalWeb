using System.ComponentModel;

namespace Kurumsal.Entities.Enums
{
    public enum ProjeDurumu : byte
    {
        [Description("Tamamlanmış")]
        Tamamlanmis = 1,
        [Description("Devam Eden")]
        DevamEden = 2
    }
}
