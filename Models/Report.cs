using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheatreReportingApp.Models.Enums;

namespace TheatreReportingApp.Models
{
    public class Report
    {
        [Key]
        public int ReportId { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(150, ErrorMessage = "Максимум 150 символов")]
        public string Title { get; set; }

        [Display(Name = "Тип отчета")]
        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        public ReportType Type { get; set; }

        [Display(Name = "Дата создания отчета")]
        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Дата начала отчета")]
        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        public DateTime FromPeriod { get; set; }

        [Display(Name = "Дата конца отчета")]
        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        public DateTime ToPeriod { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        public string Content { get; set; }

        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public Users User { get; set; }

        public virtual ICollection<Performance>? Performances { get; set; }
    }
}
