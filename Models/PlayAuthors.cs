using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheatreReportingApp.Models
{
    public class PlayAuthors
    {
        [Key]
        public int PlayAuthorsId { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Range(1, 100, ErrorMessage = "Процент должен быть от 1 до 100")]
        public decimal RoyaltyPercentage { get; set; }
        public DateTime EditDate { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(100, ErrorMessage = "Максимум 100 символов")]
        [Display(Name = "Номер контракта")]
        public string ContractNumber { get; set; }

        [Display(Name = "Дата начала действия контракта")]
        public DateTime? ContractDate { get; set; }

        public bool ContractIsActive { get; set; }

        public string ExcludedDatesJson { get; set; }

        public int PlayId { get; set; }

        [ForeignKey(nameof(PlayId))]
        public Play Play { get; set; }
        public int AuthorsId { get; set; }

        [ForeignKey(nameof(AuthorsId))]
        public Authors Authors { get; set; }
    }
}
