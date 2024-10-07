using System.ComponentModel.DataAnnotations;

namespace QuickSchedule.Shared.Enums
{
    public enum ContactTypeEnum
    {
        [Display(Name = "E-mail")]
        Email = 0,
        [Display(Name = "Tel fixo")]
        LandlinePhone = 1,      // Telefone fixo
        [Display(Name = "Tel móvel")]
        MobilePhone = 2,        // Telefone móvel (celular)
        //[Display(Name = "Tel WhatsApp")]
        //MobileAndWhatsApp = 3   // Telefone móvel com WhatsApp
    }
}
