namespace TheatreReportingApp.DtoAndHelpers
{
    public class PlayReportData
    {
        public string PlayTitle { get; set; } = "";
        public int PerformanceCount { get; set; }
        public int TotalAudience { get; set; }
        public int GrossRevenue { get; set; }
        public int RealRevenue { get; set; }
        public int Transferred { get; set; }
    }

    public class PlayReportTotal
    {
        public int TotalPerformances { get; set; }
        public int TotalAudience { get; set; }
        public int GrossRevenue { get; set; }
        public int RealRevenue { get; set; }
        public int TotalTransferred { get; set; }
        public int TotalFreeAudience { get; set; }
        public List<FreeCategoryData> FreeAudienceByCategory { get; set; } = new();
    }

    public class FreeCategoryData
    {
        public string Category { get; set; } = "";
        public int Count { get; set; }
    }

    public class PlayReportDataContainer
    {
        public PlayReportTotal TotalData { get; set; } = new();
        public List<PlayReportData> Plays { get; set; } = new();
    }
}
