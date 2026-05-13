using System.ComponentModel.DataAnnotations;

namespace TheatreReportingApp.DtoAndHelpers
{
    public enum PerformanceFilterType
    {
        [Display(Name = "По всем")] 
        All = 0,

        [Display(Name = "Стационар")] 
        Stationary = 1,

        [Display(Name = "Выезд")] 
        OnSite = 2,

        [Display(Name = "Гастроли")] 
        Tour = 3
    }
}
