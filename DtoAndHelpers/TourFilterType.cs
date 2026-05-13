using System.ComponentModel.DataAnnotations;

namespace TheatreReportingApp.DtoAndHelpers
{
    public enum TourFilterType
    {
        [Display(Name = "По всем")] 
        All = 0,
        [Display(Name = "По России")] 
        Domestic = 1,
        [Display(Name = "Зарубеж")] 
        International = 2
    }
}
