using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheatreReportingApp.Models
{
    public class ViewerCategory
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Категория зрителей")]
        public string CategoryName { get; set; }

        public virtual ICollection<PerformanceViewerCategory> PerformanceViewerCategories { get; set; }
    }
}
