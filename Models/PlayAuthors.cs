using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheatreReportingApp.Models
{
    public class PlayAuthors
    {
        [Key]
        public int PlayAuthorsId { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Range(0, 100, ErrorMessage = "Процент должен быть от 0 до 100")]
        public decimal RoyaltyPercentage { get; set; }
        public DateTime EditDate { get; set; }

        public int PlayId { get; set; }

        [ForeignKey(nameof(PlayId))]
        public Play Play { get; set; }
        public int AuthorsId { get; set; }

        [ForeignKey(nameof(AuthorsId))]
        public Authors Authors { get; set; }
    }
}
