using System.ComponentModel.DataAnnotations;

namespace TheatreReportingApp.Models
{
    public class StationarLocation
    {
        [Key]
        public int StationarId { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(100, ErrorMessage = "Максимум 100 символов")]
        public string LocationName { get; set; }

        public virtual ICollection<Performance> Performances { get; set; }
    }
}
