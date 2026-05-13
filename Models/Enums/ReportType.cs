using System.ComponentModel.DataAnnotations;

namespace TheatreReportingApp.Models.Enums
{
    public enum ReportType
    {
        [Display(Name = "По спектаклям")]
        Performances = 1,

        [Display(Name = "По авторам")]
        Authors = 2
    }
}
