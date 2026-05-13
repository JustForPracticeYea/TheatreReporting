using System.ComponentModel.DataAnnotations;

namespace TheatreReportingApp.Models.Enums
{
    public enum PerformanceType
    {
        [Display(Name = "Стационар")]
        Stationary = 1,

        [Display(Name = "Выезд")]
        OnSite = 2,

        [Display(Name = "Гастроли")]
        Tour = 3
    }
}
