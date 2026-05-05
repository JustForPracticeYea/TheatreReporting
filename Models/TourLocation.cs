using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheatreReportingApp.Models
{
    public class TourLocation
    {
        [Key]
        public int TourId { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(200, ErrorMessage = "Максимум 200 символов")]
        [Display(Name = "Название города")]
        public string TownName { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(200, ErrorMessage = "Максимум 200 символов")]
        [Display(Name = "Страна")]
        public string Country { get; set; }

        public virtual ICollection<Performance> Performances { get; set; }
    }
}
