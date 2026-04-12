using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheatreReportingApp.Models;

namespace TheatreReportingApp.DtoAndHelpers
{
    public class PerformanceDto
    {
        public int PerformanceId { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Номер спектакля")]
        public int PerformanceNumber { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Место проведения")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Дата проведения")]
        public DateTime SelectedDate { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Время проведения")]
        public DateTime? SelectedTime { get; set; }
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
        [Display(Name = "Количество реализованных билетов, купленных за наличку на кассе театра")]
        public int NumTickSoldCashOffice { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Количество реализованных билетов, купленных за безнал на кассе театра")]
        public int NumTickSoldNonCashOffice { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Количество реализованных билетов, купленных за наличку через интернет")]
        public int NumTickSoldCashOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Количество реализованных билетов, купленных за безнал через интернет")]
        public int NumTickSoldNonCashOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Сумма денег за реализованные билеты, купленных за наличку на кассе театра")]
        public int AmountTickSoldCashOffice { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Сумма денег за реализованные билеты, купленных за безнал на кассе театра")]
        public int AmountTickSoldNonCashOffice { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Сумма денег за реализованные билеты, купленных за наличку через интернет")]
        public int AmountTickSoldCashOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Сумма денег за реализованные билеты, купленных за безнал через интернет")]
        public int AmountTickSoldNonCashOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Итоговое количество реализованных билетов, купленных на кассе театра (нал и безнал)")]
        public int TotalNumTickSoldInOffice { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Итоговое количество реализованных билетов, купленных на интернет (нал и безнал)")]
        public int TotalNumTickSoldOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Итоговая сумма денег за реализованные билеты, купленных на кассе театра (нал и безнал)")]
        public int TotalAmountTickSoldInOffice { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Итоговая сумма денег за реализованные билеты, купленных через интернет (нал и безнал)")]
        public int TotalAmountTickSoldOnline { get; set; }

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
