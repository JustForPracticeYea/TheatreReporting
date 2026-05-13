using System.ComponentModel.DataAnnotations;

namespace TheatreReportingApp.DtoAndHelpers
{
    public enum OnSiteFilterType
    {
        [Display(Name = "По всем")] 
        All = 0,
        [Display(Name = "Город")] 
        City = 1,
        [Display(Name = "Село")] 
        Village = 2
    }
}
