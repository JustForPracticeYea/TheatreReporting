using System.ComponentModel.DataAnnotations;
using TheatreReportingApp.Models.Enums;

namespace TheatreReportingApp.Models
{
    public class OnSiteLocation
    {
        [Key]
        public int OnSiteId { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(200, ErrorMessage = "Максимум 200 символов")]
        [Display(Name = "Название города")]
        public string TownName { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Тип населенного пункта")]
        public SettlementType SettlementType { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(200, ErrorMessage = "Максимум 200 символов")]
        [Display(Name = "Регион")]
        public string Region { get; set; }

        public virtual ICollection<Performance> Performances { get; set; }
    }
}
