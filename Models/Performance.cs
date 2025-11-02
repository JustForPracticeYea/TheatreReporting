using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheaterReporting.Models
{
    public class Performance
    {
        [Key]
        public int PerformanceId { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        public int PerformanceNumber { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        public DateTime EventDateTime { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Количество билетов проданных на кассе за наличку")]
        public int NumTickCashOffice { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Количество билетов проданных на кассе за безнал")]
        public int NumTickNonCashOffice { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Количество билетов проданных через интернет за наличку")]
        public int NumTickCashOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Количество билетов проданных через интернет за безнал")]
        public int NumTickNonCashOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Количество возвращенных билетов проданных на кассе за наличку")]
        public int NumTickRetCashOffice { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Количество возвращенных билетов проданных на кассе за безнал")]
        public int NumTickRetNonCashOffice { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Количество возвращенных билетов проданных через интернет за наличку")]
        public int NumTickRetCashOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Количество возвращенных билетов проданных через интернет за безнал")]
        public int NumTickRetNonCashOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Сумма денег полученная за билеты купленные на кассе за наличку")]
        public int AmountTickCashOffice { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Сумма денег полученная за билеты купленные на кассе за безнал")]
        public int AmountTickNonCashOffice { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Сумма денег полученная за билеты купленные через интернет за наличку")]
        public int AmountTickCashOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Сумма денег полученная за билеты купленные через интернет за безнал")]
        public int AmountTickNonCashOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Сумма денег вернувшаяся за билеты купленные на кассе за наличку")]
        public int AmountFundsRetCashOffice { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Сумма денег вернувшаяся за билеты купленные на кассе за безнал")]
        public int AmountFundsRetNonCashOffice { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Сумма денег вернувшаяся за билеты купленные через интернет за наличку")]
        public int AmountFundsRetCashOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Сумма денег вернувшаяся за билеты купленные через интернет за безнал")]
        public int AmountFundsRetNonCashOline { get; set; }



        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Реально полученная сумма денег за продажи на кассе")]
        public int RealAmountTickSoldInOffice { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Реально полученная сумма денег за продажи через интернет")]
        public int RealAmountTickSoldInOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Количество зрителей обслуженных бесплатно")]
        public int NumViewrsServedFree { get; set; }

        public List<Report>? Reports { get; set; }

        public int PlayId { get; set; }

        [ForeignKey(nameof(PlayId))]
        public Play Play { get; set; }
    }
}
