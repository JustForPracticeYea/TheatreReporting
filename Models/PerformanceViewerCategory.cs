using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheatreReportingApp.Models
{
    public class PerformanceViewerCategory
    {
        [Key]
        public int PerformanceViewerCategoryId { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Количество зрителей")]
        public int ViewerCount { get; set; }
        public int PerformanceId { get; set; }
        [ForeignKey("PerformanceId")]
        public Performance Performance { get; set; }

        public int ViewerCategoryId { get; set; }
        [ForeignKey("ViewerCategoryId")]
        public ViewerCategory ViewerCategory { get; set; }
    }
}
