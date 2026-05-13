using System.ComponentModel.DataAnnotations;

namespace TheatreReportingApp.Models.Enums
{
    public enum SettlementType
    {
        [Display(Name = "Город")]
        City = 1,

        [Display(Name = "Село")]
        Village = 2
    }
}
