using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheatreReportingApp.Models.Enums;

namespace TheatreReportingApp.Models
{
    public class Performance
    {
        [Key]
        public int PerformanceId { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Номер спектакля")]
        public int PerformanceNumber { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(100, ErrorMessage = "Максимум 100 символов")]
        [Display(Name = "Тип спектакля")]
        public PerformanceType Type { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Дата проведения спектакля")]
        public DateTime EventDateTime { get; set; }

        [Display(Name = "Дата и время последнего изменения")]
        public DateTime? EditDate { get; set; }

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
        [Display(Name = "Всё количество реализованных билетов, купленных на кассе театра (нал и безнал)")]
        public int AllNumTickSoldInOffice { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Всё количество реализованных билетов, купленных через интернет (нал и безнал)")]
        public int AllNumTickSoldOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Вся сумма денег за реализованные билеты, купленных на кассе театра (нал и безнал)")]
        public int AllAmountTickSoldInOffice { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Вся сумма денег за реализованные билеты, купленных через интернет (нал и безнал)")]
        public int AllAmountTickSoldOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Реально полученная сумма денег за продажи на кассе")]
        public int RealAmountTickSoldInOffice { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Реально полученная сумма денег за продажи через интернет")]
        public int RealAmountTickSoldInOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Итоговое количество билетов, купленных на кассе театра и через интернет за наличку")]
        public int TotalNumTickSoldCashInOfficeOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Итоговая сумма денег за билеты купленные на кассе театра и через интернет за наличку")]
        public int TotalAmountTickSoldCashInOfficeOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Итоговое количество билетов, купленных на кассе театра и через интернет за безнал")]
        public int TotalNumTickSoldNonCashInOfficeOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Итоговая сумма денег за билеты купленные на кассе театра и через интернет за безнал")]
        public int TotalAmountTickSoldNonCashInOfficeOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Итоговое количество возвращенных билетов, купленных на кассе театра и через интернет за наличку")]
        public int TotalNumTickRetCashInOfficeOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Итоговая сумма денег вернувшаяся за билеты купленные на кассе театра и через интернет за наличку")]
        public int TotalAmountFundsRetCashInOfficeOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Итоговое количество возвращенных билетов, купленных на кассе театра и через интернет за безнал")]
        public int TotalNumTickRetNonCashInOfficeOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Итоговая сумма денег вернувшаяся за билеты купленные на кассе театра и через интернет за безнал")]
        public int TotalAmountFundsRetNonCashInOfficeOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Итоговое количество реализованных билетов, купленных за наличку на кассе театра и через интернет")]
        public int TotalNumTickSoldCashOfficeOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Итоговая сумма денег за реализованные билеты, купленных за наличку на кассе театра и через интернет")]
        public int TotalAmountTickSoldCashOfficeOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Итоговое количество реализованных билетов, купленных за безнал на кассе театра и через интернет")]
        public int TotalNumTickSoldNonCashOfficeOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Итоговая сумма денег за реализованные билеты, купленных за безнал на кассе театра и через интернет")]
        public int TotalAmountTickSoldNonCashOfficeOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Итговое количество всех реализованных билетов, купленных на кассе театра и через интернет (нал и безнал)")]
        public int TotalAllNumTickSoldInOfficeOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Вся итоговая сумма денег за реализованные билеты, купленных на кассе театра и через интернет (нал и безнал)")]
        public int TotalAllAmountTickSoldInOfficeOnline { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Итоговая реально полученная сумма денег за продажи на кассе и через интернет")]
        public int TotalRealAmountTickSoldInOfficeOnline { get; set; }

        //

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Аншлаг (всего мест)")]
        public int Capacity { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Максимальная сумма денег за билеты при аншлаге")]
        public int MaxRevenue { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Остаток мест")]
        public int RemainingCapacity { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Сумма денег за остаток билетов")]
        public int RemainingRevenue { get; set;}

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Процент реализации")]
        public double TicketImplementationPercentage { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Display(Name = "Процент реализации средств")]
        public double AmountImplementationPercentage { get; set; }

        //

        public int? StationaryId { get; set; }
        [ForeignKey(nameof(StationaryId))]
        public StationarLocation Stationary { get; set; }

        public int? OnSiteId { get; set; }
        [ForeignKey(nameof(OnSiteId))]
        public OnSiteLocation OnSite { get; set; }

        public int? TourId { get; set; }
        [ForeignKey(nameof(TourId))]
        public TourLocation Tour { get; set; }

        public virtual ICollection<Report>? Reports { get; set; }

        public virtual ICollection<PerformanceViewerCategory>? PerformanceViewerCategories { get; set; }

        public int PlayId { get; set; }

        [ForeignKey(nameof(PlayId))]
        public Play Play { get; set; }

        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public Users User { get; set; }
    }
}
