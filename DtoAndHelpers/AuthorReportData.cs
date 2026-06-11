namespace TheatreReportingApp.DtoAndHelpers
{
    public class AuthorReportData
    {
        public int PerformanceCount { get; set; }
        public string DatesFormatted { get; set; } = "";
        public string PlayTitle { get; set; } = "";
        public string ContractNumbers { get; set; } = "";      
        public string RoyaltyPercentages { get; set; } = "";   
        public string AuthorFees { get; set; } = "";           
        public string AuthorJobs { get; set; } = "";          
        public string AuthorNames { get; set; } = "";        
        public decimal GrossRevenue { get; set; }
        public decimal AuthorFee { get; set; }
    }

    public class AuthorReportContainer
    {
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }
        public List<AuthorReportData> Rows { get; set; } = new();
        public decimal TotalGrossRevenue { get; set; }
        public decimal TotalAuthorFee { get; set; }
    }
}
